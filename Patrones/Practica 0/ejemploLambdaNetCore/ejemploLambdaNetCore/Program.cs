using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemploLambda
{
    public class Program
    {
        //EJEMPLO 1: recibe un int y devuelve un int
        private Func<int, int> alternativaVisualizacionEj1 = (x) => x;

        public Func<int, int> AlternativaVisualizacionEj1
        {
            get => alternativaVisualizacionEj1;
            set => alternativaVisualizacionEj1 = value;
        }




        //EJEMPLO 2: recibe dos string y los devuelve concatenados
        private Func<string, string, string> alternativaVisualizacionEj2 = (x,y) => x+" "+y;

        public Func<string, string, string> AlternativaVisualizacionEj2
        {
            get => alternativaVisualizacionEj2;
            set => alternativaVisualizacionEj2 = value;
        }



        //EJEMPLO 3: recibe dos int y devuelve un booleano: true si x es mayor que y
        private Func<int, int, bool> alternativaVisualizacionEj3 = (x, y) => x>y;

        public Func<int, int, bool> AlternativaVisualizacionEj3
        {
            get => alternativaVisualizacionEj3;
            set => alternativaVisualizacionEj3 = value;
        }



        //EJEMPLO 4: método que recibe una función lambda directamente como parámetro
        public int operacion(Func<int, int, int> op, int valor1, int valor2)
        {

            return op(valor1, valor2);
        }


        /**
         * Método main que muestra con ejecuciones ejemplos de uso
         * de funciones lambda
         */
        public static void Main(string[] args)
        {

            Program pr = new Program();
            
            
            //EJEMPLO 1:
            //Devuelve el entero que se pasa como parámetro
            Console.Out.Write(pr.AlternativaVisualizacionEj1(4));
            Console.ReadLine();

            //Cambia el comportamiento. Devuelve el entero dividido entre dos
            pr.AlternativaVisualizacionEj1 = (x) => x / 2;
            Console.Out.Write(pr.AlternativaVisualizacionEj1(4));
            Console.ReadLine();

            //Cambia el comportamiento. Devuelve el entero multiplicado por dos
            pr.AlternativaVisualizacionEj1 = (x) => x * 2;
            Console.Out.Write(pr.AlternativaVisualizacionEj1(4));
            Console.ReadLine();





            //EJEMPLO 2:
            //Devuelve los strings concatenados en la misma línea. Primero x y luego y
            Console.Out.Write(pr.AlternativaVisualizacionEj2("Esto es","un string concatenado"));
            Console.ReadLine();

            //Cambia el comportamiento. Devuelve los strings concatenados con un salto de línea.
            // Primero y y luego x
            pr.AlternativaVisualizacionEj2 = (x, y) => y + " \n " + x;
            Console.Out.Write(pr.AlternativaVisualizacionEj2("Esto es", "un string concatenado"));
            Console.ReadLine();

            //Cambia el comportamiento. Devuelve los strings concatenados en la misma línea y 
            // reemplaza los espacios con - en los dos string.
            pr.AlternativaVisualizacionEj2 = (x, y) => x.Replace(" ","-") + " " + y.Replace(" ", "-");
            Console.Out.Write(pr.AlternativaVisualizacionEj2("Esto es", "un string concatenado"));
            Console.ReadLine();





            //EJEMPLO 3:
            //Devuelve true si el primer argumento es mayor que el segundo
            Console.Out.Write(pr.AlternativaVisualizacionEj3(3, 2));
            Console.ReadLine();

            //Cambia el comportamiento. Devuelve true si y es mayor que x
            pr.AlternativaVisualizacionEj3 = (x, y) => y>x;
            Console.Out.Write(pr.AlternativaVisualizacionEj3(3, 2));
            Console.ReadLine();



            //EJEMPLO 4:
            //Usa el método que recibe una función lambda como parámetro
            // para devolver la suma de los dos enteros
            Console.Out.Write(pr.operacion((x, y) => x + y, 3, 2));
            Console.ReadLine();

            //Usa el método que recibe una función lambda como parámetro
            // para devolver la multiplicación de los dos enteros
            Console.Out.Write(pr.operacion((x, y) => x * y, 3, 2));
            Console.ReadLine();

            //Usa el método que recibe una función lambda como parámetro
            // para devolver la resta de los dos enteros
            Console.Out.Write(pr.operacion((x, y) => x - y, 3, 2));
            Console.ReadLine();
        }
    }
}
