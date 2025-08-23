using PracticaStrategyLamda.Elementos;
using PracticaStrategyLamda.Elementos.Interfaces;
using PracticaStrategyLamda.Visitantes;
using PracticaStrategyLamda.Visitantes.Interfaces;
using System;

namespace PatronStrategyLamda
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creamos los visualizadores de nuestro sistemas de archivos
            VisualizadorExtendido ve = new VisualizadorExtendido();

            //Creamos el directorio raiz
            Directorio raiz = new Directorio("Raiziña");

            //Creamos 2 directorios 
            IElementoEnlazableCompuesto directorioVacio = new Directorio("Díréctório Vacío");
            IElementoEnlazableCompuesto dcau = new Directorio("Dírectorió con archivo unico");

            //Anhadimos los directorios al raiz
            raiz.Subelementos.Add(directorioVacio);
            raiz.Subelementos.Add(dcau);

            //Creamos un archivo
            IElementoEnlazableSimple foto001 = new Archivo("foto001", 12.5);
            //Lo anhadimos al directorio dcau
            dcau.Subelementos.Add(foto001);

            //Creamos un directorio
            IElementoEnlazableCompuesto dcacs = new Directorio("Dírectoriñó con archiviñó comprimidiño símplé");
            //Anhadimos el directorio a la raiz
            raiz.Subelementos.Add(dcacs);

            //Creamos 1 archivo, 1 enlaceDirecto y 1 archivoComprimido
            IElementoEnlazableSimple foto002 = new Archivo("fotiña002", 8);
            IElemento enlace001 = foto001.crearEnlaceDirecto();
            IElementoEnlazableCompuesto ccSimple = new ArchivoComprimido("ccSimpliño");

            //anhadimos estos elementos al ultimo directorio creado
            dcacs.Subelementos.Add(foto002);
            dcacs.Subelementos.Add(enlace001);
            dcacs.Subelementos.Add(ccSimple);

            //Creamos 1 archivo, 1 enlaceDirecto y 1 directorio
            IElementoEnlazableCompuesto dveac = new Directorio("Directório vacio en árchivó cómprimidó");
            IElementoEnlazableSimple foto003 = new Archivo("fotiña003", 10);
            IElemento enlace002 = foto001.crearEnlaceDirecto();

            ccSimple.Subelementos.Add(dveac);
            ccSimple.Subelementos.Add(foto003);
            ccSimple.Subelementos.Add(enlace002);

            //Ponemos la estrategia catalana para probrar lo nacional mediante lambdas
            Console.Out.WriteLine("Estrategia Nacional Catalana");
            ve.CambiaLetra = (x) => x.Replace("ñ", "nh");
            Console.Out.WriteLine(ve.visualizarDirectorio(raiz));

            Console.Out.WriteLine(); Console.Out.WriteLine(); Console.Out.WriteLine();

            //Ponemos la estrategia gallega para probar lo nacional mediante lambdas
            Console.Out.WriteLine("Estrategia Nacional Gallega");
            ve.CambiaLetra = (x) => x.Replace("ñ", "nh");
            Console.Out.WriteLine(ve.visualizarDirectorio(raiz));

            Console.Out.WriteLine(); Console.Out.WriteLine(); Console.Out.WriteLine();

            //Creamos una strategia internacional y le asignamos una catalana nacional mediante lambdas
            Console.Out.WriteLine("Estrategia Internacional Catalana");
            ve.CambiaLetra = (x) => x.Replace("á", "a").Replace("é", "e").Replace("í", "i").Replace("ó", "o").Replace("ú", "u")
                                     .Replace("Á", "A").Replace("É", "E").Replace("Í", "I").Replace("Ó", "O").Replace("Ú", "U").Replace("ñ","ny");
            Console.Out.WriteLine(ve.visualizarDirectorio(raiz));
        }
    }
}
