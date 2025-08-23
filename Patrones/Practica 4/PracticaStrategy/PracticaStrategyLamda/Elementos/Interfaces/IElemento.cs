using System;
using System.Collections.Generic;
using System.Text;
using PracticaStrategyLamda.Visitantes.Interfaces;

namespace PracticaStrategyLamda.Elementos.Interfaces
{
    public interface IElemento
    {
        string Nombre { get; set; }
        double Tamanho { get; set; }
        int NumeroElementos { get; }
        string aceptarVisualizador(IVisualizadorAbstracto va);
    }
}
