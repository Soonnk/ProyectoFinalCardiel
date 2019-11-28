using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProyectoFinal.Modelo.Compras;

namespace ProyectoFinal.Controlador.Compras
{
    class ControladorProveedor: AccesoDatos.ConexionSQL
    {
        public ControladorProveedor() {
            this.NivelUsuario = Session.UsuarioEnCurso.NivelUsuario;
        }

        public void InsertarProveedor(Proveedor p) {
            SqlConnection connection = null;
            SqlTransaction transaction = null;
            SqlCommand cmd = null;
            try
            {
                connection = GetConnection();
                connection.Open();
                cmd = connection.CreateCommand();
                transaction = connection.BeginTransaction();
                cmd.Transaction = transaction;

                string InsertProveedor = "INSERT INTO [Compras].[Proveedores](" +
                    "   Nombre," +
                    "   Telefono," +
                    "   CorreoElectronico," +
                    "   Calle," +
                    "   Numero," +
                    "   Colonia," +
                    ")VALUES(" +
                    "   @Nombre," +
                    "   @Telefono," +
                    "   @CorreoElectronico," +
                    "   @Calle," +
                    "   @Numero," +
                    "   @Colonia" +
                    ")" +
                    "SELECT SCOPE_IDENTITY()";

                cmd.CommandText = InsertProveedor;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Nombre", p.Nombre);
                cmd.Parameters.AddWithValue("@telefono", p.Telefono);
                cmd.Parameters.AddWithValue("@CorreoElectronico", p.CorreoElectronico);
                cmd.Parameters.AddWithValue("@Calle", p.Calle);
                cmd.Parameters.AddWithValue("@Numero", p.Numero);
                cmd.Parameters.AddWithValue("@Colonia", p.Colonia);

                int IdProveedor = (int)cmd.ExecuteScalar();

                if (p.Contactos != null && p.Contactos.Count > 0) {
                    cmd.CommandText = Utils.InsertListaContactos;
                    int idLista = (int)cmd.ExecuteScalar();

                    foreach(Modelo.Contacto c in p.Contactos){
                        InsertarContacto(c,idLista, cmd);
                    }
                }

                transaction.Commit();
            }
            catch (Exception ex)
            {
                if (transaction != null) transaction.Rollback();
                if (connection != null) connection.Close();

                throw ex;
            }
        }

        private void InsertarContacto( Modelo.Contacto c , int Lista, SqlCommand cmd)
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

        public void UpdateProveedor(Proveedor p)
        {

        }
    }
}
