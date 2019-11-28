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
    class ControladorContacto: AccesoDatos.ConexionSQL
    {
        public ControladorContacto()
        {
            this.NivelUsuario = Session.UsuarioEnCurso.NivelUsuario;
        }

        public DataTable GetAll(int Lista)
        {
            SqlConnection connection = GetConnection();

            connection.Open();

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM ListaContactos" +
                            "INNER JOIN DesgloseContactos On DesgloseContactos.ListaContacto = ListaContactos.IdListaContactos " +
                            "INNER JOIN Contactos On Contactos.IdContacto = DescloseContactos.Contacto " +
                            "INNER JOIN Persona On Contactos.Persona = Persona.IdPersona" +
                            "WHERE ListaContactos = @IdLista";
            cmd.Parameters.AddWithValue("@IdLista", Lista);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            
            connection.Close();
            connection.Dispose();
            return dt;
        }

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
                string insertContacto = "INSERT INTO Persona VALUES(" +
                    "@Nombre," +
                    "@ApellidoPaterno," +
                    "@ApellidoMaterno," +
                    "@Telefono," +
                    "@CorreoElectronico," +
                    "@Calle," +
                    "@Numero," +
                    "@Colonia" +
                    ")" + Environment.NewLine +
                    "SELECT SCOPE_IDENTITY()";

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
                    "SELECT SCOPE_IDENTITY()";

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
            string insertContacto = "INSERT INTO Persona VALUES(" +
                "@Nombre," +
                "@ApellidoPaterno," +
                "@ApellidoMaterno," +
                "@Telefono," +
                "@CorreoElectronico," +
                "@Calle," +
                "@Numero," +
                "@Colonia" +
                ")" + Environment.NewLine +
                "SELECT SCOPE_IDENTITY()";

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
                "SELECT SCOPE_IDENTITY()";

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
    }
}
