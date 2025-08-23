using System;
using PracticaComposite.Elementos;
using PracticaComposite.Elementos.Interfaces;

namespace PracticaComposite
{
    /*
     * Clase principal donde realizaremos pruebas del programa
     * @author Adrian Garcia Cubas
     */
    class Program
    {
        static void Main(string[] args)
        {
            IElementoEnlazableCompuesto raiz = new Directorio("Raiz");

            IElementoEnlazableCompuesto directorioVacio = new Directorio("Directorio Vacio");
            IElementoEnlazableCompuesto dcau = new Directorio("Directorio con archivo unico");

            raiz.Subelementos.Add(directorioVacio);
            raiz.Subelementos.Add(dcau);

            IElementoEnlazableSimple foto001 = new Archivo("foto001", 12.5);

            dcau.Subelementos.Add(foto001);

            //Tamanho = 15.5KB, numElementos = 2
            imprimirPropiedadesElementoSparrow(raiz);

            IElementoEnlazableCompuesto dcacs = new Directorio("Directorio con archivo comprimido simple");
            raiz.Subelementos.Add(dcacs);

            IElementoEnlazableSimple foto002 = new Archivo("foto002", 8);
            IElemento enlace001 = foto001.crearEnlaceDirecto();
            IElementoEnlazableCompuesto ccSimple = new ArchivoComprimido("ccSimple");

            //Comprobamos que no se puede crear enlacesDirectos de enlacesDirectos.
            //IElemento enlace002 = new EnlaceDirecto(enlace001); SI SE DESCOMENTA DA ERROR YA QUE NO SE PUEDE CREAR ENLACES DE ENLACES

            dcacs.Subelementos.Add(foto002);
            dcacs.Subelementos.Add(enlace001);
            dcacs.Subelementos.Add(ccSimple);

            imprimirPropiedadesElementoSparrow(dcacs);
        }

        static void imprimirPropiedadesElementoSparrow(IElemento e)
        {
            Console.Out.WriteLine("============= Info ===============");
            Console.Out.WriteLine();
            Console.Out.WriteLine("Tipo elemento : " + e.GetType().ToString());
            Console.Out.WriteLine("Nombre        : " + e.Nombre);
            Console.Out.WriteLine("Tamaño        : {0}kB", e.Tamanho);
            Console.Out.WriteLine("Num. Archivos : " + e.NumeroElementos);
            Console.Out.WriteLine();
            Console.Out.WriteLine("==================================");
        }
    }
}
