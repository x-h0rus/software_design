using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaStrategy.Estrategias.Interfaces
{
    /*
     * Interfaz que representa a una estrategia internacional
     * @author Adrian Garcia Cubas 
     */
    public interface IEstrategiaInternacional : IEstrategia
    {
        #region Propiedades
        /*
         * Estrategia nacional a utilizar por la estrategia internacional
         */
        IEstrategiaNacional Estrategia { get; set; }
        #endregion
    }
}
