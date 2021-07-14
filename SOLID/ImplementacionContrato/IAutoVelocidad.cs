using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//Liskov substitution Principle (LSP)
//Creamos 3 interfaces con su respectivo método particular (contrato)  y las implementamos según corresponda su naturaleza y así evitamos 
//tener que implementar todos los métodos del contrato en todas las clases que requieran uno o varios de los métodos.
namespace SOLID.ImplementacionContrato
{
    // interface 1
    public interface IAutoVelocidad
    {
        public int getVelocidad();
    }
}
