using Microsoft.VisualStudio.TestTools.UnitTesting;
using EjemplosPropiedades;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void probarValorVolumen()
        {
            ClaseConPropiedades ccp = new ClaseConPropiedades();
            ccp.Volumen = 9;
            Assert.AreEqual(ccp.Volumen, 9);
        }

        [TestMethod]
        public void probarValorVolumen1()
        {
            ClaseConPropiedades ccp = new ClaseConPropiedades();
            ccp.Volumen = 9;
            Assert.AreEqual(ccp.Volumen, 10);
        }
    }
}
