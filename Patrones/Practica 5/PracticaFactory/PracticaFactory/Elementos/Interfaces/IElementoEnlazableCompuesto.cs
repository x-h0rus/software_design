using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaFactory.Elementos.Interfaces
{
    /*
     * Interfaz que representa a un elemento enlazable compuesto
     * @author Adrian Garcia Cubas 
     */
    public interface IElementoEnlazableCompuesto : IElementoEnlazable
    {
        /*
         * Propiedad Subelementos de un elemento compuesto
         * @inv (Subelementos <> null) && (!Subelementos.isEmpty())
         */
        ISet<IElemento> Subelementos { get; }
    }
}
