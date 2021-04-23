using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ProyectofloresTests
{
    [TestClass]
    public class FincaControllerTests
    {
        [TestMethod]
        public void vistalista()
        {
            string result = Proyectoflores.Controllers.FincaController.vistalista();
            Assert.AreEqual("lst", result);

        }
        [TestMethod]
        public void vistaNuevafinca()
        {
            string result = Proyectoflores.Controllers.FincaController.vistaNuevafinca();
            Assert.AreEqual("model", result);

        }
        [TestMethod]
        public void vistaEditarfinca()
        {
            string result = Proyectoflores.Controllers.FincaController.vistaEditarfinca();
            Assert.AreEqual("model", result);

        }
        [TestMethod]
        public void vistaEliminarFinca()
        {
            string result = Proyectoflores.Controllers.FincaController.vistaEliminarFinca();
            Assert.AreEqual("model", result);

        }
    }
}
