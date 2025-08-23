using System;
using System.Collections.Generic;
using System.Text;
using PracticaFactory.Visitantes.Interfaces;
using PracticaFactory.Elementos;
using PracticaFactory.Elementos.Interfaces;
using PracticaFactory.Estrategias.Interfaces;

namespace PracticaFactory.Visitantes
{
    public class VisualizadorCompacto : IVisualizadorAbstracto
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
            return Estrategia.reemplazarLetra(a.ToString());
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
            return Estrategia.reemplazarLetra(mostrar);
        }
        public string visualizarArchivoComprimido(ArchivoComprimido ac)
        {
            return Estrategia.reemplazarLetra(ac.ToString());
        }
        public string visualizarEnlaceDirecto(EnlaceDirecto ed)
        {
            return Estrategia.reemplazarLetra(ed.ToString());
        }
        #endregion
    }
}
