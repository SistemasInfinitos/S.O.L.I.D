using SOLID.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//S: Principio de responsabilidad única
namespace SOLID.Models
{

    /// <summary>
    /// la clase Coche tiene una unica  responsabilidades
    /// </summary>
    public abstract class Coche
    {
        String Marca;

        public Coche(String marca) { this.Marca = marca; }

        String getMarcaCoche() { return Marca; }

        public abstract int PrecioMedioCoche();
        public abstract int numAsientos();
    }
}
