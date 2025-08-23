using System;
using System.Collections.Generic;
using System.Text;

namespace Practica1.Figura_1
{
    /**
     * Clase que representa a un PasiegoLebaniego
     * @author Adrian Garcia Cubas
     */
    public class PasiegoLebaniego : Pasiego, ILebaniego
    {
         protected ILebaniego mixedLebaniego = new Lebaniego();

        public String hacerCocido()
        {
            return mixedLebaniego.hacerCocido();
        }

        public String hacerOrujo()
        {
            return mixedLebaniego.hacerOrujo();
        }
    }
}
