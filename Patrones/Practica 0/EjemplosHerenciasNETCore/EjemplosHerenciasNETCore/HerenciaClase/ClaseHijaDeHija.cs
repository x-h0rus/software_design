using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosHerencia
{
    public class ClaseHijaDeHija : ClaseHija
    {


        public override string retornaMensaje()
        {

            return "Este es un nuevo mensaje";
        }
    }
}
