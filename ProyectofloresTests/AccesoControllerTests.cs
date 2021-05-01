using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ProyectofloresTests
{
    [TestClass]
    public class AccesoControllerTests
    {
        [TestMethod]
        public void login()
        {
            string result = Proyectoflores.Controllers.AccesoController.login();
            Assert.AreEqual("index", result);

        }
       
    }
}
