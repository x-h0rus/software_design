using PracticaFactory.Estrategias;
using PracticaFactory.Estrategias.Interfaces;
using PracticaFactory.Visitantes;
using PracticaFactory.Visitantes.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaFactory.Factorias
{
    public class FactoriaBasica : FactoriaAbstracta
    {
        #region Singleton
        protected FactoriaBasica() { }
        public static void init()
        {
            laInstancia = new FactoriaBasica();
        }
        #endregion

        #region Metodos Abstractos
        public override IVisualizadorAbstracto retornarVisualizador()
        {
            IVisualizadorAbstracto visualizador = new VisualizadorCompacto();

            IEstrategiaInternacional estrInter = new EstrategiaInternacional();
            estrInter.Estrategia = new EstrategiaGallega();
            visualizador.Estrategia = estrInter;

            return visualizador;
        }
        #endregion
    }
}
