using System;
using System.Collections.Generic;
using System.Text;
using PracticaStrategyLamda.Elementos;

namespace PracticaStrategyLamda.Visitantes.Interfaces
{
    public interface IVisualizadorAbstracto
    {
        string visualizarArchivo(Archivo a);
        string visualizarDirectorio(Directorio d);
        string visualizarArchivoComprimido(ArchivoComprimido ac);
        string visualizarEnlaceDirecto(EnlaceDirecto ed);
    }
}
