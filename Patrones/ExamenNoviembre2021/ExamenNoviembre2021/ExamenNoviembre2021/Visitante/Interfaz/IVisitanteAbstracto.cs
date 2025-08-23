using ExamenNoviembre2021.Tareas;
using ExamenNoviembre2021.Tareas.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenNoviembre2021.Visitante.Interfaz
{
    public interface IVisitanteAbstracto : ICloneable
    {
        bool visitarTareaSimple(TareaSimple ts);

        bool visitarTareaCompuesta(TareaCompuesta tc);
    }
}
