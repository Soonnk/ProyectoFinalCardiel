using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ProyectoFinal.Modelo;
using System.Data;

namespace ProyectoFinal.Controlador
{
    class ControladorPedido:Pedido
    {
        SqlConnection conn = new SqlConnection(@"Data Source=CEPEDI-AF2B68DC\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");

        public void insert(Pedido p)
        {
            string sql = "INSERT INTO Ventas.Pedidos(IdPedido, Cliente, Vendedor, FechaPedido) " +
            "VALUES (@IdPedido, @Cliente, @Vendedor, @FechaPedido)";

            SqlCommand comando = new SqlCommand(sql, conn);
            Cliente c = new Cliente();
            Vendedor v = new Vendedor();
            c.IdCliente = p.Cliente.IdCliente;
            v.IdVendedor = p.Vendedor.IdVendedor;
            comando.Parameters.Add(new SqlParameter("@IdPedido", p.IdPedido));
            comando.Parameters.Add(new SqlParameter("@Cliente", c.IdCliente));
            comando.Parameters.Add(new SqlParameter("@Vendedor", v.IdVendedor));
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
            Vendedor v = new Vendedor();
            c.IdCliente = p.Cliente.IdCliente;
            v.IdVendedor = p.Vendedor.IdVendedor;
            comando.Parameters.Add(new SqlParameter("@IdPedido", p.IdPedido));
            comando.Parameters.Add(new SqlParameter("@Cliente", c.IdCliente));
            comando.Parameters.Add(new SqlParameter("@Cliente", v.IdVendedor));
            comando.Parameters.Add(new SqlParameter("@Cliente", p.FechaPedido));

            conn.Open();
            comando.ExecuteNonQuery();
            conn.Close();
        }

        public DataTable getAll()
        {
            string sql = "SELECT * FROM Ventas.Pedidos";
            DataTable table = new DataTable();

            SqlCommand comando = new SqlCommand(sql, conn);
            Cliente c = new Cliente();
            Vendedor v = new Vendedor();
            c.IdCliente = p.Cliente.IdCliente;
            v.IdVendedor = p.Vendedor.IdVendedor;
            comando.Parameters.Add(new SqlParameter("@IdPedido", p.IdPedido));
            comando.Parameters.Add(new SqlParameter("@Cliente", c.IdCliente));
            comando.Parameters.Add(new SqlParameter("@Cliente", v.IdVendedor));
            comando.Parameters.Add(new SqlParameter("@Cliente", p.FechaPedido));

            conn.Open();
            comando.ExecuteNonQuery();
            conn.Close();
        }

    }
}
