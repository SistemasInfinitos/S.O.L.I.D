using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOLID.PrincipioDeInversionDeDependencias
{
    public class APIService: IConexion
    {
        public APIService(string marca) : base(marca)
        {

        }
        public override Dato getDatos()
        { 
            //...
        }

        public override void setDatos()
        { 
            ///. 
        }
    }
}
