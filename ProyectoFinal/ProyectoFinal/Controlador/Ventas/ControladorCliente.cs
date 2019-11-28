using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProyectoFinal.Modelo.Ventas;
using static ProyectoFinal.Modelo.Ventas.Cliente;

namespace ProyectoFinal.Controlador.Ventas
{
    class ControladorCliente : AccesoDatos.ConexionSQL
    {
        public ControladorCliente()
        {
            this.NivelUsuario = Session.UsuarioEnCurso.NivelUsuario;
        }

        public void InsertarCliente(Cliente c)
        {
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

                string InsertCliente = "INSERT INTO [Ventas].[Clientes](" + Environment.NewLine +
                    "   Nombre," + Environment.NewLine +
                    "   Telefono," + Environment.NewLine +
                    "   CorreoElectronico," + Environment.NewLine +
                    "   Calle," + Environment.NewLine +
                    "   Numero," + Environment.NewLine +
                    "   Colonia," + Environment.NewLine +
                    "   RegimenFiscal," + Environment.NewLine +
                    "   RFC," + Environment.NewLine +
                    "   ListaContactos" + Environment.NewLine +
                    ")VALUES(" + Environment.NewLine +
                    "   @Nombre," + Environment.NewLine +
                    "   @Telefono," + Environment.NewLine +
                    "   @CorreoElectronico," + Environment.NewLine +
                    "   @Calle," + Environment.NewLine +
                    "   @Numero," + Environment.NewLine +
                    "   @Colonia," + Environment.NewLine +
                    "   @RegimenFiscal," + Environment.NewLine +
                    "   @RFC," + Environment.NewLine +
                    "   @ListaContactos" + Environment.NewLine +
                    ")" + Environment.NewLine +
                    "SELECT SCOPE_IDENTITY()";

                cmd.CommandText = InsertCliente;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Nombre", c.Nombre);
                cmd.Parameters.AddWithValue("@Telefono", c.Telefono);
                cmd.Parameters.AddWithValue("@CorreoElectronico", c.CorreoElectronico);
                cmd.Parameters.AddWithValue("@Calle", c.Calle);
                cmd.Parameters.AddWithValue("@Numero", c.Numero);
                cmd.Parameters.AddWithValue("@Colonia", c.Colonia);
                cmd.Parameters.AddWithValue("@RegimenFiscal", c.RegimenFiscal);
                cmd.Parameters.AddWithValue("@RFC", c.RFC);
                cmd.Parameters.AddWithValue("@ListaContactos", idLista);

                int IdCliente = (int)cmd.ExecuteScalar();


                if (c.ListaContactos != null && c.ListaContactos.Count > 0)
                {

                    foreach (Modelo.Contacto contacto in c.ListaContactos)
                    {
                        ControladorContacto.InsertarContacto(contacto, idLista, cmd);
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

        public void UpdateCliente(Cliente c)
        {
            SqlConnection connection = null;
            SqlCommand cmd = null;
            try
            {
                connection = GetConnection();
                connection.Open();
                cmd = connection.CreateCommand();

                string UpdateCliente = "UPDATE [Ventas].[Clientes] SET " + Environment.NewLine +
                    "Nombre = @Nombre, " + Environment.NewLine +
                    "Telefono = @Telefono, " + Environment.NewLine +
                    "CorreoElectronico = @CorreoElectronico, " + Environment.NewLine +
                    "Calle = @Calle, " + Environment.NewLine +
                    "Numero = @Numero, " + Environment.NewLine +
                    "Colonia = @Colonia " + Environment.NewLine +
                    "RegimenFiscal = @RegimenFiscal " + Environment.NewLine +
                    "RFC = @RFC " + Environment.NewLine +
                    "WHERE IdCliente = @IdCliente";

                cmd.CommandText = UpdateCliente;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Nombre", c.Nombre);
                cmd.Parameters.AddWithValue("@Telefono", c.Telefono);
                cmd.Parameters.AddWithValue("@CorreoElectronico", c.CorreoElectronico);
                cmd.Parameters.AddWithValue("@Calle", c.Calle);
                cmd.Parameters.AddWithValue("@Numero", c.Numero);
                cmd.Parameters.AddWithValue("@Colonia", c.Colonia);
                cmd.Parameters.AddWithValue("@RegimenFiscal", c.RegimenFiscal);
                cmd.Parameters.AddWithValue("@RFC", c.RFC);
                cmd.Parameters.AddWithValue("@IdProveedor", c.IdCliente);

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
                cmd.CommandText = "SELECT * FROM [Ventas].[Clientes] " + filtro;

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

        public DataTable GetAll()
        {
            SqlConnection connection = null;
            try
            {
                connection = GetConnection();

                connection.Open();

                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT * FROM Ventas.Clientes";

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

        public Cliente GetById(int idCliente)
        {
            Cliente c = null;
            SqlConnection connection = null;
            SqlCommand cmd = null;
            SqlDataReader reader = null;

            try
            {
                connection = GetConnection();
                cmd = connection.CreateCommand();

                cmd.CommandText = "SELECT * FROM [Ventas].[Clientes] WHERE IdCliente = @IdCliente";
                cmd.Parameters.AddWithValue("@IdCliente", idCliente);

                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    c = new Cliente();
                    c.IdCliente = reader.GetInt32(0);
                    c.Nombre = reader.GetString(1);
                    c.Telefono = reader.GetString(2);
                    c.CorreoElectronico = reader.GetString(3);
                    c.Calle = reader.GetString(4);
                    c.Numero = reader.GetString(5);
                    c.Colonia = reader.GetString(6);
                    if (reader.GetInt32(7) == 1)
                    {
                        c.RegimenFiscal = RegimenesFiscales.PersonaMoral;
                    } else if (reader.GetInt32(7) == 2)
                    {
                        c.RegimenFiscal = RegimenesFiscales.PersonaFisica;
                    }
                    c.RFC = reader.GetString(8);
                
                    c.ListaContactos = new Modelo.ListaContactos
                    {
                        IdListaContactos = reader.GetInt32(9)
                    };

                    ControladorContacto contContacto = new ControladorContacto();

                    DataTable dt = contContacto.GetAll(c.ListaContactos.IdListaContactos);

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

                        c.ListaContactos.Add(contacto);
                    }
                }
                return c;
            }
            catch (Exception ex)
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
