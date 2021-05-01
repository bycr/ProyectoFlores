using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ProyectofloresTests
{
    [TestClass]
    public class ErrorControllerTests
    {
        [TestMethod]
        public void errorview()
        {
            string result = Proyectoflores.Controllers.ErrorController.errorview();
            Assert.AreEqual("view", result);

        }
      
    }
}
