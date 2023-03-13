using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab.EF.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab.EF.Entities;

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
    }
}