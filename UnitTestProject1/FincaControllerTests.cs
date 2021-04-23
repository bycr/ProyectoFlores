using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Web.Mvc;

namespace Proyectoflores.Controllers.Tests
{
    [TestClass]
    public class FincaControllerTests
    {
        [TestMethod()]
        public void vistalista()
        {
            string result = Proyectoflores.Controllers.FincaController.vistalista();
            Assert.AreEqual("lst", result);

        }


        [TestMethod()]
        public void NuevaFinca()
        {
            string result = Proyectoflores.Controllers.FincaController.vistaNuevafinca();
            Assert.AreEqual("model", result);
        }
        [TestMethod()]
        public void EditarFinca()
        {
            string result = Proyectoflores.Controllers.FincaController.vistaEditarfinca();
            Assert.AreEqual("model", result);
        }
        [TestMethod()]
        public void EliminarFinca()
        {
            string result = Proyectoflores.Controllers.FincaController.vistaEliminarFinca();
            Assert.AreEqual("model", result);
        }

    }
}
