using System;
using System.Collections.Generic;
using System.Text;
using PracticaStrategy.Visitantes.Interfaces;

namespace PracticaStrategy.Elementos.Interfaces
{
    /*
     * Interfaz que representa a un elemento
     * @author Adrian Garcia Cubas
     */
    public interface IElemento
    {
        #region Propiedades
        /*
        * Propiedad Nombre de un elemento
        * @inv (Nombre <> null) && (Nombre <> "")
        */
        string Nombre { get; set; }
        /*
         * Propiedad Tamanho de un elemento
         * @inv (Tamanho >= 0)
         */
        double Tamanho { get; set; }
        /*
         * Propiedad NumeroElementos de un elemento
         * @inv (NumeroElementos>= 0)
         */
        int NumeroElementos { get; }
        #endregion

        #region Metodos Interfaz
        /*
         * Metodo que acepta un visualizadorAbstracto y se retorna a si mismo
         */
        string aceptarVisualizador(IVisualizadorAbstracto va);
        #endregion
    }
}
