using Microsoft.VisualStudio.TestTools.UnitTesting;
using PracticaComposite.Elementos;
using PracticaComposite.Elementos.Interfaces;

namespace TestPracticaComposite
{
    [TestClass]
    public class DirectorioTest
    {
        private IElementoEnlazableCompuesto sut = new Directorio("Directorio 1");

        [TestMethod]
        public void nombreTest()
        {
            Assert.AreEqual("Directorio 1", sut.Nombre);
            sut.Nombre = "pepe";
            Assert.AreEqual("pepe", sut.Nombre);
        }

        [TestMethod]
        public void tamanhoTest()
        {
            Assert.AreEqual(1, sut.Tamanho);
            Archivo a = new Archivo("a", 3);
            sut.Subelementos.Add(a);
            Assert.AreEqual(4, sut.Tamanho);
            Archivo a2 = new Archivo("a2", 5);
            sut.Subelementos.Add(a2);
            Assert.AreEqual(9, sut.Tamanho);
        }

        [TestMethod]
        public void numElementosTest()
        {
            Assert.AreEqual(0, sut.NumeroElementos);
            Archivo a = new Archivo("a", 3);
            sut.Subelementos.Add(a);
            Archivo a2 = new Archivo("a2", 5);
            sut.Subelementos.Add(a2);
            Assert.AreEqual(2, sut.NumeroElementos);
        }
    }
}
