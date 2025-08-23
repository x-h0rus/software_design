using System;
using System.Collections.Generic;
using System.Text;

namespace EjemploEnumerado
{
    public class EjemploEnum
    {
        public enum color {blanco, negro}

        public color ColorActual { get; set; }

        public int returnIntColor()
        {
            int valor = -1;

            if(ColorActual == color.negro)
            {
                valor = 0;

            }else{

                valor = 1;
            }

            return valor;

        }

    }
}
