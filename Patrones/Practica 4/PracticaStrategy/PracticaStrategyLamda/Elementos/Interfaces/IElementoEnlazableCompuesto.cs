using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaStrategyLamda.Elementos.Interfaces
{
    public interface IElementoEnlazableCompuesto : IElementoEnlazable
    {
        ISet<IElemento> Subelementos { get; }
    }
}
