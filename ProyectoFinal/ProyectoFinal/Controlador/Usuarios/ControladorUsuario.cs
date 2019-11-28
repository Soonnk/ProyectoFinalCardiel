using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProyectoFinal.Modelo;

namespace ProyectoFinal.Controlador.Usuarios
{
    class ControladorUsuario: AccesoDatos.ConexionSQL
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
                    "SELECT SCOPE_IDENTITY()"; ;

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
    }
}
