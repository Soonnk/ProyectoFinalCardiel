using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ProyectoFinal.Modelo;
using System.Data;

using ProyectoFinal.Modelo.Ventas;
using ProyectoFinal.Modelo.Usuarios;

namespace ProyectoFinal.Controlador.Ventas
{
    class ControladorPedido : AccesoDatos.ConexionSQL
    {
        public ControladorPedido()
        {
            this.NivelUsuario = Session.UsuarioEnCurso.NivelUsuario;
        }

        public void insert(Pedido p)
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

                string InsertPedido = "INSERT INTO [Ventas].[Pedidos](IdPedido, Cliente, Vendedor, FechaPedido) " +
            "VALUES (@IdPedido, @Cliente, @Vendedor, @FechaPedido)";

                Cliente c = new Cliente();
                Usuario u = new Usuario();
                c.IdCliente = p.Cliente.IdCliente;
                u.IdUsuario = p.Vendedor.IdUsuario;
                cmd.Parameters.AddWithValue("@IdPedido", p.IdPedido);
                cmd.Parameters.AddWithValue("@Cliente", c.IdCliente);
                cmd.Parameters.AddWithValue("@Vendedor", u.IdUsuario);
                cmd.Parameters.AddWithValue("@FechaPedido", p.FechaPedido);

            }
            catch (Exception ex)
            {
                if (transaction != null) transaction.Rollback();
                if (connection != null) connection.Close();

                throw ex;
            }
        }

        public void update(Pedido p)
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
                string InsertProveedor = "UPDATE [Ventas].[Pedidos] SET Cliente = @Cliente, Vendedor = @Vendedor, FechaPedido = @FechaPedido " +
            "WHERE IdPedido = @IdPedido";
                
                Cliente c = new Cliente();
                Usuario u = new Usuario();
                c.IdCliente = p.Cliente.IdCliente;
                u.IdUsuario = p.Vendedor.IdUsuario;
                cmd.Parameters.AddWithValue("@IdPedido", p.IdPedido);
                cmd.Parameters.AddWithValue("@Cliente", c.IdCliente);
                cmd.Parameters.AddWithValue("@Vendedor", u.IdUsuario);
                cmd.Parameters.AddWithValue("@FechaPedido", p.FechaPedido);
            }
            catch (Exception ex)
            {
                if (transaction != null) transaction.Rollback();
                if (connection != null) connection.Close();

                throw ex;
            }
        }

        public DataTable getAll()
        {
            DataTable table = new DataTable();
            table.Columns.Add("IdPedido", typeof(int));
            table.Columns.Add("Cliente", typeof(string));
            table.Columns.Add("Vendedor", typeof(string));
            table.Columns.Add("FechaPedido", typeof(string));
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
                using (connection)
                {
                    SqlCommand scmd = new SqlCommand("SELECT * FROM [Ventas].[Pedidos]", connection);
                    SqlDataReader dr = scmd.ExecuteReader();

                    if (dr.Read())
                    {
                        table.Rows.Add(Convert.ToString(dr["IdPedido"]),
                            Convert.ToString(dr["Cliente"]),
                            Convert.ToString(dr["Vendedor"]),
                            Convert.ToString(dr["FechaPedido"]));
                    }
                }

            }
            catch (Exception ex)
            {
                if (transaction != null) transaction.Rollback();
                if (connection != null) connection.Close();

                throw ex;
            }
            return table;
        }

        public Pedido getById(int id)
        {
            Pedido p = null;

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

                using (connection)
                {

                    SqlCommand scmd = new SqlCommand("SELECT * FROM [Ventas].[Pedidos] WHERE IdPedido = @IdPedido", connection);
                    SqlDataReader dr = scmd.ExecuteReader();

                    if (dr.Read())
                    {
                        Usuario u = new Usuario();
                        u.IdUsuario = Convert.ToInt32(dr["Vendedor"]);

                        Cliente c = new Cliente();
                        c.IdCliente = Convert.ToInt32(dr["Cliente"]);

                        p = new Pedido();
                        p.IdPedido = Convert.ToInt32(dr["IdPedido"]);
                        p.Cliente = c;
                        p.Vendedor = u;
                        p.FechaPedido = Convert.ToString(dr["FechaPedido"]);
                    }
                }
            }
            catch (Exception ex)
            {
                if (transaction != null) transaction.Rollback();
                if (connection != null) connection.Close();

                throw ex;
            }
            return p;
        }

        public DataTable getBy(string filtro)
        {
            DataTable table = new DataTable();
            table.Columns.Add("IdPedido", typeof(int));
            table.Columns.Add("Cliente", typeof(string));
            table.Columns.Add("Vendedor", typeof(string));
            table.Columns.Add("FechaPedido", typeof(string));
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
                using (connection)
                {

                    SqlCommand scmd = new SqlCommand("SELECT * FROM [Ventas].[Pedidos] WHERE " +
                        "IdPedido = @IdPedido OR " +
                        " Cliente = @Cliente OR" +
                        " Vendedor = @Vendedor OR" +
                        " FechaPedido = @FechaPedido", connection);

                    scmd.Parameters.Add(new SqlParameter("@IdPedido", filtro));
                    scmd.Parameters.Add(new SqlParameter("@Cliente", filtro));
                    scmd.Parameters.Add(new SqlParameter("@Vendedor", filtro));
                    scmd.Parameters.Add(new SqlParameter("@FechaPedido", filtro));
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        table.Rows.Add(Convert.ToString(dr["IdPedido"]),
                            Convert.ToString(dr["Cliente"]),
                            Convert.ToString(dr["Vendedor"]),
                            Convert.ToString(dr["FechaPedido"]));
                    }
                }

            }
            catch (Exception ex)
            {
                if (transaction != null) transaction.Rollback();
                if (connection != null) connection.Close();

                throw ex;
            }
            return table;
        }
    }
}
