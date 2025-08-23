using PracticaStrategy.Elementos;
using PracticaStrategy.Elementos.Interfaces;
using PracticaStrategy.Estrategias;
using PracticaStrategy.Estrategias.Interfaces;
using PracticaStrategy.Visitantes;
using PracticaStrategy.Visitantes.Interfaces;
using System;

namespace PracticaStrategy
{
    /*
     * Clase principal donde realizaremos pruebas sobre el programa
     * @author Adrian Garcia Cubas
     */
    public class Program
    {
        static void Main(string[] args)
        {
            //Creamos los visualizadores de nuestro sistemas de archivos
            IVisualizadorAbstracto ve = new VisualizadorExtendido();

            //Creamos el directorio raiz
            Directorio raiz = new Directorio("Raiz");

            //Creamos 2 directorios 
            IElementoEnlazableCompuesto directorioVacio = new Directorio("Díréctóriño Vacío");
            IElementoEnlazableCompuesto dcau = new Directorio("Dírectoriñó con archivo unico");

            //Anhadimos los directorios al raiz
            raiz.Subelementos.Add(directorioVacio);
            raiz.Subelementos.Add(dcau);

            //Creamos un archivo
            IElementoEnlazableSimple foto001 = new Archivo("fotiña001", 12.5);
            //Lo anhadimos al directorio dcau
            dcau.Subelementos.Add(foto001);

            //Creamos un directorio
            IElementoEnlazableCompuesto dcacs = new Directorio("Dírectoriñó con archiviñó comprimido símplé");
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
            IElementoEnlazableCompuesto dveac = new Directorio("Directório vacio en árchivó cómprimidiñó");
            IElementoEnlazableSimple foto003 = new Archivo("fotiña003", 10);
            IElemento enlace002 = foto001.crearEnlaceDirecto();

            ccSimple.Subelementos.Add(dveac);
            ccSimple.Subelementos.Add(foto003);
            ccSimple.Subelementos.Add(enlace002);

            //Ponemos la estrategia catalana para probrar lo nacional
            ve.Estrategia = new EstrategiaCatalana();
            Console.Out.WriteLine("Estrategia Nacional Catalana");
            Console.Out.WriteLine(ve.visualizarDirectorio(raiz));

            Console.Out.WriteLine(); Console.Out.WriteLine(); Console.Out.WriteLine();

            //Ponemos la estrategia gallega para probar lo nacional
            ve.Estrategia = new EstrategiaGallega();
            Console.Out.WriteLine("Estrategia Nacional Gallega");
            Console.Out.WriteLine(ve.visualizarDirectorio(raiz));

            Console.Out.WriteLine(); Console.Out.WriteLine(); Console.Out.WriteLine();

            //Creamos una strategia internacional y le asignamos una catalana nacional
            IEstrategiaInternacional interStra = new EstrategiaInternacional();
            interStra.Estrategia = new EstrategiaCatalana();
            ve.Estrategia = interStra;
            Console.Out.WriteLine("Estrategia Internacional Catalana");
            Console.Out.WriteLine(ve.visualizarDirectorio(raiz));
        }
    }
}
