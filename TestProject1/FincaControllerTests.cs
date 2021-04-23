using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
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
    }
}
