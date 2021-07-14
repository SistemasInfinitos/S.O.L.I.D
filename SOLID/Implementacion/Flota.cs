using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SOLID.ImplementacionContrato;

namespace SOLID.Implementacion
{
    //Liskov substitution Principle (LSP)
    //aquí usamos 2 métodos de los tres que existen
    public class Flota : IAutoPasajeros, IAutoVelocidad
    {
        public int getTrasportarPasajero()
        {
            return 778;
        }

        public int getVelocidad()
        {
            return 80;
        }
    }
}
