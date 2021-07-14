using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOLID.PrincipioDeInversionDeDependencias
{
    public class AccesoADatos
    {
        private IConexion conexion;

        public AccesoADatos(IConexion conexion)
        {
            this.conexion = conexion;
        }

        Dato getDatos()
        {
            conexion.getDatos();
        }
    }
}
