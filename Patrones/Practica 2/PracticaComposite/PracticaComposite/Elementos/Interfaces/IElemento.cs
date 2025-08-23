using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaComposite.Elementos.Interfaces
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
    }
}
