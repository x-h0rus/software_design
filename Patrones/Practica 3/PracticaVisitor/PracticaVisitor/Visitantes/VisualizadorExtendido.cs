using System;
using System.Collections.Generic;
using System.Text;
using PracticaVisitor.Elementos;
using PracticaVisitor.Visitantes.Interfaces;
using PracticaVisitor.Elementos.Interfaces;

namespace PracticaVisitor.Visitantes
{
    public class VisualizadorExtendido : IVisualizadorAbstracto
    {
        #region Atributos
        private int numTabulaciones = 0;
        #endregion

        #region Metodos Interfaz
        public string visualizarArchivo(Archivo a)
        {
            return "f  " + a.ToString();
        }

        public string visualizarDirectorio(Directorio d)
        {
            string mostrar = "d " + d.ToString();
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
            string mostrar = "c " + ac.ToString();
            numTabulaciones++;
            foreach (IElemento e in ac.Subelementos)
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
        public string visualizarEnlaceDirecto(EnlaceDirecto ed)
        {
            return "e  " + ed.ToString();
        }
        #endregion
    }
}
