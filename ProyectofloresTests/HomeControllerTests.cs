using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ProyectofloresTests
{
    [TestClass]
    public class HomeControllerTests
    {
        [TestMethod]
        public void vistaindex()
        {
            string result = Proyectoflores.Controllers.HomeController.vistaindex();
            Assert.AreEqual("view", result);

        }
        [TestMethod]
        public void vistaabout()
        {
            string result = Proyectoflores.Controllers.HomeController.vistaabout();
            Assert.AreEqual("view", result);

        }
        [TestMethod]
        public void vistacontact()
        {
            string result = Proyectoflores.Controllers.HomeController.vistacontact();
            Assert.AreEqual("view", result);

        }
       
    }
}
