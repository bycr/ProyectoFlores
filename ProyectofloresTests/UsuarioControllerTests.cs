using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ProyectofloresTests
{
    [TestClass]
    public class UsuarioControllerTests
    {
        [TestMethod]
        public void vistalistaUsuario()
        {
            string result = Proyectoflores.Controllers.UsuarioController.vistalistaUsuario();
            Assert.AreEqual("lst", result);

        }
        [TestMethod]
        public void vistaNuevoUsuario()
        {
            string result = Proyectoflores.Controllers.UsuarioController.vistaNuevoUsuario();
            Assert.AreEqual("model", result);

        }
        [TestMethod]
        public void vistaEditarUsuario()
        {
            string result = Proyectoflores.Controllers.UsuarioController.vistaEditarUsuario();
            Assert.AreEqual("mod", result);

        }
        [TestMethod]
        public void vistaEliminarUsuario()
        {
            string result = Proyectoflores.Controllers.UsuarioController.vistaEliminarUsuario();
            Assert.AreEqual("view", result);

        }
    }
}
