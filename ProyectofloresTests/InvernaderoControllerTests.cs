using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ProyectofloresTests
{
    [TestClass]
    public class InvernaderoControllerTests
    {
        [TestMethod]
        public void vistalistaInvernadero()
        {
            string result = Proyectoflores.Controllers.InvernaderoController.vistalistaInvernadero();
            Assert.AreEqual("lst", result);

        }
        [TestMethod]
        public void vistaNuevoInvernadero()
        {
            string result = Proyectoflores.Controllers.InvernaderoController.vistaNuevoInvernadero();
            Assert.AreEqual("model", result);

        }
        [TestMethod]
        public void vistaEditarInvernadero()
        {
            string result = Proyectoflores.Controllers.InvernaderoController.vistaEditarInvernadero();
            Assert.AreEqual("mod", result);

        }
        [TestMethod]
        public void vistaEliminarInvernadero()
        {
            string result = Proyectoflores.Controllers.InvernaderoController.vistaEliminarInvernadero();
            Assert.AreEqual("view", result);

        }
    }
}
