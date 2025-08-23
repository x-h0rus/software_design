using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaStrategy.Elementos.Interfaces
{
    /*
     * Interfaz que representa a un elemento enlazable
     * @author Adrian Garcia Cubas 
     */
    public interface IElementoEnlazable : IElemento
    {
        /*
         * Metodo que crea un enlace directo de un IElemento
         */
        IElemento crearEnlaceDirecto();
    }
}
