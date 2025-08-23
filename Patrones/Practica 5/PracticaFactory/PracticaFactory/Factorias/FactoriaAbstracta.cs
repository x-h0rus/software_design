using PracticaFactory.Estrategias;
using PracticaFactory.Visitantes.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaFactory.Factorias
{
    /*
     * Clase abstracta que representa a una factoria
     * @author Adrian Garcia Cubas
     */
    public abstract class FactoriaAbstracta
    {
        #region Singleton
        protected static FactoriaAbstracta laInstancia;
        public static FactoriaAbstracta getInstance()
        {
            return laInstancia;
        }
        #endregion

        #region Metodos Abstractos
        public abstract IVisualizadorAbstracto retornarVisualizador();
        #endregion
    }
}
