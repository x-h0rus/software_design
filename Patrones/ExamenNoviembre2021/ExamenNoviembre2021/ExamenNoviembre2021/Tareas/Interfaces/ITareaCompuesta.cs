using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenNoviembre2021.Tareas.Interfaces
{
    public interface ITareaCompuesta : ITarea
    {
        ISet<ITarea> Subtareas { get; }
    }
}
