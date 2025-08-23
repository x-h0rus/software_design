using System;
using System.Collections.Generic;
using System.Text;
using PracticaStrategy.Estrategias.Interfaces;

namespace PracticaStrategy.Estrategias
{
    public class EstrategiaInternacional : IEstrategiaInternacional
    {
        #region Propiedades
        public IEstrategiaNacional Estrategia { get; set; }
        #endregion

        #region Metodos Interfaz
        /*
         * Metodo que elimina los acentos castellanos del texto
         * @Param texto texto del que se quieren eliminar los acentos
         * @return texto sin los acentos
         */
        public string reemplazarLetra(string texto)
        {
            texto = texto.Replace("á", "a");
            texto = texto.Replace("é", "e");
            texto = texto.Replace("í", "i");
            texto = texto.Replace("ó", "o");
            texto = texto.Replace("ú", "u");
            texto = texto.Replace("Á", "A");
            texto = texto.Replace("É", "E");
            texto = texto.Replace("Í", "I");
            texto = texto.Replace("Ó", "O");
            texto = texto.Replace("Ú", "U");

            return Estrategia.reemplazarLetra(texto);
        }
        #endregion
    }
}
