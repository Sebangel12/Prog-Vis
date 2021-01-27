using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlotaPesquera.Datos
{
    public class SQLServer
    {
        public string cadenaConexion { get; set; }
        public string ObtenerDatos (int idBarco)
        {
            if (idBarco == 30)
                return "Titanic";
            else
                return "Brisa";
        }
               
    }
}
