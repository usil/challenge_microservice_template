using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestApi.Controllers;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void GetLog()
        {
            //Prueba
            var controller = new MetaController();
            var respuesta = controller.Get();

            //Assert.AreEqual("200", respuesta);
            Assert.IsNotNull(respuesta);
        }


        [TestMethod]
        public void EliminarLog()
        {
            //Prueba
            var controller = new MetaController();
            var respuesta = controller.Truncate();

            Assert.AreEqual("200", respuesta.code);
        }

        //[TestMethod]
        //public void InsertarLog()
        //{

        //    //Prueba
        //    var controller = new MetaController();
        //    var respuesta = controller.Insert();

        //    Assert.AreEqual("200", respuesta.code);
        //}


    }
}
