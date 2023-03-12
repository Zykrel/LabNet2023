using Lab.EF.Data;
using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic
{
    public class ShippersLogic : BaseLogic
    {

        public List<Shippers> ObtenerTodo()
        {
            return _northwindcontext.Shippers.ToList();
        }

        public void insertarData(Shippers shipper) 
        {
            _northwindcontext.Shippers.Add(shipper);
            _northwindcontext.SaveChanges();
        }

        public void Borrar(int id) 
        {
            Shippers companiaAEliminar = _northwindcontext.Shippers.First(s => s.ShipperID == id);

            _northwindcontext.Shippers.Remove(companiaAEliminar);

            _northwindcontext.SaveChanges();
        }


        public void updateData(Shippers shipper)
        {
            Shippers shipperUpdate = _northwindcontext.Shippers.Find(shipper.ShipperID);

            shipperUpdate.CompanyName = shipper.CompanyName;
            shipperUpdate.Phone = shipper.Phone;

            _northwindcontext.SaveChanges();
        }
    }
}
