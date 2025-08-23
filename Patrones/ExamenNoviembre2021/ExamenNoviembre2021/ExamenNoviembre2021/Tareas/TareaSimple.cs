using ExamenNoviembre2021.Tareas.Interfaces;
using ExamenNoviembre2021.Visitante.Interfaz;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenNoviembre2021.Tareas
{
    public class TareaSimple : ITareaSimple
    {
        #region Constructor
        /*
         * Constructor de la clase tarea simple
         * @pre (titulo <> null) && (titulo <> "")
         * @pre estimated > 0
         */
        public TareaSimple(string titulo, double estimated)
        {
            this.Titulo = titulo;
            this.Estimated = estimated;
            this.Spent = 0;
            this.Remaining = estimated;
        }
        #endregion

        #region Propiedades
        /*
         * Propiedad del titulo de una tarea simple
         * @inv (titulo <> null) && (titulo <> "")
         */
        public string Titulo { get; }
        /*
         * Propiedad del tiempo dedicado a una tarea simple
         * @inv Spent >= 0
         */
        public double Spent { get; set; }
        /*
         * Propiedad del tiempo restante de una tarea simple
         * @inv Remaining >= 0
         */
        public double Remaining { get; set; }
        /*
         * Propiedad del tiempo estimado de una tarea simple
         * @inv Estimated >= 0
         */
        public double Estimated { get; }
        #endregion

        #region Metodos Interfaz
        public bool aceptarVisitanteAbstracto(IVisitanteAbstracto va)
        {
            return va.visitarTareaSimple(this);
        }
        #endregion

        #region Metodos Auxiliares
        public override string ToString()
        {
            string result = null;

            result += Titulo;
            result += " (";
            result += Spent;
            result += "/";
            result += Remaining;
            result += "/";
            result += Estimated;

            return result;
        }
        #endregion
    }
}
