using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProyectoFinal.Modelo;

namespace ProyectoFinal.Controlador
{
    public class ControladorContacto : AccesoDatos.ConexionSQL
    {
        public ControladorContacto()
        {
            //TODO Volver a aplicar Permisos de usuario aqui
            //this.NivelUsuario = Session.UsuarioEnCurso.NivelUsuario;
            this.NivelUsuario = Modelo.Usuarios.Usuario.NivelesUsuario.Administrador;
        }

        public DataTable GetAll(int Lista)
        {
            SqlConnection connection = GetConnection();

            connection.Open();

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM ListaContactos " +
                            "INNER JOIN DesgloseContactos On DesgloseContactos.ListaContacto = ListaContactos.IdListaContactos " +
                            "INNER JOIN Contactos On Contactos.IdContacto = DesgloseContactos.Contacto " +
                            "INNER JOIN Personas On Contactos.Persona = Personas.IdPersona " +
                            "WHERE IdListaContactos = @IdLista";
            cmd.Parameters.AddWithValue("@IdLista", Lista);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            
            connection.Close();
            connection.Dispose();
            return dt;
        }

        /// <summary>
        /// Inserta un contacto en la lista especificada
        /// </summary>
        /// <param name="c"></param>
        /// <param name="Lista"></param>
        /// <remarks>
        /// Utilizar esta funcion para insertar un contacto una vez que el cliente o proveedor
        /// asociado a la lista ya han sido agregados, es decir, para agregar contactos cuando
        /// se esta editando el cliente/proveedor.
        /// </remarks>
        public void InsertarContacto(Contacto c, int Lista) {
            SqlConnection connection = null;
            SqlTransaction transaction = null;
            try
            {

                connection = GetConnection();

                connection.Open();
                transaction = connection.BeginTransaction();
                SqlCommand cmd = connection.CreateCommand();
                cmd.Transaction = transaction;
                string insertContacto = "INSERT INTO Personas VALUES(" +
                    "@Nombre," +
                    "@ApellidoPaterno," +
                    "@ApellidoMaterno," +
                    "@Telefono," +
                    "@CorreoElectronico," +
                    "@Calle," +
                    "@Numero," +
                    "@Colonia" +
                    ")" + Environment.NewLine +
                    "SELECT CAST(SCOPE_IDENTITY() as int)";

                cmd.CommandText = insertContacto;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Nombre", c.Nombre);
                cmd.Parameters.AddWithValue("@ApellidoPaterno", c.ApellidoPaterno);
                cmd.Parameters.AddWithValue("@ApellidoMaterno", c.ApellidoMaterno);
                cmd.Parameters.AddWithValue("@Telefono", c.Telefono);
                cmd.Parameters.AddWithValue("@CorreoElectronico", c.CorreoElectronico);
                cmd.Parameters.AddWithValue("@Calle", c.Calle);
                cmd.Parameters.AddWithValue("@Numero", c.Numero);
                cmd.Parameters.AddWithValue("@Colonia", c.Colonia);

                int idPersona = (int)cmd.ExecuteScalar();

                insertContacto = "INSERT INTO Contactos VALUES (@IdPersona)" + Environment.NewLine +
                    "SELECT CAST(SCOPE_IDENTITY() as int)";

                cmd.CommandText = insertContacto;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@IdPersona", idPersona);

                int idContacto = (int)cmd.ExecuteScalar();

                insertContacto = "INSERT INTO DesgloseContactos VALUES(" +
                    "@IdLista," +
                    "@IdContacto" +
                    ")";

                cmd.CommandText = insertContacto;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@IdLista", Lista);
                cmd.Parameters.AddWithValue("@IdContacto", idContacto);

                cmd.ExecuteNonQuery();

                transaction.Commit();
                connection.Close();
            }
            catch (Exception ex)
            {
                if (transaction != null) transaction.Rollback();
                if (connection != null) connection.Close();

                throw ex;
            }
        }

