using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaFactory.Estrategias.Interfaces
{
    public class EstrategiaEspanhola : IEstrategiaNacional
    {
        #region Metodos Interfaz
        /*
         * Metodo que mantiene la letra en un texto
         * @Param texto texto del que se quieren modificar las "ñ"
         * @return texto con las "ñ" mantenidas
         */
        public string reemplazarLetra(string texto)
        {
            return texto;
        }
        /*
         * Metodo que sustituye clona la estrategia española
         * @return Object clon de la estrategia española
         */
        public Object Clone()
        {
            return new EstrategiaEspanhola();
        }
        #endregion
    }
}
