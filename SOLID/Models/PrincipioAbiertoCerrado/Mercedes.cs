using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


//O: Principio abierto/cerrado
// extiendo la clase principal Coche, a través de otra clase
// la classe Mercedes tiene su propia implementación del método precioMedioCoche()
namespace SOLID.Models
{
    // herencia: Mercedes Hereda de Coche...
    public class Mercedes : Coche
    {
        public Mercedes(string marca) : base(marca)
        {

        }
        //L: Principio de substitución de Liskov
        //código reutilizable
        public override int numAsientos()
        {
            return 33;
        }

        public override int PrecioMedioCoche()
        {
            throw new NotImplementedException();
        }
    }
}
