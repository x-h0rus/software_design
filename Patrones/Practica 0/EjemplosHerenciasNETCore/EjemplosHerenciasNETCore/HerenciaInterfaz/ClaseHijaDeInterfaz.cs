using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosHerencia
{
    public class ClaseHijaDeInterfaz : InterfazDePrueba
    {
        private int numero;
        public int Numero
        {

            get
            {
                return numero;
            }
            set
            {
                //A efectos practicos es como si no tuviesemos set
            }


        }

        public ClaseHijaDeInterfaz(int numero) { this.numero = numero; }

        public string retornaMensaje()
        {
            return "Mensaje del método implementado";
        }

    }
}
