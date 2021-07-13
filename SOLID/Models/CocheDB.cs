using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//S: Principio de responsabilidad única
namespace SOLID.Models
{
    /// <summary>
    /// la clase CocheDB  tiene una unica  responsabilidades y se encarga de conectar con la base de datos
    /// </summary>
    public class CocheDB
    {
        void guardarCocheDB(Coche coche) 
        {
           // ... 
        }
        void eliminarCocheDB(Coche coche) 
        {
           // ... 
        }
    }
}
