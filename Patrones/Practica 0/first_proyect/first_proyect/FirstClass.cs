using System;
using System.Collections.Generic;
using System.Text;

namespace first_proyect
{
    public class FirstClass
    {
        private int firstAttribute; //El profesor dice que los atributos siempre privados o protected, y crear getters y setters.

        public FirstClass(int i) {
            this.firstAttribute = i;
        }
    }
}

/*
 * 
 * DIFERENCIA ENTRE PROYECYO Y SOLUCION
 * - Una solucion puede tener muchos proyectos
 * 
 * Para poder ver clases entre proyectos, tenemos que darle a dependencias del segundo proyecto, añadir proyecto y darle al proyecyo que queramos
*/