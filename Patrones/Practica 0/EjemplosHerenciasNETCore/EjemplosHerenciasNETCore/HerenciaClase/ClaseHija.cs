using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosHerencia
{
    public class ClaseHija : ClasePadre //Esto indica que ClaseHija hereda de ClasePadre
    {

        /*
         * Propiedad de la clase hija, que sobreescribe el comportamiento de la clase padre
         */
        public override int Numero
        {
            get
            {
                return this.numero*100;
            }
            set
            {

                this.numero = value;

            }
        }


        /*
         * Método de la clase hija que sobreescribe el comportamiento de la clase padre
         */
        public override string retornaMensaje()
        {
            return "Este es el mensaje que retorna la clase HIJA";
        }

        /*
        * Método de la clase hija que sobreescribe el método abstracto de la clase padre
        */
        public override double retornaDouble()
        {
            return 2.0;
        }

    }
}
