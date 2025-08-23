using System;

namespace EjemploClonable
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Ejemplo de uso del Clone
            ClaseUsaClone cuc = new ClaseUsaClone();
            cuc.Ic = new ClaseClonable();

            //Al usar el Clone, los objetos apuntados en cc y cc2 son diferentes
            InterfazClonable cc = cuc.creaInterfazClonable();
            InterfazClonable cc2 = cuc.creaInterfazClonable();
        }
    }
}
