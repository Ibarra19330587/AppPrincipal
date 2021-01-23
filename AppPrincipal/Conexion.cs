using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AppPrincipal
{
    class Conexion
    {
        public static MySqlConnection obtenerConexion()
        {
            MySqlConnection conexion = new MySqlConnection("server=localhost; database=empresa; user id=root; password=WILLiberto15;");
            conexion.Open();
            return conexion;
        }
    }
}
