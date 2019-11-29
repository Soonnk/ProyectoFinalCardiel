using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Controlador.Produccion
{
    class ControladorDesign: AccesoDatos.ConexionSQL
    {
        public ControladorDesign()
        {
            this.NivelUsuario = Modelo.Usuarios.Usuario.NivelesUsuario.Administrador;
        }

        public void InsertarDesign(Modelo.Produccion.Design d)
        {
            SqlConnection connection = null;
            SqlCommand cmd = null;

            try
            {
                connection = GetConnection();
                connection.Open();
                cmd = connection.CreateCommand();

                cmd.CommandText = "INSERT INTO [Produccion].[Design] VALUES (@Descripcion,@Alto,@Archivo)";

                cmd.Parameters.AddWithValue("@Descripcion", d.Descripcion);
                cmd.Parameters.AddWithValue("@Alto", d.Descripcion);
                cmd.Parameters.AddWithValue("@Ancho", d.Ancho);
                cmd.Parameters.AddWithValue("@Archivo", d.Archivo);

                cmd.ExecuteNonQuery();
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

        public void UpdateDesign(Modelo.Produccion.Design d)
        {
            SqlConnection connection = null;
            SqlCommand cmd = null;

            try
            {
                connection = GetConnection();
                connection.Open();
                cmd = connection.CreateCommand();

                cmd.CommandText = "UPDATE [Produccion].[Design] SET " +
                    "Descripcion = @Descripcion, " +
                    "Alto = @Alto," +
                    "Archivo = @Archivo " +
                    "WHERE IdDesign = @Id";

                cmd.Parameters.AddWithValue("@Descripcion", d.Descripcion);
                cmd.Parameters.AddWithValue("@Alto", d.Descripcion);
                cmd.Parameters.AddWithValue("@Ancho", d.Ancho);
                cmd.Parameters.AddWithValue("@Archivo", d.Archivo);
                cmd.Parameters.AddWithValue("@Id", d.IdDesign);

                cmd.ExecuteNonQuery();
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

        public Modelo.Produccion.Design GetById(int id)
        {
            SqlConnection connection = null;
            SqlDataReader reader = null;
            SqlCommand cmd = null;
            Modelo.Produccion.Design d = null;

            try
            {
                connection = GetConnection();
                connection.Open();
                cmd = connection.CreateCommand();

                cmd.CommandText = "SELECT * FROM [Produccion].[Design] WHERE IdDesign = @Id";

                cmd.Parameters.AddWithValue("@Id", id);
                
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    d = new Modelo.Produccion.Design() {
                        IdDesign = id,
                        Descripcion = (string)reader["Descripcion"],
                        Alto = (double)reader["Alto"],
                        Ancho = 0,
                        Archivo = (Byte[]) reader["Archivo"]
                    };
                }

                return d;
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

        public DataTable GetAll()
        {
            SqlConnection connection = null;
            SqlDataAdapter adapter = null;
            DataTable dt = null;

            try
            {
                connection = GetConnection();
                connection.Open();
                
                String query = "SELECT * FROM [Produccion].[Design]";

                adapter = new SqlDataAdapter(query, connection);

                adapter.Fill(dt);

                return dt;
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
