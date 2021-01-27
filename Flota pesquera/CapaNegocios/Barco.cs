using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlotaPesquera.Datos;


namespace FlotaPesquera.Negocios
{
    public class Barco
    {
        public object Dim { get; private set; }
        
        public string ConsultarTripulantes (int idBarco)
        {
            SQLServer objetoSQL = new SQLServer();
            string nombreBarco = objetoSQL.ObtenerDatos(idBarco);
            
            if (nombreBarco == "Titanic")
                return "El barco " + nombreBarco + " cuenta con 40 personas";
            else 
                return "El barco " + nombreBarco + " cuenta con 30 personas";

        }
        
    }
}
