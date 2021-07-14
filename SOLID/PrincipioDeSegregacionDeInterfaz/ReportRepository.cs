using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//MAURICIO BELLO COGOLLO
//ISP: Principio de segregación de interfaz
namespace SOLID.PrincipioDeSegregacionDeInterfaz
{
    public class ReportRepository : IReadable
    {
        public void Get(int id) { }
        public void GetAll() { }
    }
}
