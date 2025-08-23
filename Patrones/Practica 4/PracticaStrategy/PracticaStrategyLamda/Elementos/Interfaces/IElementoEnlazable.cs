using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaStrategyLamda.Elementos.Interfaces
{
    public interface IElementoEnlazable : IElemento
    {
        IElemento crearEnlaceDirecto();
    }
}
