using ExamenNoviembre2021.Tareas.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using ExamenNoviembre2021.Visitante.Interfaz;

namespace ExamenNoviembre2021.Tareas
{
    public class TareaCompuesta : ITareaCompuesta
    {
        #region Constructor
        public TareaCompuesta(string titulo)
        {
            this.Titulo = titulo;
        }
        #endregion

        #region Propiedades
        public string Titulo { get; }
        public double Spent
        {
            get => this.Subtareas.Sum((x) => x.Spent);
        }
        public double Remaining
        {
            get => this.Subtareas.Sum((x) => x.Remaining);
        }
        public double Estimated
        {
            get => this.Subtareas.Sum((x) => x.Estimated);
        }
        public ISet<ITarea> Subtareas { get; } = new HashSet<ITarea>();
        #endregion

        #region Metodos Interfaz
        public bool aceptarVisitanteAbstracto(IVisitanteAbstracto va)
        {
            return va.visitarTareaCompuesta(this);
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
            result += ")";

            return result;
        }
        #endregion
    }
}
