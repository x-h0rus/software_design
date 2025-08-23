using ExamenNoviembre2021.Tareas.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenNoviembre2021.Iterador
{
    public class TaskHelper
    {
        public static bool ContainsTwoTinyTask(ISet<ITarea> tareas)
        {
            bool found = false;
            int numTareas = 0;
            IEnumerator<ITarea> iterador = tareas.GetEnumerator();

            while(iterador.MoveNext() && numTareas < 2)
            {
                if(iterador.Current.Remaining <= 0.5)
                {
                    numTareas++;
                    if (numTareas >= 2)
                    {
                        found = true;
                    }
                }
            }
            return found;
        }
    }

    //PREGUNTA 7

    /*
     * La relacion existente entre el principio de "Imaginacion Pura" y el patrón Visitor es que los visitantes creados con el patron Visitor
     * no suelen ser elementos del dominio de la aplicacion, si no que son ideas mentales que mejoran aspectos del diseño de una aplicación.
     * 
     * En este caso, la clase VisitanteAbstracto seria una clase fabricada para poder visualizar cuantas tareas simples nos quedan por terminar
     * dentro de un proyecto o subproyecto.
     */
}
