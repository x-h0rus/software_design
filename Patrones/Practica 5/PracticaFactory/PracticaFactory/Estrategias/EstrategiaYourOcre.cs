using PracticaFactory.Estrategias.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaFactory.Estrategias
{
    public class EstrategiaYourOcre : IEstrategiaNacional
    {
        #region Metodos Interfaz
        /*
         * Metodo que sustituye la letra "ñ" por "ni" en un texto
         * @Param texto texto del que se quieren modificar las "ñ"
         * @return texto con las "ñ" modificadas
         */
        public string reemplazarLetra(string texto)
        {
            return texto.Replace("ñ", "ni");
        }
        /*
         * Metodo que sustituye clona la estrategia your ocre
         * @return Object clon de la estrategia your ocre
         */
        public Object Clone()
        {
            return new EstrategiaYourOcre();
        }
        #endregion
    }
}
