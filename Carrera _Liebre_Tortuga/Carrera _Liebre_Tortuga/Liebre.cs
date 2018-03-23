using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrera__Liebre_Tortuga
{
    class Liebre : Competidor
    {
        private int valor;
        Random rdm = new Random();

        public  Liebre(string _nombre)
            :base(_nombre)
        {

        }

     

        public void avanzar()
        {
            valor = rdm.Next(1, 11);
      if (valor < 6)
            {
                pocision += 3;
            }
      else if (valor < 8)
            {
                pocision += -6;
            }
      else
            {
                pocision += 1;
            }
        }

        public override string ToString()
        {
            return "la liebre "+ base.ToString() ;
        }
    }
}
