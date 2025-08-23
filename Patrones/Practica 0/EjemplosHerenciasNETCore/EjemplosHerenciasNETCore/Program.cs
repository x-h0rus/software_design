using System;

namespace EjemplosHerencia
{
    class Program
    {
        static void Main(string[] args)
        {

            //Pruebas con herencia de clases Padre no abstractas
            ClasePadre cp = new ClaseHija();
            cp.Numero = 5;
            Console.Out.WriteLine("El mensaje retornado es: " + cp.retornaMensaje());
            Console.Out.WriteLine("El Numero retornado es: " + cp.Numero);
            Console.ReadLine();

        }
    }
}
