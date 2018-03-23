using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrera__Liebre_Tortuga
{
    class Tortuga: Competidor
    {
        private int valor;
        Random rdm = new Random();
        public Tortuga (string nombre )
            : base(nombre)
        {

        }

    public void avanzar()
        {
            valor = rdm.Next(1, 11);
            if (valor < 3)
            {
                pocision += 0;
            }
            else if (valor < 5)
            {
                pocision += 9;
            }
            else if (valor < 6)
            {
                pocision += -12;
            }
            else if (valor < 9)
            {
                pocision += 1;
            }
            else
                pocision += -2;
        }
        public override string ToString()
        {
            return "la tortuga " +  base.ToString() ;
        }
    }
}
