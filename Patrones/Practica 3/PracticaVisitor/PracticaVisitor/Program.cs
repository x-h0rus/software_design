using System;
using PracticaVisitor.Elementos;
using PracticaVisitor.Elementos.Interfaces;
using PracticaVisitor.Visitantes;
using PracticaVisitor.Visitantes.Interfaces;

namespace PracticaVisitor
{
    /*
     * Clase principal donde realizaremos pruebas del programa
     * @author Adrian Garcia Cubas
     */
    class Program
    {
        static void Main(string[] args)
        {
            //Creamos los visualizadores de nuestro sistemas de archivos
            IVisualizadorAbstracto vc = new VisualizadorCompacto();
            IVisualizadorAbstracto ve = new VisualizadorExtendido();

            //Creamos el directorio raiz
            Directorio raiz = new Directorio("Raiz");

            //Creamos 2 directorios 
            IElementoEnlazableCompuesto directorioVacio = new Directorio("Directorio Vacio");
            IElementoEnlazableCompuesto dcau = new Directorio("Directorio con archivo unico");

            //Anhadimos los directorios al raiz
            raiz.Subelementos.Add(directorioVacio);
            raiz.Subelementos.Add(dcau);

            //Creamos un archivo
            IElementoEnlazableSimple foto001 = new Archivo("foto001", 12.5);
            //Lo anhadimos al directorio dcau
            dcau.Subelementos.Add(foto001);

            //Tamanho = 15.5KB, numElementos = 2
            //imprimirPropiedadesElementoSparrow(raiz);

            //Creamos un directorio
            IElementoEnlazableCompuesto dcacs = new Directorio("Directorio con archivo comprimido simple");
            //Anhadimos el directorio a la raiz
            raiz.Subelementos.Add(dcacs);

            //Creamos 1 archivo, 1 enlaceDirecto y 1 archivoComprimido
            IElementoEnlazableSimple foto002 = new Archivo("foto002", 8);
            IElemento enlace001 = foto001.crearEnlaceDirecto();
            IElementoEnlazableCompuesto ccSimple = new ArchivoComprimido("ccSimple");

            //anhadimos estos elementos al ultimo directorio creado
            dcacs.Subelementos.Add(foto002);
            dcacs.Subelementos.Add(enlace001);
            dcacs.Subelementos.Add(ccSimple);

            //Creamos 1 archivo, 1 enlaceDirecto y 1 directorio
            IElementoEnlazableCompuesto dveac = new Directorio("Directorio vacio en archivo comprimido");
            IElementoEnlazableSimple foto003 = new Archivo("foto003", 10);
            IElemento enlace002 = foto001.crearEnlaceDirecto();

            ccSimple.Subelementos.Add(dveac);
            ccSimple.Subelementos.Add(foto003);
            ccSimple.Subelementos.Add(enlace002);

            //Utiliazmos la impresora compacta
            Console.Out.WriteLine(vc.visualizarDirectorio(raiz));

            Console.Out.WriteLine(); Console.Out.WriteLine(); Console.Out.WriteLine();

            //Utilizamos la impresora extendida
            Console.Out.WriteLine(ve.visualizarDirectorio(raiz));
        }

        static void imprimirPropiedadesElementoSparrow(IElemento e)
        {
            Console.Out.WriteLine("============= Info ===============");
            Console.Out.WriteLine();
            Console.Out.WriteLine("Tipo elemento : " + e.GetType());
            Console.Out.WriteLine("Nombre        : " + e.Nombre);
            Console.Out.WriteLine("Tamaño        : {0}kB", e.Tamanho);
            Console.Out.WriteLine("Num. Archivos : " + e.NumeroElementos);
            Console.Out.WriteLine();
            Console.Out.WriteLine("==================================");
        }
    }
}
