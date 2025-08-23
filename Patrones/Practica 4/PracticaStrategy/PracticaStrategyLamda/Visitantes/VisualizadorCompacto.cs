using System;
using System.Collections.Generic;
using System.Text;
using PracticaStrategyLamda.Visitantes.Interfaces;
using PracticaStrategyLamda.Elementos;
using PracticaStrategyLamda.Elementos.Interfaces;

namespace PracticaStrategyLamda.Visitantes
{
    public class VisualizadorCompacto : IVisualizadorAbstracto
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
            return cambiaLetra(a.ToString());
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
            return cambiaLetra(mostrar);
        }
        public string visualizarArchivoComprimido(ArchivoComprimido ac)
        {
            return cambiaLetra(ac.ToString());
        }
        public string visualizarEnlaceDirecto(EnlaceDirecto ed)
        {
            return cambiaLetra(ed.ToString());
        }
        #endregion
    }
}
