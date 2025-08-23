using System;
using System.Collections.Generic;
using System.Text;
using PracticaStrategy.Estrategias.Interfaces;

namespace PracticaStrategy.Estrategias
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
        #endregion
    }
}
