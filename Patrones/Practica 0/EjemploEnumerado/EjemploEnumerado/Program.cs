using System;

namespace EjemploEnumerado
{
    public class Program
    {
        public static void Main(string[] args)
        {
            EjemploEnum eje = new EjemploEnum();
            eje.ColorActual = EjemploEnum.color.blanco;

            Console.Out.WriteLine("El valor del enum es: "+eje.ColorActual);
            Console.Out.WriteLine("El valor numérico es: " +eje.returnIntColor());
            Console.ReadLine();

        }
    }
}
