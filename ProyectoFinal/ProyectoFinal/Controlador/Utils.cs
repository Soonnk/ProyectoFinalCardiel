using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Controlador
{
    public class Utils
    {
        public static readonly string InsertListaContactos = "INSERT INTO ListaContactos VALUES (next value for seq_ListaContactos)" + Environment.NewLine +
            "SELECT Max(IdListaContactos) FROM ListaContactos";

        public static DataTable GetCatalog(string catalog) {
            AccesoDatos.ConexionSQL conector = null;
            SqlConnection connection = null;
            SqlDataAdapter adapter = null;

            DataTable dt = new DataTable();
            try
            {
                conector = new AccesoDatos.ConexionSQL() { NivelUsuario = Modelo.Usuarios.Usuario.NivelesUsuario.Visor };
                connection = conector.GetConnection();
                connection.Open();

                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT * FROM " + catalog;
                adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);

                return dt;
            }
            catch(Exception ex)
            {
                throw ex;
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
