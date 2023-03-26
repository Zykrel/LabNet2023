using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;


namespace Lab.EF.Logic
{
    public class ShippersLogic : BaseLogic
    {

        public List<Shippers> ObtenerTodo()
        {
            return _northwindcontext.Shippers.ToList();
        }

        public void InsertarData(Shippers shipper) 
        {

                _northwindcontext.Shippers.Add(shipper);            
            
                _northwindcontext.SaveChanges();
        }


        public Shippers ObtenerShipperPorId(int id) 
        {
           return _northwindcontext.Shippers.Find(id);

            
        }

        public void Borrar(Shippers companiaAEliminar) 
        {

            try
            {
                Shippers shipper = _northwindcontext.Shippers.Find(companiaAEliminar.ShipperID);

                if (shipper != null)
                {
                    _northwindcontext.Shippers.Remove(shipper);
                    _northwindcontext.SaveChanges();

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           

        }


        public void Modificar(Shippers shipper)
        {

            try
            {
                Shippers shipperUpdate = _northwindcontext.Shippers.Find(shipper.ShipperID);
                if(shipperUpdate != null) 
                {
                    shipperUpdate.CompanyName = shipper.CompanyName;
                    shipperUpdate.Phone = shipper.Phone;

                    _northwindcontext.SaveChanges();
                }               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
