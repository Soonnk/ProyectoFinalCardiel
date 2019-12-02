using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProyectoFinal.Modelo.Produccion;

namespace ProyectoFinal.Controlador.Produccion
{
    public class ControladorLoteEtapa : AccesoDatos.ConexionSQL
    {
        public ControladorLoteEtapa()
        {
            this.NivelUsuario = Session.UsuarioEnCurso.NivelUsuario;
        }


        public void AgregarGastoDeMaterial(LoteEtapa e, GastosMaterial g)
        {
            SqlConnection connection = null;
            SqlCommand cmd = null;

            try
            {
                connection = GetConnection();
                connection.Open();
                cmd = connection.CreateCommand();

                cmd.CommandText = "INSERT INTO [Produccion].[GastosMaterial] VALUES (" +
                    "@Material," +
                    "@LoteEtapa," +
                    "@Cantidad," +
                    "@Tipo," +
                    "@Observacion" +
                    ")" + Environment.NewLine +
                    "SELECT SCOPE_IDENTITY()";

                cmd.Parameters.AddWithValue("@Material", g.Material.IdMaterial);
                cmd.Parameters.AddWithValue("@LoteEtapa", e.IdLoteEtapa);
                cmd.Parameters.AddWithValue("@Cantidad", g.Cantidad);
                cmd.Parameters.AddWithValue("@Tipo", g.Tipo);
                cmd.Parameters.AddWithValue("@Observacion", g.Observacion);

                int id = (int)cmd.ExecuteScalar();
                g.IdGastoMaterial = id;

                if (!e.GastosMateriales.Contains(g))
                {
                    e.GastosMateriales.Add(g);
                }
            }
            catch (Exception ex)
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
