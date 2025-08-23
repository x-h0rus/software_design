using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosHerencia
{

    public abstract class ClasePadre
    {

        protected int numero;
        /*
         * Propiedad del padre, que será sobreescrita por las clases hijas
         */
        public virtual int Numero //Con virtual en la clase padre, si la clase hija sobreescriba este metodo, queremos que al invocar este
                                  // metodo desde un objeto de la clase hija, ejecute lo que dice la clase hija
        {
            get
            {
                return this.numero;
            }
            set
            {

                this.numero = value;

            }
        }


        /*
         * Método del padre, que será sobreescrito por las clases hijas. 
         */
        public virtual string retornaMensaje()
        {

            return "Este es el mensaje que retorna la clase PADRE";
        }

        public abstract double retornaDouble();


    }
}
