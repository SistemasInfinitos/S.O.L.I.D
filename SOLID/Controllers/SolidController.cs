using Microsoft.AspNetCore.Mvc;
using SOLID.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SOLID.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SolidController : ControllerBase
    {
        public static void main(String args)
        {
            Renault renaul = new Renault(args);
            Audi audi = new Audi(args);
            Mercedes mercedes = new Mercedes(args);
            // Solo tendremos que añadir el nuevo coche al array, cumpliendo así el principio abierto/cerrado
            Coche[] arrayCoches = {
                renaul,
                audi,
                mercedes
            };

            imprimirPrecioMedioCoche(arrayCoches);
        }

        public static void imprimirPrecioMedioCoche(Coche[] arrayCoches)
        {
            foreach (Coche item in arrayCoches)
            {
                item.PrecioMedioCoche();
            }
        }
    }
}
