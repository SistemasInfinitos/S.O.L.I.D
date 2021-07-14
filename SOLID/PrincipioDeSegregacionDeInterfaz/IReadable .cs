using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//MAURICIO BELLO COGOLLO
//ISP: Principio de segregación de interfaz
namespace SOLID.PrincipioDeSegregacionDeInterfaz
{
    public interface IReadable
    {
        void Get(int id);
        void GetAll();
    }
}
