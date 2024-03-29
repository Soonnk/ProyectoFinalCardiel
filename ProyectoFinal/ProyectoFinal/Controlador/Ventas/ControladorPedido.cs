﻿using System;
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
            SqlCommand cmdPedido = null;
            SqlCommand cmdDetallePedido = null;
            try
            {
                connection = GetConnection();
                connection.Open();
                cmdPedido = connection.CreateCommand();
                cmdDetallePedido = connection.CreateCommand();
                transaction = connection.BeginTransaction();
                cmdPedido.Transaction = transaction;
                cmdDetallePedido.Transaction = transaction;

                string InsertPedido = "INSERT INTO [Ventas].[Pedidos](Cliente, Vendedor, FechaPedido) " +
            "VALUES (@Cliente, @Vendedor, @FechaPedido)" +Environment.NewLine +
            "SELECT CAST(SCOPE_IDENTITY() as int)";

                string InsertDetallePedido = "INSERT INTO [Ventas].[DetallesPedido](Pedido, Base, Design, Cantidad, Precio) " +
            "VALUES (@Pedido, @Base, @Design, @Cantidad, @Precio)";
                
                Cliente c = new Cliente();
                Usuario u = new Usuario();
                c.IdCliente = p.Cliente.IdCliente;
                u.IdUsuario = p.Vendedor.IdUsuario;

                cmdPedido.CommandText = InsertPedido;
                cmdPedido.Parameters.Clear();
                cmdPedido.Parameters.AddWithValue("@Cliente", c.IdCliente);
                cmdPedido.Parameters.AddWithValue("@Vendedor", u.IdUsuario);
                cmdPedido.Parameters.AddWithValue("@FechaPedido", p.FechaPedido);

                Utils.ClearNullParameterValues(cmdPedido.Parameters);
                p.IdPedido = (int)cmdPedido.ExecuteScalar();

                foreach(DetallePedido d in p.DetallePedido)
                {
                    Modelo.Produccion.Material b = new Modelo.Produccion.Material();
                    Modelo.Produccion.Design design = new Modelo.Produccion.Design();

                    b.IdMaterial = d.Base.IdMaterial;
                    design.IdDesign = d.Design.IdDesign;

                    cmdDetallePedido.CommandText = InsertDetallePedido;
                    cmdDetallePedido.Parameters.Clear();
                    cmdDetallePedido.Parameters.AddWithValue("@Pedido", p.IdPedido);
                    cmdDetallePedido.Parameters.AddWithValue("@Base", b.IdMaterial);
                    cmdDetallePedido.Parameters.AddWithValue("@Design", design.IdDesign);
                    cmdDetallePedido.Parameters.AddWithValue("@Cantidad", d.Cantidad);
                    cmdDetallePedido.Parameters.AddWithValue("@Precio", d.Precio);

                    Utils.ClearNullParameterValues(cmdDetallePedido.Parameters);
                    cmdDetallePedido.ExecuteNonQuery();
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
                if (connection != null) connection.Close();
            }
        }

        public void update(Pedido p)
        {
            SqlConnection connection = null;
            SqlTransaction transaction = null;
            SqlCommand cmdPedido = null;
            SqlCommand cmdDetallePedido = null;
            try
            {
                connection = GetConnection();
                connection.Open();
                cmdPedido = connection.CreateCommand();
                cmdDetallePedido = connection.CreateCommand();
                transaction = connection.BeginTransaction();
                cmdPedido.Transaction = transaction;
                cmdDetallePedido.Transaction = transaction;
                string UpdatePedido = "UPDATE [Ventas].[Pedidos] SET " +
                    "Cliente = @Cliente, " +
                    "Vendedor = @Vendedor, " +
                    "FechaPedido = @FechaPedido " +
            "WHERE IdPedido = @IdPedido";

                //string UpdateDetallePedido = "UPDATE [Ventas].[DetallesPedido] SET " +
                //    "Pedido = @Pedido, " +
                //    "Base = @Base, " +
                //    "Design = @Design, " +
                //    "Cantidad = @Cantidad, " +
                //    "Precio = @Precio " +
                //    "WHERE IdDetalle = @IdDetalle ";

                Cliente c = new Cliente();
                Usuario u = new Usuario();
                c.IdCliente = p.Cliente.IdCliente;
                u.IdUsuario = p.Vendedor.IdUsuario;

                cmdPedido.CommandText = UpdatePedido;
                cmdPedido.Parameters.Clear();
                cmdPedido.Parameters.AddWithValue("@IdPedido", p.IdPedido);
                cmdPedido.Parameters.AddWithValue("@Cliente", c.IdCliente);
                cmdPedido.Parameters.AddWithValue("@Vendedor", u.IdUsuario);
                cmdPedido.Parameters.AddWithValue("@FechaPedido", p.FechaPedido);

                //Modelo.Produccion.Material b = new Modelo.Produccion.Material();
                //Modelo.Produccion.Design design = new Modelo.Produccion.Design();

                //b.IdMaterial = d.Base.IdMaterial;
                //design.IdDesign = d.Design.IdDesign;

                //cmdDetallePedido.CommandText = UpdateDetallePedido;
                //cmdDetallePedido.Parameters.Clear();
                //cmdDetallePedido.Parameters.AddWithValue("@IdDetalle", d.IdDetalle);
                //cmdDetallePedido.Parameters.AddWithValue("@Pedido", p.IdPedido);
                //cmdDetallePedido.Parameters.AddWithValue("@Base", b.IdMaterial);
                //cmdDetallePedido.Parameters.AddWithValue("@Design", design.IdDesign);
                //cmdDetallePedido.Parameters.AddWithValue("@Cantidad", d.Cantidad);
                //cmdDetallePedido.Parameters.AddWithValue("@Precio", d.Precio);

                cmdPedido.ExecuteNonQuery();
                //cmdDetallePedido.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                if (transaction != null) transaction.Rollback();
                if (connection != null) connection.Close();

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
                cmd.CommandText = "SELECT p.*, c.Nombre as NombreCliente, CONCAT(per.Nombre, ' ', per.ApellidoPaterno) as NombreVendedor " +
                    "FROM[Ventas].[Pedidos] p " +
                    "INNER JOIN[Ventas].[Clientes] c ON p.Cliente = c.IdCliente " +
                    "INNER JOIN[Usuarios].[Usuarios] u On p.Vendedor = u.IdUsuario " +
                    "INNER JOIN[Personas] per On per.IdPersona = u.Persona;";

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

        public Pedido getById(int idPedido)
        {
            SqlConnection connection = null;
            SqlCommand cmd = null;
            SqlDataReader reader = null;
            Modelo.Ventas.Pedido p = null;
            try
            {
                connection = GetConnection();
                connection.Open();
                cmd = connection.CreateCommand();

                cmd.CommandText = "SELECT * FROM [Ventas].[Pedidos] WHERE IdPedido = @idPedido";
                
                cmd.Parameters.AddWithValue("@idPedido", idPedido);

                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    p = new Pedido();
                    p.IdPedido = (int)reader["IdPedido"];
                    p.Cliente = new Controlador.Ventas.ControladorCliente().GetById((int)reader["Cliente"]);
                    p.Vendedor = new Controlador.Usuarios.ControladorUsuario().GetById((int)reader["Vendedor"]);
                    p.FechaPedido = (DateTime)reader["FechaPedido"];

                    p.DetallePedido = new List<DetallePedido>();

                    reader.Close();
                    cmd.CommandText = "SELECT IdDetalle FROM Ventas.DetallesPedido WHERE Pedido = @Pedido";
                    cmd.Parameters.AddWithValue("@Pedido", p.IdPedido);

                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                        p.DetallePedido.Add(new Controlador.Ventas.ControladorDetallePedido().GetById((int)reader["IdDetalle"]));

                }
                return p;
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

        public DataTable GetBy(string filtro)
        {
            SqlConnection connection = null;
            try
            {
                connection = GetConnection();

                connection.Open();

                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT * FROM [Ventas].[Pedido] p INNER JOIN [Ventas].[DetallesPedido] d ON p.IdPedido = d.Pedido " + filtro;

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
