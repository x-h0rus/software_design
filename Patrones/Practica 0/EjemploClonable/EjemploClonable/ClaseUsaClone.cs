 using System;
using System.Collections.Generic;
using System.Text;

namespace EjemploClonable
{
    public class ClaseUsaClone
    {
        protected InterfazClonable ic;
        public InterfazClonable Ic {
            get
            {
                return ic;
            }
            set
            {
                ic = value;
            }
        }

        public InterfazClonable creaInterfazClonable()
        {

            return (InterfazClonable) ic.Clone();
        }



    }
}
