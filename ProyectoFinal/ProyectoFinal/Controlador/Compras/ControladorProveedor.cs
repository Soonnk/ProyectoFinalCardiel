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
    public class ControladorProveedor : AccesoDatos.ConexionSQL
    {
        public ControladorProveedor() {
            //TODO Reemplaza permisos de usuario aqui
            //this.NivelUsuario = Session.UsuarioEnCurso.NivelUsuario;
            this.NivelUsuario = Modelo.Usuarios.Usuario.NivelesUsuario.Administrador;
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
                    "   Estatus," + Environment.NewLine +
                    "   ListaContactos" + Environment.NewLine +
                    ")VALUES(" + Environment.NewLine +
                    "   @Nombre," + Environment.NewLine +
                    "   @Telefono," + Environment.NewLine +
                    "   @CorreoElectronico," + Environment.NewLine +
                    "   @Calle," + Environment.NewLine +
                    "   @Numero," + Environment.NewLine +
                    "   @Colonia," + Environment.NewLine +
                    "   1," + Environment.NewLine +
                    "   @ListaContactos" + Environment.NewLine +
                    ")" + Environment.NewLine;

                cmd.CommandText = InsertProveedor;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Nombre", p.Nombre);
                cmd.Parameters.AddWithValue("@Telefono", p.Telefono);
                cmd.Parameters.AddWithValue("@CorreoElectronico", p.CorreoElectronico);
                cmd.Parameters.AddWithValue("@Calle", p.Calle);
                cmd.Parameters.AddWithValue("@Numero", p.Numero);
                cmd.Parameters.AddWithValue("@Colonia", p.Colonia);
                cmd.Parameters.AddWithValue("@ListaContactos",idLista);

                cmd.ExecuteNonQuery();


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

                string InsertProveedor = "UPDATE [Compras].[Proveedores] SET " + Environment.NewLine +
                    "Nombre = @Nombre, " + Environment.NewLine +
                    "Telefono = @Telefono, " + Environment.NewLine +
                    "CorreoElectronico = @CorreoElectronico, " + Environment.NewLine +
                    "Calle = @Calle, " + Environment.NewLine +
                    "Numero = @Numero, " + Environment.NewLine +
                    "Colonia = @Colonia " + Environment.NewLine +
                    "WHERE IdProveedor = @IdProveedor";

                cmd.CommandText = InsertProveedor;
                cmd.Parameters.AddWithValue("@Nombre", p.Nombre);
                cmd.Parameters.AddWithValue("@Telefono", p.Telefono);
                cmd.Parameters.AddWithValue("@CorreoElectronico", p.CorreoElectronico);
                cmd.Parameters.AddWithValue("@Calle", p.Calle);
                cmd.Parameters.AddWithValue("@Numero", p.Numero);
                cmd.Parameters.AddWithValue("@Colonia", p.Colonia);
                cmd.Parameters.AddWithValue("@IdProveedor", p.IdProveedor);

                cmd.ExecuteNonQuery();

                if (p.Contactos != null && p.Contactos.Count > 0)
                {

                    foreach (Modelo.Contacto c in  from con in p.Contactos where con.IdContacto == 0 select con)
                    {
                        ControladorContacto.InsertarContacto(c, p.Contactos.IdListaContactos, cmd);
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (connection != null) connection.Close();
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
                cmd.CommandText = "SELECT * FROM [Compras].[Proveedores] " + filtro;

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
                cmd.CommandText = "SELECT * FROM [Compras].[Proveedores]";

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

        public Proveedor GetById(int idProveedor)
        {
            Proveedor p = null;
            SqlConnection connection = null;
            SqlCommand cmd = null;
            SqlDataReader reader = null;

            try
            {
                connection = GetConnection();
                connection.Open();

                cmd = connection.CreateCommand();

                cmd.CommandText = "SELECT * FROM [Compras].[Proveedores] WHERE IdProveedor = @IdProveedor";
                cmd.Parameters.AddWithValue("@IdProveedor", idProveedor);

                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    p = new Proveedor()
                    {
                        IdProveedor = (int)reader["IdProveedor"],
                        Nombre = (string)reader["Nombre"],
                        Telefono = (string)reader["Telefono"],
                        CorreoElectronico = (string)reader["CorreoElectronico"],
                        Calle = (string)reader["Calle"],
                        Numero = (string)reader["Numero"],
                        Colonia = (string)reader["Colonia"],

                        Contactos = new Modelo.ListaContactos
                        {
                            IdListaContactos = (int)reader["ListaContactos"]
                        }
                    };

                    ControladorContacto contContacto = new ControladorContacto();

                    DataTable dt = contContacto.GetAll(p.Contactos.IdListaContactos);

                    foreach (DataRow row in dt.Rows)
                    {
                        Modelo.Contacto contacto = new Modelo.Contacto()
                        {
                            IdContacto = (int)row["IdContacto"],
                            IdPersona = (int)row["IdPersona"],
                            Nombre = row["Nombre"] != DBNull.Value ? (string)row["Nombre"] : null,
                            ApellidoPaterno = row["ApellidoPaterno"] != DBNull.Value ? (string)row["ApellidoPaterno"] : null,
                            ApellidoMaterno = row["ApellidoMaterno"] != DBNull.Value ? (string)row["ApellidoMaterno"] : null,
                            Telefono = row["Telefono"] != DBNull.Value ? (string)row["Telefono"] : null,
                            CorreoElectronico = row["CorreoElectronico"] != DBNull.Value ? (string)row["CorreoElectronico"] : null,
                            Calle = row["Calle"] != DBNull.Value ? (string)row["Calle"] : null,
                            Numero = row["Numero"] != DBNull.Value ? (string)row["Numero"] : null,
                            Colonia = row["Colonia"] != DBNull.Value ? (string)row["Colonia"] : null
                        };

                        p.Contactos.Add(contacto);
                    }
                }
                return p;
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
