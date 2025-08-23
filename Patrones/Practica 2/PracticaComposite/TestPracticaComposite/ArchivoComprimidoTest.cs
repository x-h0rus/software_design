using Microsoft.VisualStudio.TestTools.UnitTesting;
using PracticaComposite.Elementos;
using PracticaComposite.Elementos.Interfaces;

namespace TestPracticaComposite
{
    [TestClass]
    public class ArchivoComprimidoTest
    {
        IElementoEnlazableCompuesto sut = new ArchivoComprimido("Archivo Comprimido");

        [TestMethod]
        public void nombreTest()
        {
            Assert.AreEqual("Archivo Comprimido", sut.Nombre);
            sut.Nombre = "Comprimido Archivo";
            Assert.AreEqual("Comprimido Archivo", sut.Nombre);
        }

        [TestMethod]
        public void tamanhoTest()
        {
            //Tamanho inicial es 1
            Assert.AreEqual(1, sut.Tamanho);

            IElementoEnlazableSimple archivo = new Archivo("Archivo 1", 5);
            sut.Subelementos.Add(archivo);

            //Al anhadir un archivo de tamanho 5, debe pasar a ser 6
            Assert.AreEqual(1 + (5 * 0.3), sut.Tamanho);

            //Al anhadir un directorio vacio el tamanho pasa a ser 7
            IElementoEnlazableCompuesto directorio = new Directorio("Directorio 1.1");
            sut.Subelementos.Add(directorio);

            Assert.AreEqual(1 + (6 * 0.3), sut.Tamanho);

            //Al anhadir un arhivo al subdirectorio el tamaho deberia de ser 11
            IElemento archivo2 = new Archivo("Archivo 2", 4);
            directorio.Subelementos.Add(archivo2);

            Assert.AreEqual(1 + (10 * 0.3), sut.Tamanho);

            //Al anahdir un archivo al subdirectorio el tamanho deberia de ser 18
            IElemento archivo3 = new Archivo("Archivo 3", 7);
            directorio.Subelementos.Add(archivo3);

            Assert.AreEqual(1 + (17 * 0.3), sut.Tamanho);

            //Al anhadir un subsubdirectorio el tamanho deberia de ser 19
            IElementoEnlazableCompuesto archivoComprimido = new ArchivoComprimido("Archivo Comprimido 1.1");
            directorio.Subelementos.Add(archivoComprimido);

            Assert.AreEqual(1 + (18 * 0.3), sut.Tamanho);

            IElemento archivo4 = new Archivo("Archivo 4", 3);
            archivoComprimido.Subelementos.Add(archivo4);

            //Al anhadir un archivo a un archivoComprimido dentro de un archivoComprimido su tamanho deberia ser 0.3*0.3
            Assert.AreEqual(1 + (18 * 0.3) + (3 * 0.3 * 0.3), sut.Tamanho);
        }

        [TestMethod]
        public void NumElementosTest()
        {
            Assert.AreEqual(1, sut.NumeroElementos);
        }
    }
}
