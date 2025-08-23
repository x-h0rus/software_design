using System;
using System.Collections.Generic;
using System.Text;

namespace Practica1.Figura_2
{
    public class Pasiego : IPasiego
    {
        public String hacerSobaos()
        {
            return "Estoy haciendo sobaos";
        }

        public String hacerQuesada()
        {
            return "Estoy haciendo quesada";
        }

        public virtual String hacerCocido()
        {
            return "Estoy haciendo cocido montanes";
        }
    }
}
