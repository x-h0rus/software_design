using System;
using System.Collections.Generic;
using System.Text;
using PracticaStrategyLamda.Elementos.Interfaces;
using PracticaStrategyLamda.Visitantes.Interfaces;

namespace PracticaStrategyLamda.Elementos
{
    public class Archivo : IElementoEnlazableSimple
    {
        #region Constructor
        /*
         * Constructor de la clase Archivo
         * @Param nombre nombre del archivo
         * @Param tamanho tamanho del archivo
         */
        public Archivo(string nombre, double tamanho)
        {
            this.Nombre = nombre;
            this.Tamanho = tamanho;
        }
        #endregion

        #region Propiedades
        public string Nombre { get; set; }
        public double Tamanho { get; set; }
        public int NumeroElementos
        {
            get { return 1; }
        }
        #endregion

        #region Metodos Interfaz
        //Metodo que crea un enlaceDirecto del archivo actual
        public IElemento crearEnlaceDirecto()
        {
            return new EnlaceDirecto(this); ;
        }
        public string aceptarVisualizador(IVisualizadorAbstracto va)
        {
            return va.visualizarArchivo(this);
        }
        #endregion

        #region Metodos Auxiliares
        public override string ToString()
        {
            return Nombre;
        }
        #endregion
    }
}
