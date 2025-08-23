using Microsoft.VisualStudio.TestTools.UnitTesting;
using PracticaComposite.Elementos;
using PracticaComposite.Elementos.Interfaces;

namespace TestPracticaComposite
{
    [TestClass]
    public class EnlaceDirectoTest
    {
        private IElemento sut;
        [TestMethod]
        public void NombreTest()
        {
            //Creamos un enlace directo y le asignamos un archivo
            IElementoEnlazableSimple a = new Archivo("Pepe", 10);
            sut = new EnlaceDirecto(a);

            //El nombre del enlace directo debe de ser igual al nombre del archivo asignado
            Assert.AreEqual("Pepe", sut.Nombre);
            sut.Nombre = "Paco";
            //El nombre debe de haber cambiado tanto del archivo como del enlace directo
            Assert.AreEqual("Paco", a.Nombre);
            Assert.AreEqual("Paco", sut.Nombre);
        }
        [TestMethod]
        public void TamanhoTest()
        {
            IElementoEnlazableCompuesto d = new Directorio("Pepe");
            sut = new EnlaceDirecto(d);

            //El tamanho de un enlace directo debe de ser 1
            Assert.AreEqual(1, sut.Tamanho);

            IElementoEnlazableSimple a = new Archivo("Pedro", 10);
            d.Subelementos.Add(a);

            //Aunque el directorio tenga un tamanho mayor a 1, el enlace directo debe seguir teniendo tamanho 1
            Assert.AreEqual(1, sut.Tamanho);
        }
        [TestMethod]
        public void NumElementosTest()
        {
            IElementoEnlazableCompuesto d = new Directorio("Pepe");
            sut = new EnlaceDirecto(d);
            Assert.AreEqual(0, sut.NumeroElementos);
        }
    }
}
