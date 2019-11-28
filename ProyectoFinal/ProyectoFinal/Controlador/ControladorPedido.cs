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

namespace ProyectoFinal.Controlador
{
    class ControladorPedido
    {
        SqlConnection conn = new SqlConnection(@"Data Source=CEPEDI-AF2B68DC\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");

        public void insert(Pedido p)
        {
            string sql = "INSERT INTO Ventas.Pedidos(IdPedido, Cliente, Vendedor, FechaPedido) " +
            "VALUES (@IdPedido, @Cliente, @Vendedor, @FechaPedido)";

            SqlCommand comando = new SqlCommand(sql, conn);
            Cliente c = new Cliente();
            Usuario u = new Usuario();
            c.IdCliente = p.Cliente.IdCliente;
            u.IdUsuario = p.Vendedor.IdUsuario;
            comando.Parameters.Add(new SqlParameter("@IdPedido", p.IdPedido));
            comando.Parameters.Add(new SqlParameter("@Cliente", c.IdCliente));
            comando.Parameters.Add(new SqlParameter("@Vendedor", u.IdUsuario));
            comando.Parameters.Add(new SqlParameter("@FechaPedido", p.FechaPedido));

            conn.Open();
            comando.ExecuteNonQuery();
            conn.Close();
        }

        public void update(Pedido p)
        {
            string sql = "UPDATE Ventas.Pedidos SET Cliente = @Cliente, Vendedor = @Vendedor, FechaPedido = @FechaPedido " +
            "WHERE IdPedido = @IdPedido";

            SqlCommand comando = new SqlCommand(sql, conn);
            Cliente c = new Cliente();
            Usuario u = new Usuario();
            c.IdCliente = p.Cliente.IdCliente;
            u.IdUsuario = p.Vendedor.IdUsuario;
            comando.Parameters.Add(new SqlParameter("@IdPedido", p.IdPedido));
            comando.Parameters.Add(new SqlParameter("@Cliente", c.IdCliente));
            comando.Parameters.Add(new SqlParameter("@Vendedor", u.IdUsuario));
            comando.Parameters.Add(new SqlParameter("@FechaPedido", p.FechaPedido));

            conn.Open();
            comando.ExecuteNonQuery();
            conn.Close();
        }

        public DataTable getAll()
        {
            DataTable table = new DataTable();
            table.Columns.Add("IdPedido", typeof(int));
            table.Columns.Add("Cliente", typeof(string));
            table.Columns.Add("Vendedor", typeof(string));
            table.Columns.Add("FechaPedido", typeof(string));

            using (conn)
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM Ventas.Pedidos", conn);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    table.Rows.Add(Convert.ToString(dr["IdPedido"]),
                        Convert.ToString(dr["Cliente"]),
                        Convert.ToString(dr["Vendedor"]),
                        Convert.ToString(dr["FechaPedido"]));
                }
            }

            conn.Close();
            return table;
        }

        public Pedido getById(int id)
        {
            Pedido p = new Pedido();
            using (conn)
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM Ventas.Pedidos WHERE IdPedido = @IdPedido", conn);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    Usuario u = new Usuario();
                    u.IdUsuario = Convert.ToInt32(dr["Vendedor"]);

                    Cliente c = new Cliente();
                    c.IdCliente = Convert.ToInt32(dr["Cliente"]);

                    p.IdPedido = Convert.ToInt32(dr["IdPedido"]);
                    p.Cliente = c;
                    p.Vendedor = u;
                    p.FechaPedido = Convert.ToString(dr["FechaPedido"]);
                }
            }

            conn.Close();
            return p;
        }

        public DataTable getBy(string filtro)
        {
            DataTable table = new DataTable();
            table.Columns.Add("IdPedido", typeof(int));
            table.Columns.Add("Cliente", typeof(string));
            table.Columns.Add("Vendedor", typeof(string));
            table.Columns.Add("FechaPedido", typeof(string));

            using (conn)
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM Ventas.Pedidos WHERE " +
                    "IdPedido = @IdPedido OR " +
                    " Cliente = @Cliente OR" +
                    " Vendedor = @Vendedor OR" +
                    " FechaPedido = @FechaPedido", conn);

                cmd.Parameters.Add(new SqlParameter("@IdPedido", filtro));
                cmd.Parameters.Add(new SqlParameter("@Cliente", filtro));
                cmd.Parameters.Add(new SqlParameter("@Vendedor", filtro));
                cmd.Parameters.Add(new SqlParameter("@FechaPedido", filtro));
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    table.Rows.Add(Convert.ToString(dr["IdPedido"]),
                        Convert.ToString(dr["Cliente"]),
                        Convert.ToString(dr["Vendedor"]),
                        Convert.ToString(dr["FechaPedido"]));
                }
            }

            conn.Close();
            return table;
        }
    }
}
