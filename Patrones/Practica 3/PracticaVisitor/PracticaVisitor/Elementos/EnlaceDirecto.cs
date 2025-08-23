using System;
using System.Collections.Generic;
using System.Text;
using PracticaVisitor.Elementos.Interfaces;
using PracticaVisitor.Visitantes.Interfaces;

namespace PracticaVisitor.Elementos
{
    public class EnlaceDirecto : IElemento
    {
        #region Atributos
        private IElementoEnlazable elementoDestino;
        #endregion

        #region Constructor
        /*
         * Constructor de la clase Archivo
         * @Param elementoDestino elemento sobre el cual se quiere crear un acceso directo
         * @pre (elementoDestino <> null)
         */
        public EnlaceDirecto(IElementoEnlazable elementoDestino)
        {
            this.elementoDestino = elementoDestino;
        }
        #endregion

        #region Propiedades
        public string Nombre
        {
            get { return elementoDestino.Nombre; }
            set { elementoDestino.Nombre = value; }
        }
        public double Tamanho
        {
            get { return 1; }
            set { /*No hace nada*/}
        }
        public int NumeroElementos
        {
            get { return 0; }
        }
        #endregion

        #region Metodos Interfaz
        public string aceptarVisualizador(IVisualizadorAbstracto va)
        {
            return va .visualizarEnlaceDirecto(this);
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
