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

                cmd.CommandText = "UPDATE [Produccion].[Materiales] SET Existencia = Existencia - @Cantidad WHERE IdMaterial = @Material" +
                    "" + Environment.NewLine +
                    "INSERT INTO [Produccion].[GastosMaterial] VALUES (" +
                    "@Material," +
                    "@LoteEtapa," +
                    "@Cantidad," +
                    "@Tipo," +
                    "@Observacion" +
                    ")" + Environment.NewLine +
                    "SELECT CAST(SCOPE_IDENTITY() as int)";

                cmd.Parameters.AddWithValue("@Material", g.Material.IdMaterial);
                cmd.Parameters.AddWithValue("@LoteEtapa", e.IdLoteEtapa);
                cmd.Parameters.AddWithValue("@Cantidad", g.Cantidad);
                cmd.Parameters.AddWithValue("@Tipo", g.Tipo);
                cmd.Parameters.AddWithValue("@Observacion", g.Observacion);

                int id = (int)cmd.ExecuteScalar();
                g.IdGastoMaterial = id;
                
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

        public List<GastosMaterial> CargarGastosMaterial(LoteEtapa e)
        {
            SqlCommand cmd = null;
            SqlConnection connection = null;
            SqlDataReader reader = null;

            try
            {
                connection = GetConnection();
                connection.Open();

                cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT * FROM [Produccion].[GastosMaterial] WHERE LoteEtapa = @LoteEtapa";
                cmd.Parameters.AddWithValue("@LoteEtapa", e.IdLoteEtapa);

                reader = cmd.ExecuteReader();

                while (reader.Read()) {
                    GastosMaterial g = new GastosMaterial();
                    g.Cantidad = (double)(decimal)reader["Cantidad"];
                    g.IdGastoMaterial = (int)reader["IdGastoMaterial"];
                    g.Material = new Controlador.Produccion.ControladorMaterial().GetById((int)reader["Material"]);
                    g.Observacion = (string)reader["Observacion"];
                    g.Tipo = (GastosMaterial.TiposGasto)reader["Tipo"];

                    e.GastosMateriales.Add(g);
                }

                return e.GastosMateriales;
            }
            catch (Exception ex)
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
