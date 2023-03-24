using Lab.EF.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;


namespace Lab.EF.Logic.Tests
{
    [TestClass()]
    public class ShippersLogicTests
    {
        [TestMethod()]
        public void ObtenerTodoTest()
        {
            ShippersLogic shipperLogic = new ShippersLogic();

            Assert.IsTrue(shipperLogic.ObtenerTodo().Any());
        }

        [TestMethod()]
        public void UpdateTest()
        {
            ShippersLogic shipperLogic = new ShippersLogic();
            Shippers shipper = new Shippers { CompanyName = "Compania de prueba a modificar", Phone = "42851781" };
            shipperLogic.InsertarData(shipper);
            string valorEsperado = "Nombre Modificado";
            Shippers shipperAModificar = shipperLogic.ObtenerTodo().Last();
            shipperAModificar.CompanyName = valorEsperado;
            shipperLogic.Modificar(shipperAModificar);
            Assert.AreEqual(valorEsperado, shipperLogic.ObtenerShipperPorId(shipperAModificar.ShipperID).CompanyName);
        }

        [TestMethod()]
        public void DeleteTest()
        {
            ShippersLogic shipperLogic = new ShippersLogic();
            Shippers shipper = new Shippers { CompanyName = "Compania de prueba a eliminar", Phone = "42851781" };
            shipperLogic.InsertarData(shipper);
            List<Shippers> shippersList = shipperLogic.ObtenerTodo();
            Shippers shipperAEliminar = shippersList.Find(s => s.CompanyName == shipper.CompanyName);
            shipperLogic.Borrar(shipperAEliminar);
            Assert.AreNotEqual(shipperAEliminar, shipperLogic.ObtenerTodo().Last());

        }

        [TestMethod()]
        public void CreateTest()
        {
            ShippersLogic shipperLogic = new ShippersLogic();          
            Shippers shipper = new Shippers {CompanyName = "Compania de prueba", Phone = "42851781" };
            shipperLogic.InsertarData(shipper);
            List<Shippers> shippersList = shipperLogic.ObtenerTodo();
            Assert.AreEqual(shipper, shippersList.Last());

        }
    }
}