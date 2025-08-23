using PracticaFactory.Elementos;
using PracticaFactory.Elementos.Interfaces;
using PracticaFactory.Estrategias;
using PracticaFactory.Estrategias.Interfaces;
using PracticaFactory.Factorias;
using PracticaFactory.Visitantes;
using PracticaFactory.Visitantes.Interfaces;
using System;

namespace PracticaFactory
{
    /*
     * Clase donde se ejecutaran pruebas sobre el programa
     * @author Adrian Garcia Cubas
     */
    public class Program
    {
        static void Main(string[] args)
        {
            //Creamos el directorio raiz
            Directorio raiz = new Directorio("Raiziña");

            //Creamos 2 directorios 
            IElementoEnlazableCompuesto directorioVacio = new Directorio("Díréctório Vacíiño");
            IElementoEnlazableCompuesto dcau = new Directorio("Dírectoriñó con archivo unico");

            //Anhadimos los directorios al raiz
            raiz.Subelementos.Add(directorioVacio);
            raiz.Subelementos.Add(dcau);

            //Creamos un archivo
            IElementoEnlazableSimple foto001 = new Archivo("foto001", 12.5);
            //Lo anhadimos al directorio dcau
            dcau.Subelementos.Add(foto001);

            //Creamos un directorio
            IElementoEnlazableCompuesto dcacs = new Directorio("Dírectorió con archivó comprimido símplé");
            //Anhadimos el directorio a la raiz
            raiz.Subelementos.Add(dcacs);

            //Creamos 1 archivo, 1 enlaceDirecto y 1 archivoComprimido
            IElementoEnlazableSimple foto002 = new Archivo("foto002", 8);
            IElemento enlace001 = foto001.crearEnlaceDirecto();
            IElementoEnlazableCompuesto ccSimple = new ArchivoComprimido("ccSimpliño");

            //anhadimos estos elementos al ultimo directorio creado
            dcacs.Subelementos.Add(foto002);
            dcacs.Subelementos.Add(enlace001);
            dcacs.Subelementos.Add(ccSimple);

            //Creamos 1 archivo, 1 enlaceDirecto y 1 directorio
            IElementoEnlazableCompuesto dveac = new Directorio("Directóriño vacio en árchivó cómprimidó");
            IElementoEnlazableSimple foto003 = new Archivo("fotiña003", 10);
            IElemento enlace002 = foto001.crearEnlaceDirecto();

            ccSimple.Subelementos.Add(dveac);
            ccSimple.Subelementos.Add(foto003);
            ccSimple.Subelementos.Add(enlace002);

            //Ponemos la factoria extendida gallega
            Console.Out.WriteLine("Estrategia Nacional Gallega");
            FactoriaExtendidaGallega.init();
            Console.Out.WriteLine(FactoriaAbstracta.getInstance().retornarVisualizador().visualizarDirectorio(raiz));

            Console.Out.WriteLine(); Console.Out.WriteLine(); Console.Out.WriteLine();

            //Ponemos la factoria extendida catalana
            Console.Out.WriteLine("Estrategia Nacional Catalana");
            FactoriaExtendidaCatalana.init();
            Console.Out.WriteLine(FactoriaAbstracta.getInstance().retornarVisualizador().visualizarDirectorio(raiz));

            Console.Out.WriteLine(); Console.Out.WriteLine(); Console.Out.WriteLine();

            //Ponemos la factoria abierta con your ocre
            //FactoriaAbierta.init();

            //Console.Out.WriteLine("Estrategia Your Ocre");
            //Console.Out.WriteLine(FactoriaAbstracta.getInstance().retornarVisualizador().visualizarDirectorio(raiz));
        }
    }
}
