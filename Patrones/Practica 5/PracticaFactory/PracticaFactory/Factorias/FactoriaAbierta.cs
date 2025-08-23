using PracticaFactory.Estrategias.Interfaces;
using PracticaFactory.Visitantes;
using PracticaFactory.Visitantes.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaFactory.Factorias
{
    public class FactoriaAbierta : FactoriaAbstracta
    {
        #region Singleton
        protected FactoriaAbierta() { }
        public static void init()
        {
            laInstancia = new FactoriaAbierta();
        }
        #endregion

        #region Propiedades
        /*
         * Propiedad de la estrategia a usar por la factoria abierta
         */
        public IEstrategia Estrategia { get; set; }
        #endregion

        #region Metodos Abstractos y Prototype
        public override IVisualizadorAbstracto retornarVisualizador()
        {
            IVisualizadorAbstracto visualizador = new VisualizadorExtendido();
            //Aplicamos el prototype
            visualizador.Estrategia = (IEstrategia)this.Estrategia.Clone();

            return visualizador;
        }

        /* ESTO SERIA CORRECTO SI PIDIESE CREAR UNA FACTORIA PARA CREAR PROTOTIPOS DE ALGO CONCRETO (AQUI ESTRATEGIAS)
         #region Prototype
         public EstrategiaCatalana EstrategiaCatalanaPrototipo { set; get; }
         public EstrategiaGallega EstrategiaGallegaPrototipo { set; get; }
         public EstrategiaInternacional EstrategiaInternacionalPrototipo { set; get; }
         public EstrategiaYourOcre EstrategiaYourOcrePrototipo { get; set; }

         public EstrategiaCatalana crearEstrategiaCatalana()
         {
             return (EstrategiaCatalana)this.EstrategiaCatalanaPrototipo.Clone();
         }
         public EstrategiaGallega crearEstrategiaGallega()
         {
             return (EstrategiaGallega)this.EstrategiaGallegaPrototipo.Clone();
         }
         public EstrategiaInternacional crearEstrategiaInternacional()
         {
             return (EstrategiaInternacional)this.EstrategiaInternacionalPrototipo.Clone();
         }
         public EstrategiaYourOcre crearEstrategiaYourOcre()
         {
             return (EstrategiaYourOcre)this.EstrategiaYourOcrePrototipo.Clone();
         }
         #endregion
     */
        #endregion
    }
}
