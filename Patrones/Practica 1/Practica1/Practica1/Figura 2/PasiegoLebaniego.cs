using System;
using System.Collections.Generic;
using System.Text;

namespace Practica1.Figura_2
{
    /**
     * Clase que representa la clase PasiegoLebaniego
     * @author Adrian Garcia Cubas
     */
    public class PasiegoLebaniego : Pasiego, ILebaniego
    {
        public TipoContexto Contexto { get; set; }

        protected ILebaniego mixedLebaniego = new Lebaniego();

        /**
         * Constructor de la clase PasiegoLebaniego que inicializa el TipoContexto a PAS
         */
        public PasiegoLebaniego()
        {
            Contexto = TipoContexto.PAS;
        }
       
        public String hacerOrujo()
        {
           return mixedLebaniego.hacerOrujo();
        }

        public override String hacerCocido()
        {
            if (Contexto.Equals(TipoContexto.PAS))
            {
                return base.hacerCocido();
            }
            else
            {
                return mixedLebaniego.hacerCocido();
            }
        }
    }
}
