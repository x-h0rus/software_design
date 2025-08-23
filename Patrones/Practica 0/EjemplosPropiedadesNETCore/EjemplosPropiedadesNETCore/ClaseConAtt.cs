using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosPropiedades
{
    /**
     * Clase para mostrar el funcionamiento de las propiedades.
     */
    public class ClaseConAtt
    {
        //Atributo que tiene los métodos get y set definidos
        protected int atributoConGetSet;

        /**
         * Método get del atributo
         */
        public int getAtributoConGetSet()
        {
            return this.atributoConGetSet;
        }

        /**
         * Método set del atributo
         */
        public void setAtributoConGetSet(int valor)
        {
            this.atributoConGetSet = valor;
        }

    }
}
