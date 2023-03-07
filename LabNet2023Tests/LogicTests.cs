using Microsoft.VisualStudio.TestTools.UnitTesting;
using LabNet2023;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2023.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void FueraRangoTest()
        {
            Logic logica = new Logic();
            Assert.ThrowsException<IndexOutOfRangeException>(() => logica.FueraRango());
        }

        [TestMethod()]
        public void LanzarExceptionTest()
        {
            Logic logica = new Logic();           
            Assert.ThrowsException<CustomException>(() => logica.LanzarException());
        }

    }
}