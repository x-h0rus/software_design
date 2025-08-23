using System;
using System.Collections.Generic;
using System.Text;
using PracticaComposite.Elementos.Interfaces;

namespace PracticaComposite.Elementos
{
    public class ArchivoComprimido : IElementoEnlazableCompuesto
    {
        #region Constructor
        /*
         * Constructor de la clase ArchivoComprimido
         * @Param nombre nombre del archivoComprimido
         * @pre (Nombre <> null) && (Nombre <> "")
         */
        public ArchivoComprimido(string nombre)
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
                double tamanho = 0;
                foreach (IElemento e in Subelementos)
                {
                    tamanho += e.Tamanho;
                }
                return 1 + tamanho * 0.3;
            }
            set { /*No hace nada*/ }
        }
        public int NumeroElementos
        {
            get { return 1; }
        }
        public ISet<IElemento> Subelementos { get; } = new HashSet<IElemento>();
        #endregion

        #region Metodos Interfaz
        public IElemento crearEnlaceDirecto()
        {
            return new EnlaceDirecto(this); ;
        }
        #endregion
    }
}
