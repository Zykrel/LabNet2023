using Microsoft.VisualStudio.TestTools.UnitTesting;
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
    }
}