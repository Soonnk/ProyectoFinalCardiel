using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Controlador
{
    class Utils
    {
        public static readonly string InsertListaContactos = "INSERT INTO ListaContactos VALUES (next value for seq_ListaContactos)" + Environment.NewLine +
            "SELECT Max(IdListaContactos) FROM ListaContactos";

        public static DataTable GetCatalog(string catalog) {
            AccesoDatos.ConexionSQL conn = null;
            SqlConnection connection = null;
            SqlDataAdapter adapter = null;

            DataTable dt = null;
            try
            {
                conn = new AccesoDatos.ConexionSQL() { NivelUsuario = Modelo.Usuarios.Usuario.NivelesUsuario.Visor };
                connection = conn.GetConnection();

                adapter = new SqlDataAdapter("SELECT * FROM " + catalog, connection);

                adapter.Fill(dt);

                return dt;
            }
            catch
            {
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                    connection.Dispose();
                }
            }
        }
    }
}
