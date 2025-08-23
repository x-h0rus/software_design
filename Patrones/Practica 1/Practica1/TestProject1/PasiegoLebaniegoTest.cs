using Microsoft.VisualStudio.TestTools.UnitTesting;

using Practica1.Figura_2;

namespace TestProject1
{
    //Clase de pruebas del objeto PasiegoLebaniego
    [TestClass]
    public class PasiegoLebaniegoTest
    {
        //Vamos a realizar las pruebas unitarias de la figura 2 solo
        PasiegoLebaniego sut = new PasiegoLebaniego();

        [TestMethod]
        public void hacerCocidoTest()
        {
            //Por defecto el tipo contexto es PAS
            Assert.AreEqual("Estoy haciendo cocido montanes", sut.hacerCocido());

            sut.Contexto = TipoContexto.LIEBANA;

            Assert.AreEqual("Estoy haciendo cocido lebaniego", sut.hacerCocido());
        }

        [TestMethod]
        public void hacerOrujoTest()
        {
            Assert.AreEqual("Estoy haciendo orujo", sut.hacerOrujo());
        }

        [TestMethod]
        public void hacerQuesadaTest()
        {
            Assert.AreEqual("Estoy haciendo quesada", sut.hacerQuesada());
        }

        [TestMethod]
        public void hacerSobaosTest()
        {
            Assert.AreEqual("Estoy haciendo sobaos", sut.hacerSobaos());
        }
    }
}
