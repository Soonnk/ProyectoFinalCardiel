using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Controlador.Compras
{
    public class ControladorCompra : AccesoDatos.ConexionSQL
    {
        public ControladorCompra()
        {
            this.NivelUsuario = Session.UsuarioEnCurso.NivelUsuario;
        }

        public int InsertarCompra(Modelo.Compras.Compra c)
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

                cmd.CommandText = "INSERT INTO [Compras].[Compras] VALUES (@Proveedor,GETDATE(),null,@CompradoPor)" + Environment.NewLine +
                    "SELECT CAST(SCOPE_IDENTITY() as int)";

                cmd.Parameters.AddWithValue("@Proveedor", c.Proveedor.IdProveedor);
                cmd.Parameters.AddWithValue("@CompradoPor", c.CompradoPor.IdUsuario);

                var id = cmd.ExecuteScalar();
                c.IdCompra = (int)id;

                foreach (Modelo.Compras.DetalleCompra d in c.DetalleCompras)
                {
                    cmd.CommandText = "INSERT INTO [Compras].[DetalleCompra] VALUES (@Compra,@Material,@Cantidad,@Costo)" + Environment.NewLine +
                        "SELECT CAST(SCOPE_IDENTITY() as int)";

                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@Compra", id);
                    cmd.Parameters.AddWithValue("@Material", d.Material.IdMaterial);
                    cmd.Parameters.AddWithValue("@Cantidad", d.Cantidad);
                    cmd.Parameters.AddWithValue("@Costo", d.Costo);

                    d.IdDetalleCompra = (int) cmd.ExecuteScalar();
                }

                transaction.Commit();

                return (int)id;
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

        /// <summary>
        /// Solo se utilizará para cambiar los datos de fecha recepcion, el resto no tiene sentido cambiarlos. Tengan cuidado con eso
        /// </summary>
        /// <param name="c"></param>
        [Obsolete("SOLO PARA ACTUALIZAR EL ESTATUS DE ENTREGA! Preferentemete no usen esto, no tiene sentido actualizar ya que gastariamos mucho tiempo en la logica detras de esto")]
        public void UpdateCompra(Modelo.Compras.Compra c) {
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

                cmd.CommandText = "UPDATE [Compras].[Compras] SET " +
                    "Proveedor = @Proveedor," +
                    "FechaRecepcion = @FechaRecepcion," +
                    "CompradoPor = @CompradoPor" + Environment.NewLine +
                    "WHERE IdCompra = @IdCompra";

                cmd.Parameters.AddWithValue("@Proveedor", c.Proveedor.IdProveedor);
                cmd.Parameters.AddWithValue("@FechaRecepcion", c.FechaRecepcion);
                cmd.Parameters.AddWithValue("@CompradoPor", c.CompradoPor);
                cmd.Parameters.AddWithValue("@IdCompra", c.IdCompra);

                cmd.ExecuteNonQuery();

                if (c.DetalleCompras != null)
                foreach (Modelo.Compras.DetalleCompra d in c.DetalleCompras)
                {
                    cmd.CommandText = "UPDATE [Compras].[DetalleCompra] SET " +
                        "Material = @Material," +
                        "Cantidad = @Cantidad," +
                        "Costo = @Costo)" + Environment.NewLine +
                        "WHERE IdDetalleCompra = @IdDetalle";

                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@IdDetalleCompra", d.IdDetalleCompra);
                    cmd.Parameters.AddWithValue("@Material", d.Material.IdMaterial);
                    cmd.Parameters.AddWithValue("@Cantidad", d.Cantidad);
                    cmd.Parameters.AddWithValue("@Costo", d.Costo);

                    cmd.ExecuteNonQuery();
                }

                transaction.Commit();
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
            DataTable dt = new DataTable();

            try
            {
                connection = GetConnection();
                connection.Open();
                string query = "SELECT c.*, p.Nombre as NombreProveedor, CONCAT(per.Nombre, ' ', per.ApellidoPaterno) as NombreComprador " +
                    "FROM [Compras].[Compras] c " +
                    "INNER JOIN [Compras].[Proveedores] p On c.Proveedor = p.IdProveedor " +
                    "INNER JOIN [Usuarios].[Usuarios] u On c.CompradoPor = u.IdUsuario " +
                    "INNER JOIN [Personas] per On per.IdPersona = u.Persona";

                adapter = new SqlDataAdapter(query,connection);

                adapter.Fill(dt);

                return dt;
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

        /// <summary>
        /// Obtiene una datatable de los pedidos
        /// </summary>
        /// <param name="filtro">Filtro a buscar (RECUERDA: Debe contener "WHERE ...")</param>
        /// <returns>Datatable con todos los campos de pedido y concatenado al nombre de proveedor y usuario</returns>
        public DataTable GetBy(string filtro)
        {
            SqlConnection connection = null;
            SqlDataAdapter adapter = null;
            DataTable dt = null;

            try
            {
                connection = GetConnection();
                connection.Open();

                string query = "SELECT c.*, p.Nombre as NombreProveedor, CONCAT(per.Nombre, ' ', per.ApellidoPaterno) as NombreComprador " +
                    "FROM [Compras].[Compras] c " +
                    "INNER JOIN [Compras].[Proveedores] p On c.Proveedor = p.IdProveedor " +
                    "INNER JOIN [Usuario].[Usuario] u On c.CompradoPor = u.IdUsuario " +
                    "INNER JOIN [Personas] per On per.IdPersona = u.Persona " + filtro;

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
                if (connection != null)
                {
                    connection.Close();
                    connection.Dispose();
                }
            }
        }

        public Modelo.Compras.Compra GetById(int id)
        {
            SqlConnection connection = null;
            SqlCommand cmd = null;
            SqlDataReader reader = null;
            Modelo.Compras.Compra c = null;

            try
            {
                connection = GetConnection();
                connection.Open();
                cmd = connection.CreateCommand();

                cmd.CommandText = "SELECT c.* " +
                    "FROM [Compras].[Compras] c " +
                    "WHERE c.IdCompra = @Id";

                cmd.Parameters.AddWithValue("@Id", id);

                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    c = new Modelo.Compras.Compra();
                    c.IdCompra = (int)reader["IdCompra"];
                    c.Proveedor = new Controlador.Compras.ControladorProveedor().GetById((int)reader["Proveedor"]);
                    c.FechaOrden = (DateTime)reader["FechaOrden"];
                    c.FechaRecepcion = reader["FechaRecepcion"] != DBNull.Value ? (DateTime)reader["FechaRecepcion"] : DateTime.Today;
                    c.CompradoPor = new Controlador.Usuarios.ControladorUsuario().GetById((int)reader["CompradoPor"]);
                    c.DetalleCompras = new Controlador.Compras.ControladorDetalleCompra().GetByCompra(c.IdCompra);
                }
                
                return c;
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
