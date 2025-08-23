using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosPropiedades
{
    public class Program
    {
        


        public static void Main(string[] args)
        {
            
            ClaseConPropiedades ccp = new ClaseConPropiedades();

            //Prueba con propiedad simple (sin atributo de base)
            ccp.Volumen = 5;
            Console.Out.WriteLine("Valor de la propiedad Volumen es: "+ccp.Volumen);
            Console.ReadLine(); //Siempre poner un readLine despues de un WriteLine
            

            //Prueba con propiedad y atributo base
            ccp.PesoEnGr = 1000; //Asigna peso en Gr
            Console.Out.WriteLine("El peso en gramos es: " + ccp.PesoEnGr);
            Console.ReadLine();
            Console.Out.WriteLine("El peso en kgs es: " + ccp.PesoEnKGr);
            Console.ReadLine();
            ccp.PesoEnMGr = 5000; //Asigna peso en Mgr
            Console.Out.WriteLine("El peso en gramos tras insertarlo en mg es: " + ccp.PesoEnGr);
            Console.ReadLine();

            //Prueba con propiedad y lista
            ccp.ConjuntoDeEnteros.Add(3); //añado valores al conjunto
            ccp.ConjuntoDeEnteros.Add(5);
            ccp.ConjuntoDeEnteros.Add(1);
            Console.Out.WriteLine("La suma de los valores es: " + ccp.SumaConjuntoDeEnteros);
            Console.ReadLine();

        }
    }
}
