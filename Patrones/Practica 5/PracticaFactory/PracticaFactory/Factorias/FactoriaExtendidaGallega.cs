using PracticaFactory.Estrategias;
using PracticaFactory.Estrategias.Interfaces;
using PracticaFactory.Visitantes;
using PracticaFactory.Visitantes.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaFactory.Factorias
{
    public class FactoriaExtendidaGallega : FactoriaAbstracta
    {
        #region Singleton
        protected FactoriaExtendidaGallega() { }
        public static void init()
        {
            laInstancia = new FactoriaExtendidaGallega();
        }
        #endregion

        #region Metodos Abstractos
        public override IVisualizadorAbstracto retornarVisualizador()
        {
            IVisualizadorAbstracto visualizador = new VisualizadorExtendido();

            IEstrategiaInternacional estrInter = new EstrategiaInternacional();
            estrInter.Estrategia = new EstrategiaGallega();
            visualizador.Estrategia = estrInter;

            return visualizador;
        }
        #endregion
    }
}
