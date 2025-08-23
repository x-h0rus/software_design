using System;
using System.Collections.Generic;
using System.Text;

namespace Practica1.Figura_1
{
    /**
     * Interfaz que define las acciones que puede realizar un lebaniego
     * @author Adrian Garcia Cubas
     */
    public interface ILebaniego
    {
        /*
         * Lanza un mensaje que indica que esta haciendo cocido
         */
        public String hacerCocido();

        /*
         * Lanza un mensaje que indica que esta haciendo orujo
         */
        public String hacerOrujo();
    }
}
