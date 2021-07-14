using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//O: Principio abierto/cerrado
// extiendo la clase principal Coche, a través de otra clase
namespace SOLID.Models
{
    //// herencia: Audi hereda de Coche..
    public class Audi: Coche
    {
        public Audi(string marca) : base(marca)
        {

        }

        public override int numAsientos()
        {
            return 8;
        }

        public override int PrecioMedioCoche()
        {
            return 25000;
        }
    }
}
