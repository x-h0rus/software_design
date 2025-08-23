using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaFactory.Estrategias.Interfaces
{
    /*
     * Interfaz que representa a una estrategia
     * @author Adrian Garcia Cubas 
     */
    public interface IEstrategia : ICloneable
    {
        #region Metodos Interfaz
        /*
         * Metodo que reemplaza un un texto por otro (En la practica una letra por dos letras)
         */
        string reemplazarLetra(string texto);
        #endregion
    }
}
