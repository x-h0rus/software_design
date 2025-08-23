using System;
using System.Collections.Generic;
using System.Text;
using PracticaFactory.Estrategias.Interfaces;

namespace PracticaFactory.Estrategias
{
    public class EstrategiaGallega : IEstrategiaNacional
    {
        #region Metodos Interfaz
        /*
         * Metodo que sustituye la letra "ñ" por "nh" en un texto
         * @Param texto texto del que se quieren modificar las "ñ"
         * @return texto con las "ñ" modificadas
         */
        public string reemplazarLetra(string texto)
        {
            return texto.Replace("ñ", "nh");
        }
        /*
         * Metodo que sustituye clona la estrategia gallega
         * @return Object clon de la estrategia gallega
         */
        public Object Clone()
        {
            return new EstrategiaGallega();
        }
        #endregion
    }
}
