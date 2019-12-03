using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Controlador.Ventas
{
    public class ControladorDetallePedido : AccesoDatos.ConexionSQL
    {
        public ControladorDetallePedido()
        {
            this.NivelUsuario = Session.UsuarioEnCurso.NivelUsuario;
        }

        public Modelo.Ventas.DetallePedido GetById(int Id) {
            SqlConnection connection = null;
            SqlCommand cmd = null;
            SqlDataReader reader = null;
            Modelo.Ventas.DetallePedido d = null;

            try
            {
                connection = GetConnection();
                connection.Open();
                cmd = connection.CreateCommand();

                cmd.CommandText = "SELECT * FROM [Ventas].[DetallePedido] WHERE IdDetalle = @Id";

                cmd.Parameters.AddWithValue("@Id", Id);

                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    d = new Modelo.Ventas.DetallePedido() {
                        IdDetallePedido = Id,
                        Base = new Modelo.Produccion.Material() { IdMaterial = (int)reader["Base"] },
                        Design = new Modelo.Produccion.Design() { IdDesign = (int)reader["Design"] },
                        Cantidad = (double)reader["Cantidad"],
                        Precio = (double)reader["Precio"]
                    };
                }

                return d;
            }
            catch
            {
                throw;
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
