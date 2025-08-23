using System;
using System.Collections.Generic;
using System.Text;
using PracticaVisitor.Visitantes.Interfaces;
using PracticaVisitor.Elementos;
using PracticaVisitor.Elementos.Interfaces;

namespace PracticaVisitor.Visitantes
{
    public class VisualizadorCompacto : IVisualizadorAbstracto
    {
        #region Atributos
        private int numTabulaciones = 0;
        #endregion

        #region Metodos Interfaz
        public string visualizarArchivo(Archivo a)
        {
            return a.ToString();
        }

        public string visualizarDirectorio(Directorio d)
        {
            string mostrar = d.ToString();
            numTabulaciones++;
            foreach (IElemento e in d.Subelementos)
            {
                mostrar += "\n";
                for (int i = 0; i < numTabulaciones; i++)
                {
                    mostrar += "\t";
                }
                mostrar += e.aceptarVisualizador(this);
            }
            numTabulaciones--;
            return mostrar;
        }
        public string visualizarArchivoComprimido(ArchivoComprimido ac)
        {
            return ac.ToString();
        }
        public string visualizarEnlaceDirecto(EnlaceDirecto ed)
        {
            return ed.ToString();
        }
        #endregion
    }
}
