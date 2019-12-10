using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProyectoFinal.Modelo;

namespace ProyectoFinal.Controlador.Usuarios
{
    public class ControladorUsuario : AccesoDatos.ConexionSQL
    {
        public ControladorUsuario()
        {
            this.NivelUsuario = Session.UsuarioEnCurso.NivelUsuario;
        }

        public void InsertarUsuario(Modelo.Usuarios.Usuario u)
        {
            SqlConnection connection = null;
            SqlCommand cmd = null;
            SqlTransaction transaction = null;

            try
            {
                connection = GetConnection();
                connection.Open();
                transaction = connection.BeginTransaction();
                cmd = connection.CreateCommand();
                cmd.Transaction = transaction;

                cmd.CommandText = "INSERT INTO Persona VALUES(" +
                    "@Nombre," +
                    "@ApellidoPaterno," +
                    "@ApellidoMaterno," +
                    "@Telefono," +
                    "@CorreoElectronico," +
                    "@Calle," +
                    "@Numero," +
                    "@Colonia" +
                    ")" + Environment.NewLine +
                    "SELECT CAST(SCOPE_IDENTITY() as int)"; ;

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Nombre", u.Nombre);
                cmd.Parameters.AddWithValue("@ApellidoPaterno", u.ApellidoPaterno);
                cmd.Parameters.AddWithValue("@ApellidoMaterno", u.ApellidoMaterno);
                cmd.Parameters.AddWithValue("@Telefono", u.Telefono);
                cmd.Parameters.AddWithValue("@CorreoElectronico", u.CorreoElectronico);
                cmd.Parameters.AddWithValue("@Calle", u.Calle);
                cmd.Parameters.AddWithValue("@Numero", u.Numero);
                cmd.Parameters.AddWithValue("@Colonia", u.Colonia);

                int idPersona = (int)cmd.ExecuteScalar();

                cmd.CommandText = "INSERT INTO [Usuarios].[Usuarios] VALUES (@Persona,@Username,@Password,1,@NivelUsuario,@Departamento)";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Persona", idPersona);
                cmd.Parameters.AddWithValue("@Username", u.Username);
                cmd.Parameters.AddWithValue("@Password", u.Password);
                cmd.Parameters.AddWithValue("@NivelUsuario", u.NivelUsuario);
                cmd.Parameters.AddWithValue("@Departamento", u.Departamento);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                if (transaction != null) transaction.Rollback();
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

        public void UpdateUsuario(Modelo.Usuarios.Usuario u)
        {
            SqlConnection connection = null;
            SqlCommand cmd = null;
            SqlTransaction transaction = null;

            try
            {
                connection = GetConnection();
                connection.Open();
                transaction = connection.BeginTransaction();
                cmd = connection.CreateCommand();
                cmd.Transaction = transaction;

                cmd.CommandText = "UPDATE [Persona] SET " +
                    "Nombre = @Nombre," +
                    "ApellidoPaterno = @ApellidoPaterno," +
                    "ApellidoMaterno = @ApellidoMaterno," +
                    "Telefono = @Telefono," +
                    "CorreoElectronico = @CorreoElectronico," +
                    "Calle = @Calle," +
                    "Numero = @Numero," +
                    "Colonia = @Colonia" +
                    ")" + Environment.NewLine +
                    "UPDATE [Usuarios].[Usuarios] SET " +
                    "Username = @Username," +
                    "Password = @Password," +
                    "Estatus = @Estatus," +
                    "NivelUsuario = @NivelUsuario," +
                    "Departamento = @Departamento" ;

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Nombre", u.Nombre);
                cmd.Parameters.AddWithValue("@ApellidoPaterno", u.ApellidoPaterno);
                cmd.Parameters.AddWithValue("@ApellidoMaterno", u.ApellidoMaterno);
                cmd.Parameters.AddWithValue("@Telefono", u.Telefono);
                cmd.Parameters.AddWithValue("@CorreoElectronico", u.CorreoElectronico);
                cmd.Parameters.AddWithValue("@Calle", u.Calle);
                cmd.Parameters.AddWithValue("@Numero", u.Numero);
                cmd.Parameters.AddWithValue("@Colonia", u.Colonia);
                
                cmd.Parameters.AddWithValue("@Persona", u.IdPersona);
                cmd.Parameters.AddWithValue("@Username", u.Username);
                cmd.Parameters.AddWithValue("@Password", u.Password);
                cmd.Parameters.AddWithValue("@Estatus", u.Estatus);
                cmd.Parameters.AddWithValue("@NivelUsuario", u.NivelUsuario);
                cmd.Parameters.AddWithValue("@Departamento", u.Departamento);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                if (transaction != null) transaction.Rollback();
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

        public DataTable GetAll()
        {
            SqlConnection connection = null;
            SqlDataAdapter adapter = null;
            DataTable dt = null;

            try
            {
                connection = GetConnection();
                connection.Open();

                string query = "SELECT u.Iduuario, u.Username, p.Nombre, p.ApellidoPaterno, p.ApellidoMaterno, n.Descripcion as DescripcionNivelUsuario, d.Descripcion as DescripcionDepartamento " +
                    "FROM [Usuarios].[Usuario] u " +
                    "INNER JOIN [Personas] On u.IdPersona = p.IdPersona " +
                    "INNER JOIN [Usuarios].[c_NivelesUsuario] n On n.IdNivel = u.NivelUsuario " +
                    "INNER JOIN [Usuarios].[Departamentos] d On d.IdDepartamento = u.Departamento";

                adapter = new SqlDataAdapter(query, connection);

                adapter.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (connection != null) {
                    connection.Close();
                    connection.Dispose();
                }
            }

        }

        public Modelo.Usuarios.Usuario GetById(int id)
        {
            SqlConnection connection = null;
            SqlCommand cmd = null;
            SqlDataReader reader = null;
            Modelo.Usuarios.Usuario u = null;

            try
            {
                connection = GetConnection();
                connection.Open();
                cmd = connection.CreateCommand();

                cmd.CommandText = "SELECT * " +
                    "FROM [Usuarios].[Usuarios] u " +
                    "INNER JOIN [Personas] p On u.Persona = p.IdPersona " +
                    "WHERE IdUsuario = @Id";

                cmd.Parameters.AddWithValue("@Id", id);
                
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    u = new Modelo.Usuarios.Usuario()
                    {
                        IdUsuario = (int)reader["IdUsuario"],
                        IdPersona = (int)reader["IdPersona"],
                        Username = (string)reader["Username"],
                        Password = (string)reader["Password"],
                        NivelUsuario = (Modelo.Usuarios.Usuario.NivelesUsuario)reader["NivelUsuario"],
                        Departamento = (Modelo.Usuarios.Usuario.Departamentos)reader["Departamento"],
                        Nombre = (string) reader["Nombre"],
                        ApellidoPaterno = (string) reader["ApellidoPaterno"],
                        ApellidoMaterno = (string) reader["ApellidoMaterno"],
                        Telefono = (string) reader["Telefono"],
                        CorreoElectronico = (string) reader["CorreoElectronico"],
                        Calle = (string) reader["Calle"],
                        Numero = (string) reader["Numero"],
                        Colonia = (string) reader["Colonia"]
                    };
                }

                return u;
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
