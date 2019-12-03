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
            //TODO Devuleve esto a verificar los permisos del usuario
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
                
                string InsertProveedor = "UPDATE [Compras].[Proveedores] SET " + Environment.NewLine +
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
                cmd = connection.CreateCommand();

                cmd.CommandText = "SELECT * FROM [Compras].[Proveedores] WHERE IdProveedor = @IdProveedor";
                cmd.Parameters.AddWithValue("@IdProveedor", idProveedor);

                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    p = new Proveedor
                    {
                        IdProveedor = reader.GetInt32(0),
                        Nombre = reader.GetString(1),
                        Telefono = reader.GetString(2),
                        CorreoElectronico = reader.GetString(3),
                        Calle = reader.GetString(4),
                        Numero = reader.GetString(5),
                        Colonia = reader.GetString(6),

                        Contactos = new Modelo.ListaContactos
                        {
                            IdListaContactos = reader.GetInt32(7)
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
                            Nombre = (string)row["Nombre"],
                            ApellidoPaterno = (string)row["ApellidoMaterno"],
                            ApellidoMaterno = (string)row["ApellidoMaterno"],
                            Telefono = (string)row["Telefono"],
                            CorreoElectronico = (string)row["CorreoElectronico"],
                            Calle = (string)row["Calle"],
                            Numero = (string)row["Numero"],
                            Colonia = (string)row["Colonia"]
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
