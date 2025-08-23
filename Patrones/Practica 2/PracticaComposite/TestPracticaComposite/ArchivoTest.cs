using Microsoft.VisualStudio.TestTools.UnitTesting;
using PracticaComposite.Elementos;
using PracticaComposite.Elementos.Interfaces;

namespace TestPracticaComposite
{
    [TestClass]
    public class ArchivoTest
    {
        private IElementoEnlazableSimple sut = new Archivo("Archivo", 10.5);

        [TestMethod]
        public void NombreTest()
        {
            Assert.AreEqual("Archivo", sut.Nombre);
            sut.Nombre = "Ovihcra";
            Assert.AreEqual("Ovihcra", sut.Nombre);
        }

        [TestMethod]
        public void TamanhoTest()
        {
            Assert.AreEqual(10.5, sut.Tamanho);
            sut.Tamanho = 10;
            Assert.AreEqual(10, sut.Tamanho);
        }

        [TestMethod]
        public void NumElementosTest()
        {
            Assert.AreEqual(1, sut.NumeroElementos);
        }
        [TestMethod]
        public void crearEnlaceDirectoTest()
        {
            IElemento enlace = sut.crearEnlaceDirecto();
            Assert.AreEqual(enlace.Nombre, sut.Nombre);
            enlace.Nombre = "Jesus";
            Assert.AreEqual(enlace.Nombre, sut.Nombre);
        }
    }
}
