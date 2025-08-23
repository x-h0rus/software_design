using System;
using System.Collections.Generic;
using System.Text;

namespace Practica1.Figura_1
{
    /**
     * Interfaz que define las acciones que puede realizar un pasiego
     * @author Adrian Garcia Cubas
     */
    public interface IPasiego
    {
        /*
         * Lanza un mensaje que indica que esta haciendo sobaos
         */
        public String hacerSobaos();

        /*
         * Lanza un mensaje que indica que esta haciendo quesada
         */
        public String hacerQuesada();
    }
}
