using ExamenNoviembre2021.Visitante.Interfaz;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenNoviembre2021.Tareas.Interfaces
{
    public interface ITarea
    {
        #region Propiedades
        string Titulo { get; }
        double Spent { get; }
        double Remaining { get; }
        double Estimated { get; }

        bool aceptarVisitanteAbstracto(IVisitanteAbstracto va);
        #endregion
    }
}
