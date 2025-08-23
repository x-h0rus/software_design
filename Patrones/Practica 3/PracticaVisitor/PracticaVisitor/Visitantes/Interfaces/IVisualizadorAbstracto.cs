using System;
using System.Collections.Generic;
using System.Text;
using PracticaVisitor.Elementos;

namespace PracticaVisitor.Visitantes.Interfaces
{
    /*
     * Interfaz que representa a un visitante abstracto
     * @author Adrian Garcia Cubas 
     */
    public interface IVisualizadorAbstracto
    {
        #region Metodos Interfaz
        /*
         * Metodo que permite visualizar un archivo
         */
        string visualizarArchivo(Archivo a);
        /*
         * Metodo que permite visualizar un directorio
         */
        string visualizarDirectorio(Directorio d);
        /*
         * Metodo que permite visualizar un archivo comprimido
         */
        string visualizarArchivoComprimido(ArchivoComprimido ac);
        /*
         * Metodo que permite visualizar un enlace directo
         */
        string visualizarEnlaceDirecto(EnlaceDirecto ed);
        #endregion
    }
}
