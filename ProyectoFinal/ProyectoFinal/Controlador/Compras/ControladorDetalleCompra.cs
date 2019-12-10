using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Controlador.Compras
{
    public class ControladorDetalleCompra :AccesoDatos.ConexionSQL
    {
        public ControladorDetalleCompra()
        {
            this.NivelUsuario = Session.UsuarioEnCurso.NivelUsuario;
        }

        public List<Modelo.Compras.DetalleCompra> GetByCompra(int idCompra)
        {
            SqlConnection connection = null;
            SqlDataReader reader = null;
            SqlCommand cmd = null;
            List<Modelo.Compras.DetalleCompra> lista = new List<Modelo.Compras.DetalleCompra>();

            try
            {
                connection = GetConnection();
                connection.Open();

                cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT * FROM [Compras].[DetalleCompra] WHERE Compra = @Id";
                cmd.Parameters.AddWithValue("@Id", idCompra);

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Modelo.Compras.DetalleCompra d = new Modelo.Compras.DetalleCompra();
                    d.IdDetalleCompra = (int)reader["IdDetalleCompra"];
                    d.Cantidad = (double)(int)reader["Cantidad"];
                    d.Costo = (double)(decimal)reader["Costo"];
                    d.Material = new Produccion.ControladorMaterial().GetById((int)reader["Material"]);
                    lista.Add(d);
                }

                return lista;
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
