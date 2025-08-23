using System;
using System.Collections.Generic;
using System.Text;

namespace EjemploClonable
{
    public class ClaseClonable : InterfazClonable
    {

        public object Clone()
        {

            return new ClaseClonable();
        }

    }
}
