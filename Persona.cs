using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambitos
{
    class Persona
    {
        public string rut;
        public int edad;
        public string nombre;
        public string cargo;
        public int sueldo;

        // Método
        private int calculoSueldo(string cargoPersona)
        {
            if (cargoPersona == "Analista")
            {
                return 1700000;
            }
            else if(cargo == "Operador")
            {
                return 800000;
            }
            else
            {
                return 0;
            }
        }
    }
}
