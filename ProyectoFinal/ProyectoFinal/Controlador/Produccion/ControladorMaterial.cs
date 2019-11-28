using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProyectoFinal.Modelo.Produccion;

namespace ProyectoFinal.Controlador.Produccion
{
    class ControladorMaterial: AccesoDatos.ConexionSQL
    {
        public ControladorMaterial()
        {
            this.NivelUsuario = Session.UsuarioEnCurso.NivelUsuario;
        }

        public DataTable GetBy(string filtro)
        {
            SqlConnection connection = null;
            try
            {
                connection = GetConnection();

                connection.Open();

                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT m.*,t.Descripcion as DescripcionTipo FROM [Produccion].[Materiales]  " + Environment.NewLine +
                    "INNER JOIN [Produccion].[c_TiposMateriales] t ON m.Tipo = t.IdTipoMaterial " + filtro;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                connection.Close();
                connection.Dispose();
                return dt;
            }
            catch (Exception ex)
            {
                if (connection != null) {
                    connection.Close();
                    connection.Dispose();
                }

                throw ex;
            }
        }

        public DataTable GetAll()
        {
            SqlConnection connection = null;
            try
            {
                connection = GetConnection();

                connection.Open();

                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT m.*,t.Descripcion as DescripcionTipo FROM [Produccion].[Materiales] m " + Environment.NewLine +
                    "INNER JOIN [Produccion].[c_TiposMateriales]  t ON m.Tipo = t.IdTipoMaterial";

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                connection.Close();
                connection.Dispose();
                return dt;
            }
            catch (Exception ex)
            {
                if (connection != null)
                {
                    connection.Close();
                    connection.Dispose();
                }

                throw ex;
            }
        }

        public void InsertarMaterial(Material m)
        {
            SqlConnection connection = null;
            SqlCommand cmd = null;

            try
            {
                connection = GetConnection();
                connection.Open();
                cmd = connection.CreateCommand();

                cmd.CommandText = "INSERT INTO [Produccion].[Materiales] VALUES" + Environment.NewLine +
                    "(@Descripcion,@Costo,@Existencia,@Tipo)";

                cmd.Parameters.AddWithValue("@Descripcion", m.Descripcion);
                cmd.Parameters.AddWithValue("@Costo", m.Costo);
                cmd.Parameters.AddWithValue("@Existencia", m.Existencia);
                cmd.Parameters.AddWithValue("@Tipo", m.Tipo);

                cmd.ExecuteNonQuery();
            }
            catch
            {
                if (connection != null)
                {
                    connection.Close();
                    connection.Dispose();
                }
                throw;
            }
        }

        public void UpdateMaterial(Material m)
        {
            SqlConnection connection = null;
            SqlCommand cmd = null;

            try
            {
                connection = GetConnection();
                connection.Open();
                cmd = connection.CreateCommand();

                cmd.CommandText = "UPDATE [Produccion].[Materiales] SET" + Environment.NewLine +
                    "Descripcion = @Descripcion," +
                    "Costo = @Costo," +
                    "Existencia = @Existencia," +
                    "Tipo = @Tipo" +
                    "WHERE IdMaterial = @IdMaterial";

                cmd.Parameters.AddWithValue("@IdMaterial", m.IdMaterial);
                cmd.Parameters.AddWithValue("@Descripcion", m.Descripcion);
                cmd.Parameters.AddWithValue("@Costo", m.Costo);
                cmd.Parameters.AddWithValue("@Existencia", m.Existencia);
                cmd.Parameters.AddWithValue("@Tipo", m.Tipo);

                cmd.ExecuteNonQuery();
            }
            catch
            {
                if (connection != null)
                {
                    connection.Close();
                    connection.Dispose();
                }
                throw;
            }
        }

        public Material GetById(int id)
        {
            SqlConnection connection = null;
            SqlCommand cmd = null;
            SqlDataReader reader = null;
            Material m = null;

            try
            {
                connection = GetConnection();
                connection.Open();
                cmd = connection.CreateCommand();

                cmd.CommandText = "SELECT m.*,t.Descripcion as DescripcionTipo FROM [Produccion].[Materiales] m " +
                    "INNER JOIN [Produccion].[c_TiposMateriales] t ON m.Tipo = t.IdTipoMaterial " +
                    "WHERE m.IdMaterial = @IdMaterial";

                cmd.Parameters.AddWithValue("@IdMaterial", id);
                
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    m = new Material()
                    {
                        IdMaterial = (int) reader["IdMaterial"],
                        Descripcion = (string) reader["Descripcion"],
                        Costo = (double) reader["Costo"],
                        Existencia = (double) reader["Existencia"],
                        Tipo = (Material.TiposMateriales) reader["Tipo"]
                    };
                }
            }
            catch
            {
                if (connection != null)
                {
                    connection.Close();
                    connection.Dispose();
                }
                throw;
            }
        }
    }
}
