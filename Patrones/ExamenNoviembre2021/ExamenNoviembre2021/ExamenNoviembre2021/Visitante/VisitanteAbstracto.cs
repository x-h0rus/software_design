using ExamenNoviembre2021.Tareas;
using ExamenNoviembre2021.Tareas.Interfaces;
using ExamenNoviembre2021.Visitante.Interfaz;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenNoviembre2021.Visitante
{
    public class VisitanteAbstracto : IVisitanteAbstracto
    {
        public Object Clone()
        {
            return new VisitanteAbstracto();
        }

        public bool visitarTareaCompuesta(TareaCompuesta tc)
        {
            return true;
        }

        public bool visitarTareaSimple(TareaSimple ts)
        {
            return tareaNoFinalizada(ts);
        }

        private bool tareaNoFinalizada(ITarea tarea)
        {
            bool tareaFinalizada = false;
            if(tarea.Remaining == 0)
            {
                tareaFinalizada = true;
            }
            return tareaFinalizada;
        }

        private void anhadirTareasNoFinalizadas(ITareaSimple ts)
        {
            ISet<ITareaSimple> tareasNoFinalizadas = new HashSet<ITareaSimple>();
            tareasNoFinalizadas.Add(ts);
        }
    }
}
