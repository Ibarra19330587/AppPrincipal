using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AppPrincipal
{
    class Funciones
    {
        public static List<Usuario> mostrar()
        {
            List<Usuario> lista = new List<Usuario>();
            MySqlCommand sentencia = new MySqlCommand(String.Format("select ID, user, password from proveedor"), Conexion.obtenerConexion());
            MySqlDataReader lector = sentencia.ExecuteReader();

            while (lector.Read())
            {
                Usuario usr = new Usuario();
                usr.ID = lector.GetInt32(0);
                usr.user = lector.GetString(1);
                usr.password = lector.GetString(2);
                lista.Add(usr);
            }

            return lista;
        }

        public static List<Persiana> mostrarInventario()
        {
            List<Persiana> lista = new List<Persiana>();
            MySqlCommand sentencia = new MySqlCommand(String.Format("select ID, name, color, cantidad from persiana"), Conexion.obtenerConexion());
            MySqlDataReader lector = sentencia.ExecuteReader();

            while (lector.Read())
            {
                Persiana usr = new Persiana();
                usr.ID = lector.GetInt32(0);
                usr.name = lector.GetString(1);
                usr.color = lector.GetString(2);
                usr.cantidad = lector.GetString(3);
                lista.Add(usr);
            }

            return lista;
        }
        public static List<Client> mostrarVentas()
        {
            List<Client> lista = new List<Client>();
            MySqlCommand sentencia = new MySqlCommand(String.Format("select ID, name, apellido, precio, vendido from cliente"), Conexion.obtenerConexion());
            MySqlDataReader lector = sentencia.ExecuteReader();

            while (lector.Read())
            {
                Client cli = new Client();
                cli.ID = lector.GetInt32(0);
                cli.name = lector.GetString(1);
                cli.apellido = lector.GetString(2);
                cli.precio = lector.GetString(3);
                cli.vendido = lector.GetString(4);
                lista.Add(cli);
            }

            return lista;
        }

        public static bool login(string usuario, string contra)
        {
            bool bandera = false;
            MySqlCommand sentencia = new MySqlCommand(String.Format("select * from proveedor where user='" + usuario + "' and password='" + contra + "'"), Conexion.obtenerConexion());
            MySqlDataReader lector = sentencia.ExecuteReader();

            if (lector.Read())
            {
                bandera = true;
            }
            else
            {
                bandera = false;
            }

            return bandera;
        }

        public static string insertar(string usuario, string contra)
        {
            string mensaje;
            string query = "INSERT INTO proveedor (user, password) VALUES ( '" + usuario + "', '" + contra + "');";
            MySqlCommand sentencia = new MySqlCommand(String.Format(query), Conexion.obtenerConexion());
            MySqlDataReader lector = sentencia.ExecuteReader();

            if (lector.RecordsAffected > 0)
            {
                mensaje = "OK";
            }
            else
            {
                mensaje = "No se registro usuario";
            }

            return mensaje;
        }

        public static string insertarPersiana(string nombre, string color, string cantidad)
        {
            string mensaje;
            string query = "INSERT INTO persiana (name, color, cantidad) VALUES ( '" + nombre + "', '" + color + "', '" + cantidad + "');";
            MySqlCommand sentencia = new MySqlCommand(String.Format(query), Conexion.obtenerConexion());
            MySqlDataReader lector = sentencia.ExecuteReader();

            if (lector.RecordsAffected > 0)
            {
                mensaje = "OK";
            }
            else
            {
                mensaje = "No se registro la persiana";
            }

            return mensaje;
        }
        public static string insertarCliente(string name, string apellido, string precio, string vendido)
        {
            string mensaje;
            string query = "INSERT INTO cliente (name, apellido, precio, vendido) VALUES ( '" + name + "', '" + apellido + "', '" + precio + "', '" + vendido + "');";
            MySqlCommand sentencia = new MySqlCommand(String.Format(query), Conexion.obtenerConexion());
            MySqlDataReader lector = sentencia.ExecuteReader();

            if (lector.RecordsAffected > 0)
            {
                mensaje = "OK";
            }
            else
            {
                mensaje = "No se registro la persiana";
            }

            return mensaje;
        }
        public static string actualizarTela(int ID, string cantidad)
        {
            string mensaje;
            string query = "UPDATE persiana SET cantidad='" + cantidad+
                           "' WHERE ID =" + ID + ";";
            MySqlCommand sentencia = new MySqlCommand(String.Format(query), Conexion.obtenerConexion());
            MySqlDataReader lector = sentencia.ExecuteReader();

            if (lector.RecordsAffected > 0)
            {
                mensaje = "OK";
            }
            else
            {
                mensaje = "No se actualizo usuario";
            }

            return mensaje;
        }

        public static string actualizar(int ID, string usuario, string contra)
        {
            string mensaje;
            string query = "UPDATE proveedor SET user='" + usuario +
                           "', password='" + contra +
                           "' WHERE ID =" + ID + ";";
            MySqlCommand sentencia = new MySqlCommand(String.Format(query), Conexion.obtenerConexion());
            MySqlDataReader lector = sentencia.ExecuteReader();

            if (lector.RecordsAffected > 0)
            {
                mensaje = "OK";
            }
            else
            {
                mensaje = "No se actualizo usuario";
            }

            return mensaje;
        }

        public static string eliminar(int ID)
        {
            string mensaje;
            string query = "DELETE FROM proveedor WHERE ID =" + ID + ";";
            MySqlCommand sentencia = new MySqlCommand(String.Format(query), Conexion.obtenerConexion());
            MySqlDataReader lector = sentencia.ExecuteReader();

            if (lector.RecordsAffected > 0)
            {
                mensaje = "OK";
            }
            else
            {
                mensaje = "No se elimino usuario";
            }

            return mensaje;
        }

        public static string eliminarPersiana(int ID)
        {
            string mensaje;
            string query = "DELETE FROM persiana WHERE ID =" + ID + ";";
            MySqlCommand sentencia = new MySqlCommand(String.Format(query), Conexion.obtenerConexion());
            MySqlDataReader lector = sentencia.ExecuteReader();

            if (lector.RecordsAffected > 0)
            {
                mensaje = "OK";
            }
            else
            {
                mensaje = "No se elimino la persiana";
            }

            return mensaje;
        }
    }
}
