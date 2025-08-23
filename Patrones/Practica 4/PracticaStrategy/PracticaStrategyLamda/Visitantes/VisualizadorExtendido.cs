using System;
using System.Collections.Generic;
using System.Text;
using PracticaStrategyLamda.Elementos;
using PracticaStrategyLamda.Visitantes.Interfaces;
using PracticaStrategyLamda.Elementos.Interfaces;

namespace PracticaStrategyLamda.Visitantes
{
    public class VisualizadorExtendido : IVisualizadorAbstracto
    {
        #region Atributos
        private int numTabulaciones = 0;
        #endregion

        #region Funcion Lambda
        public Func<string, string> CambiaLetra
        {
            get => cambiaLetra;
            set => cambiaLetra = value;
        }

        private Func<string, string> cambiaLetra = (x) => x;
        #endregion

        #region Metodos Interfaz
        public string visualizarArchivo(Archivo a)
        {
            return cambiaLetra("f  " + a.ToString());
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
            return cambiaLetra(mostrar);
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
            return cambiaLetra(mostrar);
        }
        public string visualizarEnlaceDirecto(EnlaceDirecto ed)
        {
            return cambiaLetra("e  " + ed.ToString());
        }
        #endregion
    }
}
