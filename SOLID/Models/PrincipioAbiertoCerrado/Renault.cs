using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//O: Principio abierto/cerrado
// extiendo la clase principal Coche, a través de otra clase
namespace SOLID.Models
{
    // herencia: Renault hereda de Coche..
    public class Renault : Coche
    {
        public Renault(string marca) : base(marca)
        {
            
        }

        public override int numAsientos()
        {
            return 5;
        }

        public override  int PrecioMedioCoche() { return 18000; }

    }
}
