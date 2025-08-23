using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosPropiedades
{
    /**
     * Clase con propiedades
     */
    public class ClaseConPropiedades
    {

        #region PropiedadSinAtributo

        /**
         * Propiedad Volumen con get y set por defecto
         * No se "apoya" en ningún atributo
         */
        public int Volumen { get; set; }

        #endregion PropiedadSinAtributo





        #region PropiedadesConAtributo

        //Atributo pesoEnGre. Sus getter y setter son definidos por la propiedad PesoEnGr
        private int pesoEnGr;
        /**
         * Propiedad PesoEnGr. Se apoya en el atributo "peso"
         */
        public int PesoEnGr
        {
            get
            {
                return this.pesoEnGr;
            }

            set
            {
                this.pesoEnGr = value;
            }

        }


        /**
         * Propiedad PesoEnKGr. Sólo tiene el método get, que multiplica por 1000 el valor de pesoEnGr
         */
        public int PesoEnKGr
        {
            get
            {
                return this.pesoEnGr / 1000;
            }

        }


        /**
         * Propiedad PesoEnMGr. Sólo tiene un método set que divide el valor dado entre 1000 y lo asigna
         * al atributo pesoEnGr
         * */
        public int PesoEnMGr
        {
            set
            {
                this.pesoEnGr = value / 1000;
            }

        }


        #endregion PropiedadesConAtributo




        #region PropiedadSumaValoresSet
        //Conjunto de valores enteros
        private ISet<int> conjuntoDeEnteros = new HashSet<int>();
        //Buenas practicas de programacion, declarar la interfaz de listas al declaralo, y despues especificar que objeto de la interfaz crear
        //Buenas practicas de programacion, declarar la clase padre de un objeto al declaralo, y despues especificar que objeto de la clase hijo crear

        //Propiedad pata devolver el conjunto de enteros
        public ISet<int> ConjuntoDeEnteros {
            get
            {
                return this.conjuntoDeEnteros;
            }
        
        }

        /**
         * Propiedad que suma los valores del conjunto y lo retorna
         */
        public int SumaConjuntoDeEnteros
        {
            get
            {
                int valor = 0;
                foreach(int i in conjuntoDeEnteros) //Se pueden recorrer conjuntos con foreach
                {
                    valor = valor + i;
                }
                return valor;
            }

        }


        #endregion PropiedadSumaValoresLista



    }
}
