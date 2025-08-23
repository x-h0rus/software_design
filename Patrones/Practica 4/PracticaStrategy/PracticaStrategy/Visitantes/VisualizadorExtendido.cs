using System;
using System.Collections.Generic;
using System.Text;
using PracticaStrategy.Elementos;
using PracticaStrategy.Visitantes.Interfaces;
using PracticaStrategy.Elementos.Interfaces;
using PracticaStrategy.Estrategias.Interfaces;

namespace PracticaStrategy.Visitantes
{
    public class VisualizadorExtendido : IVisualizadorAbstracto
    {
        #region Atributos
        private int numTabulaciones = 0;
        #endregion

        #region Propiedades
        public IEstrategia Estrategia { get; set; }
        #endregion

        #region Metodos Interfaz
        public string visualizarArchivo(Archivo a)
        {
            return Estrategia.reemplazarLetra("f  " + a.ToString());
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
            return Estrategia.reemplazarLetra(mostrar);
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
            return Estrategia.reemplazarLetra(mostrar);
        }
        public string visualizarEnlaceDirecto(EnlaceDirecto ed)
        {
            return Estrategia.reemplazarLetra("e  " + ed.ToString());
        }
        #endregion
    }
}
