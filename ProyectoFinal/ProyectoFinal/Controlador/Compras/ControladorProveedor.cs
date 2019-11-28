using System;
using System.Collections.Generic;
using System.Data;
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
                cmd.CommandText = Utils.InsertListaContactos;
                int idLista = (int)cmd.ExecuteScalar();

                string InsertProveedor = "INSERT INTO [Compras].[Proveedores](" + Environment.NewLine +
                    "   Nombre," + Environment.NewLine +
                    "   Telefono," + Environment.NewLine +
                    "   CorreoElectronico," + Environment.NewLine +
                    "   Calle," + Environment.NewLine +
                    "   Numero," + Environment.NewLine +
                    "   Colonia," + Environment.NewLine +
                    "   ListaContactos" + Environment.NewLine +
                    ")VALUES(" + Environment.NewLine +
                    "   @Nombre," + Environment.NewLine +
                    "   @Telefono," + Environment.NewLine +
                    "   @CorreoElectronico," + Environment.NewLine +
                    "   @Calle," + Environment.NewLine +
                    "   @Numero," + Environment.NewLine +
                    "   @Colonia," + Environment.NewLine +
                    "   @ListaContactos" + Environment.NewLine +
                    ")" + Environment.NewLine +
                    "SELECT SCOPE_IDENTITY()";

                cmd.CommandText = InsertProveedor;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Nombre", p.Nombre);
                cmd.Parameters.AddWithValue("@Telefono", p.Telefono);
                cmd.Parameters.AddWithValue("@CorreoElectronico", p.CorreoElectronico);
                cmd.Parameters.AddWithValue("@Calle", p.Calle);
                cmd.Parameters.AddWithValue("@Numero", p.Numero);
                cmd.Parameters.AddWithValue("@Colonia", p.Colonia);
                cmd.Parameters.AddWithValue("@ListaContactos",idLista);

                int IdProveedor = (int)cmd.ExecuteScalar();


                if (p.Contactos != null && p.Contactos.Count > 0) {

                    foreach(Modelo.Contacto c in p.Contactos){
                        ControladorContacto.InsertarContacto(c,idLista, cmd);
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
        
        public void UpdateProveedor(Proveedor p)
        {
            SqlConnection connection = null;
            SqlCommand cmd = null;
            try
            {
                connection = GetConnection();
                connection.Open();
                cmd = connection.CreateCommand();
                
                string InsertProveedor = "UPDATE Compras.Proveedor SET " + Environment.NewLine +
                    "Nombre = @Nombre, " + Environment.NewLine +
                    "Telefono = @Telefono, " + Environment.NewLine +
                    "CorreoElectronico = @CorreoElectronico, " + Environment.NewLine +
                    "Calle = @Calle, " + Environment.NewLine +
                    "Numero = @Numero, " + Environment.NewLine +
                    "Colonia = @Colonia " + Environment.NewLine +
                    "WHERE IdProveedor = @IdProveedor";

                cmd.CommandText = InsertProveedor;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Nombre", p.Nombre);
                cmd.Parameters.AddWithValue("@Telefono", p.Telefono);
                cmd.Parameters.AddWithValue("@CorreoElectronico", p.CorreoElectronico);
                cmd.Parameters.AddWithValue("@Calle", p.Calle);
                cmd.Parameters.AddWithValue("@Numero", p.Numero);
                cmd.Parameters.AddWithValue("@Colonia", p.Colonia);
                cmd.Parameters.AddWithValue("@IdProveedor", p.IdProveedor);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                if (connection != null) connection.Close();

                throw ex;
            }
        }

        public DataTable GetBy(string filtro)
        {
            SqlConnection connection = null;
            try
            {
                connection = GetConnection();

                connection.Open();

                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT * FROM Proveedores " + filtro;

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
                cmd.CommandText = "SELECT * FROM Proveedores";

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
    }
}
