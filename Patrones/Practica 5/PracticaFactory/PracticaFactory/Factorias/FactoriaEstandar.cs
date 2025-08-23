using PracticaFactory.Estrategias.Interfaces;
using PracticaFactory.Visitantes;
using PracticaFactory.Visitantes.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaFactory.Factorias
{
    public class FactoriaEstandar : FactoriaAbstracta
    {
        #region Singleton
        protected FactoriaEstandar() { }
        public static void init()
        {
            laInstancia = new FactoriaEstandar();
        }
        #endregion

        #region Metodos Abstractos
        public override IVisualizadorAbstracto retornarVisualizador()
        {
            IVisualizadorAbstracto visualizador = new VisualizadorExtendido();
            visualizador.Estrategia = new EstrategiaEspanhola();

            return visualizador;
        }
        #endregion
    }
}
