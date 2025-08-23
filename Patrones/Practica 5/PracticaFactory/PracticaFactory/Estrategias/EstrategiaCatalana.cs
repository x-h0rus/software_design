using System;
using System.Collections.Generic;
using System.Text;
using PracticaFactory.Estrategias.Interfaces;

namespace PracticaFactory.Estrategias
{
    public class EstrategiaCatalana : IEstrategiaNacional
    {
        #region Metodos Interfaz
        /*
         * Metodo que sustituye la letra "ñ" por "ny" en un texto
         * @Param texto texto del que se quieren modificar las "ñ"
         * @return texto con las "ñ" modificadas
         */
        public string reemplazarLetra(string texto)
        {
            return texto.Replace("ñ", "ny");
        }
        /*
         * Metodo que sustituye clona la estrategia catalana
         * @return Object clon de la estrategia catalana
         */
        public Object Clone()
        {
            return new EstrategiaCatalana();
        }
        #endregion
    }
}
