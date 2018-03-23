using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrera__Liebre_Tortuga
{
    class Competidor
    {
        protected int pocision;
        protected string nombre;
       
        public int  Pocision { get { return pocision; } }
        

        public Competidor(string _nombre)
        {
            nombre = _nombre;
            pocision = 0;
        }
        public string Nombre { get { return nombre; } }

        public override string ToString()
        {
            return " con el nombre " + nombre + " esta en la pocision " + pocision +Environment.NewLine ;
        }
    }
    
}
