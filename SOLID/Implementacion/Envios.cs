using SOLID.ImplementacionContrato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//Liskov substitution Principle (LSP)
namespace SOLID.Implementacion
{
    //Liskov substitution Principle (LSP)
    //aquí usamos 2 métodos de los tres que existen
    public class Envios : IAutoCapacidad, IAutoVelocidad
    {
        public int getToneladas()
        {
            return 20;
        }

        public int getVelocidad()
        {
            return 40;
        }
    }
}
