using Lab.EF.Entities;
using Lab.EF.Logic;
using Lab.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;
using HttpDeleteAttribute = System.Web.Http.HttpDeleteAttribute;

namespace Lab.WebApi.Controllers
{
    public class ShippersController : ApiController
    {
        OrdersLogic orderLogic = new OrdersLogic();
        ShippersLogic shipperLogic = new ShippersLogic();
        // GET: Shippers

        /// <summary>
        /// Obtiene todos los Shippers
        /// </summary>
        /// <returns>Shippers List</returns>
        [ResponseType(typeof(ShippersView))]
        public IHttpActionResult GetAll()
        {
            try 
            {
                List<Shippers> shippersList = shipperLogic.ObtenerTodo();
                List<ShippersView> shippersViewsList = shippersList.Select(s => new ShippersView
                {
                    ID = s.ShipperID,
                    companyName = s.CompanyName,
                    phone = s.Phone
                }).ToList();

                if (shippersViewsList.Count == 0)
                {
                    return NotFound();
                }

                return Ok(shippersViewsList);
            }catch(Exception ex) 
            { 
                return BadRequest(ex.Message);
            }
           
        }
        /// <summary>
        /// Obtiene Shippers por ID
        /// </summary>
        /// <param name="id">ID de Shipper</param>
        /// <returns>Shipper</returns>
        /// <response code="200">Shipper encontrado</response>
        /// <response code="404">Shipper no encontrado</response>
        [ResponseType(typeof(ShippersView))]
        public IHttpActionResult Get(int id)
        {

            try
            {
                Shippers shipper = shipperLogic.ObtenerShipperPorId(id);

                if (shipper != null)
                {
                    ShippersView shipperView = new ShippersView
                    {
                        ID = shipper.ShipperID,
                        companyName = shipper.CompanyName,
                        phone = shipper.Phone
                    };
                    return Ok(shipperView);
                }
                else
                {
                    return NotFound();
                }

            } catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }
        /// <summary>
        /// Agrega un Shipper
        /// </summary>
        /// <param name="shippersView"></param>
        /// <returns>Shipper creado</returns>
        /// <response code="201">Shipper creado</response>
        [ResponseType(typeof(ShippersView))]
        public IHttpActionResult Add([FromBody] ShippersView shippersView)
        {
            try
            {
                Shippers shippers = new Shippers
                {
                    ShipperID = shippersView.ID,
                    CompanyName = shippersView.companyName,
                    Phone = shippersView.phone
                };
                shipperLogic.InsertarData(shippers);
                return Content(HttpStatusCode.Created, shippers);
            } catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }
        /// <summary>
        /// Elimina un Shipper
        /// </summary>
        /// <param name="id">ID del Shipper</param>
        /// <returns>Shipper eliminado</returns>
        /// <response code="200">Shipper eliminado</response>
        /// <response code="404">Shipper no encontrado</response> 
        [HttpDelete]
        public IHttpActionResult Delete(int id) 
        {
            try
            {
                Shippers shipper = shipperLogic.ObtenerShipperPorId(id);
                if (shipper != null)
                {

                    foreach (var order in shipper.Orders)
                    {

                        foreach (var orderD in order.Order_Details)
                        {
                            orderLogic.BorrarOrderDetail(orderD.OrderID, orderD.ProductID);
                        }
                        orderLogic.BorrarOrders(order.OrderID);

                    }
                    shipperLogic.Borrar(shipper);
                    return Ok("Shipper Eliminado");
                }
                else
                {
                    return NotFound();
                }
            } catch(Exception ex)
            {
                return BadRequest($"Error al Eliminar: {ex.Message}");
            }
            
        }
        /// <summary>
        /// Modifica un Shipper
        /// </summary>
        /// <param name="shippersView"></param>
        /// <returns>Shipper Modificado</returns>
        [HttpPut]
        public IHttpActionResult Update([FromBody] ShippersView shippersView)
        {
            try
            {
                Shippers shipper = shipperLogic.ObtenerShipperPorId(shippersView.ID);

                if(shipper != null)
                {
                    Shippers nuevoShipper = new Shippers
                    {
                        ShipperID = shippersView.ID,
                        CompanyName = shippersView.companyName,
                        Phone = shippersView.phone
                    };

                    shipperLogic.Modificar(nuevoShipper);
                    return Ok("Shipper Modificado");
                }
                else
                {
                    return NotFound();
                }
            } catch(Exception ex) 
            {
                return BadRequest($"Error al Modificar: {ex.Message}");
            }

        }


    }
}