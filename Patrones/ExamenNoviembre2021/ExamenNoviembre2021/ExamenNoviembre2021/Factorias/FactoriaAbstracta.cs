using ExamenNoviembre2021.Visitante;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenNoviembre2021.Factorias
{
    public class FactoriaAbstracta
    {
        #region Singleton
        protected static FactoriaAbstracta laInstancia;
        protected FactoriaAbstracta() { }

        public static FactoriaAbstracta getInstance()
        {
            if(laInstancia == null)
            {
                laInstancia = new FactoriaAbstracta();
            }
            return laInstancia;
        }
        #endregion

        #region Prototype
        public VisitanteAbstracto VisitanteAbstractoPrototipo { get; set; }

        public VisitanteAbstracto crearVisitanteAbstracto()
        {
            return (VisitanteAbstracto)this.VisitanteAbstractoPrototipo.Clone();
        }
        #endregion
    }
}
