using PracticaFactory.Estrategias;
using PracticaFactory.Estrategias.Interfaces;
using PracticaFactory.Visitantes;
using PracticaFactory.Visitantes.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaFactory.Factorias
{
    public class FactoriaExtendidaCatalana : FactoriaAbstracta
    {
        #region Singleton
        protected FactoriaExtendidaCatalana() { }
        public static void init()
        {
            laInstancia = new FactoriaExtendidaCatalana();
        }
        #endregion

        #region Metodos Abstractos
        public override IVisualizadorAbstracto retornarVisualizador()
        {
            IVisualizadorAbstracto Visualizador = new VisualizadorCompacto();

            IEstrategiaInternacional estrInter = new EstrategiaInternacional();
            estrInter.Estrategia = new EstrategiaCatalana();
            Visualizador.Estrategia = estrInter;

            return Visualizador;
        }
        #endregion
    }
}