        /// <summary>
        /// Inserta un contacto en la lista especificada usando un comando ya otorgado
        /// </summary>
        /// <param name="c">Objeto de la clase <see cref="Contacto"/> a insertar</param>
        /// <param name="Lista">Lista de usuarios destino</param>
        /// <param name="cmd">Comando <see cref="SqlCommand"/> con transaccion y conexion
        /// ya configuradas</param>
        /// <remarks>
        /// Se utiliza este metodo principalmente para la primera insercion de un proveedor o
        /// cliente. Esto permitirá mantener todo el proceso dentro de la misma transaccion
        /// </remarks>
        public static void InsertarContacto(Modelo.Contacto c, int Lista, SqlCommand cmd)
        {
            string insertContacto = "INSERT INTO Personas VALUES(" +
                "@Nombre," +
                "@ApellidoPaterno," +
                "@ApellidoMaterno," +
                "@Telefono," +
                "@CorreoElectronico," +
                "@Calle," +
                "@Numero," +
                "@Colonia" +
                ")" + Environment.NewLine +
                "SELECT CAST(SCOPE_IDENTITY() as int)";

            cmd.CommandText = insertContacto;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Nombre", c.Nombre);
            cmd.Parameters.AddWithValue("@ApellidoPaterno", c.ApellidoPaterno);
            cmd.Parameters.AddWithValue("@ApellidoMaterno", c.ApellidoMaterno);
            cmd.Parameters.AddWithValue("@Telefono", c.Telefono);
            cmd.Parameters.AddWithValue("@CorreoElectronico", c.CorreoElectronico);
            cmd.Parameters.AddWithValue("@Calle", c.Calle);
            cmd.Parameters.AddWithValue("@Numero", c.Numero);
            cmd.Parameters.AddWithValue("@Colonia", c.Colonia);

            int idPersona = (int)cmd.ExecuteScalar();

            insertContacto = "INSERT INTO Contactos VALUES (@IdPersona)" + Environment.NewLine +
                "SELECT CAST(SCOPE_IDENTITY() as int)";

            cmd.CommandText = insertContacto;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@IdPersona", idPersona);

            int idContacto = (int)cmd.ExecuteScalar();

            insertContacto = "INSERT INTO DesgloseContactos VALUES(" +
                "@IdLista," +
                "@IdContacto" +
                ")";

            cmd.CommandText = insertContacto;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@IdLista", Lista);
            cmd.Parameters.AddWithValue("@IdContacto", idContacto);

            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// Los contactos no mantiene relaciones por lo que se utiliza directamente un drop en ellos
        /// </summary>
        public void DropContacto(Modelo.Contacto c, int Lista)
        {
            SqlConnection connection = null;
            try
            {

                connection = GetConnection();

                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                string insertContacto = "DELETE FROM DesgloseContactos WHERE Persona = @IdPersona " +
                    "AND ListaContactos = @IdLista";

                cmd.CommandText = insertContacto;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@IdPersona", c.IdPersona);
                cmd.Parameters.AddWithValue("@IdLista", Lista);
                
                cmd.ExecuteNonQuery();
                
                connection.Close();
            }
            catch (Exception ex)
            {
                if (connection != null) connection.Close();
                throw ex;
            }
        }

        public void UpdateContacto(Modelo.Contacto c) {
            SqlConnection connection = null;
            SqlTransaction transaction = null;
            try
            {

                connection = GetConnection();

                connection.Open();
                transaction = connection.BeginTransaction();
                SqlCommand cmd = connection.CreateCommand();
                cmd.Transaction = transaction;
                string insertContacto = "UPDATE Personas SET " +
                    "Nombres = @Nombre," +
                    "ApellidoPaterno = @ApellidoPaterno, " +
                    "ApellidoMaterno = @ApellidoMaterno, " +
                    "Telefono = @Telefono, " +
                    "CorreoElectronico = @CorreoElectronico, " +
                    "Calle = @Calle, " +
                    "Numero = @Numero, " +
                    "Colonia = @Colonia " +
                    "WHERE IdPersona = @IdPersona";

                cmd.CommandText = insertContacto;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Nombre", c.Nombre);
                cmd.Parameters.AddWithValue("@ApellidoPaterno", c.ApellidoPaterno);
                cmd.Parameters.AddWithValue("@ApellidoMaterno", c.ApellidoMaterno);
                cmd.Parameters.AddWithValue("@Telefono", c.Telefono);
                cmd.Parameters.AddWithValue("@CorreoElectronico", c.CorreoElectronico);
                cmd.Parameters.AddWithValue("@Calle", c.Calle);
                cmd.Parameters.AddWithValue("@Numero", c.Numero);
                cmd.Parameters.AddWithValue("@Colonia", c.Colonia);
                cmd.Parameters.AddWithValue("@IdPersona", c.IdPersona);

                cmd.ExecuteNonQuery();

                transaction.Commit();
                connection.Close();
            }
            catch (Exception ex)
            {
                if (transaction != null) transaction.Rollback();
                if (connection != null) connection.Close();

                throw ex;
            }
        }
    }
}
