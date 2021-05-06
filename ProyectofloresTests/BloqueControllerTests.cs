using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ProyectofloresTests
{
    [TestClass]
    public class BloqueControllerTests
    {
        [TestMethod]
        public void listaBloque()
        {
            string result = Proyectoflores.Controllers.BloqueController.listaBloque();
            Assert.AreEqual("lst", result);

        }
        [TestMethod]
        public void nuevoBloque()
        {
            string result = Proyectoflores.Controllers.BloqueController.nuevoBloque();
            Assert.AreEqual("lst", result);

        }
        [TestMethod]
        public void editarBloque()
        {
            string result = Proyectoflores.Controllers.BloqueController.editarBloque();
            Assert.AreEqual("model", result);

        }
        [TestMethod]
        public void eliminarBloque()
        {
            string result = Proyectoflores.Controllers.BloqueController.eliminarBloque();
            Assert.AreEqual("bloque", result);

        }
    }
}
