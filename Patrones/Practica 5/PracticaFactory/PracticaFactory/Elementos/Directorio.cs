using System;
using System.Collections.Generic;
using System.Text;
using PracticaFactory.Elementos.Interfaces;
using PracticaFactory.Visitantes.Interfaces;

namespace PracticaFactory.Elementos
{
    public class Directorio : IElementoEnlazableCompuesto
    {
        #region Constructor
        /*
         * Constructor de la clase Directorio
         * @Param nombre nombre del directorio
         * @pre (Nombre <> null) && (Nombre <> "")
         */
        public Directorio(string nombre)
        {
            this.Nombre = nombre;
        }
        #endregion

        #region Propiedades
        public string Nombre { get; set; }
        public double Tamanho
        {
            get
            {
                double tamanho = 1;
                foreach (IElemento e in Subelementos)
                {
                    tamanho += e.Tamanho;
                }
                return tamanho;
            }
            set { /*No hace nada*/}
        }
        public int NumeroElementos
        {
            get { return Subelementos.Count; }
        }
        public ISet<IElemento> Subelementos { get; } = new HashSet<IElemento>();
        #endregion

        #region Metodos Interfaz
        //Metodo que crea un enlaceDirecto del directorio actual
        public IElemento crearEnlaceDirecto()
        {
            return new EnlaceDirecto(this); ;
        }
        public string aceptarVisualizador(IVisualizadorAbstracto va)
        {
            return va .visualizarDirectorio(this);
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
