using Lab.EF.Entities;
using Lab.EF.Logic;
using Lab.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab.MVC.Controllers
{
    public class ShippersController : Controller
    {
        OrdersLogic orderLogic = new OrdersLogic();

        ShippersLogic sLogic = new ShippersLogic();



        // GET: Shippers


        public ActionResult Index()
        {

            List<Shippers> listDeShippers = sLogic.ObtenerTodo();

            List<ShippersView> sView = listDeShippers.Select(s => new ShippersView
            {
                ID = s.ShipperID,
                companyName= s.CompanyName,
                phone = s.Phone,
            }).ToList();



            return View(sView);
        }

        public ActionResult Insert(int shippersId = 0)
        {
            if(shippersId == 0)
            {
                return View();

            }
            else 
            {
                Shippers shipperU = sLogic.ObtenerShipperPorId(shippersId);
                if (shipperU != null)
                {
                    ShippersView shipperView = new ShippersView { ID = shipperU.ShipperID, companyName = shipperU.CompanyName, phone = shipperU.Phone };

                    return View(shipperView);
                }

                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public ActionResult Insert(ShippersView shippersView)
        {
            try
            {
                    Shippers shipperEntity = new Shippers { ShipperID = shippersView.ID, CompanyName = shippersView.companyName, Phone = shippersView.phone };
                    sLogic.InsertarData(shipperEntity);
                    return RedirectToAction("Index");

            }catch(Exception) 
            { 
            
                    return View(shippersView);
            }

              

         
        }

        public ActionResult Delete(int shippersId)
        {

           Shippers shipper = sLogic.ObtenerShipperPorId(shippersId);
            if(shipper != null) 
            {

                foreach (var order in shipper.Orders)
                {

                    foreach (var orderD in order.Order_Details)
                    {
                        orderLogic.BorrarOrderDetail(orderD.OrderID, orderD.ProductID);
                    }
                    orderLogic.BorrarOrders(order.OrderID);

                }
                sLogic.Borrar(shipper);
            }

            return RedirectToAction("Index");
        }    

    }
}