using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProyectoFinal.Modelo.Compras;

namespace ProyectoFinal.Controlador.Compras
{
    class ControladorProveedor: AccesoDatos.ConexionSQL
    {
        public ControladorProveedor() {
            this.NivelUsuario = Session.UsuarioEnCurso.NivelUsuario;
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

                string InsertProveedor = "INSERT INTO [Compras].[Proveedores](" +
                    "   Nombre," +
                    "   Telefono," +
                    "   CorreoElectronico," +
                    "   Calle," +
                    "   Numero," +
                    "   Colonia," +
                    ")VALUES(" +
                    "   @Nombre," +
                    "   @Telefono," +
                    "   @CorreoElectronico," +
                    "   @Calle," +
                    "   @Numero," +
                    "   @Colonia" +
                    ")";

                cmd.Parameters.AddWithValue("@Nombre", p.Nombre);
                cmd.Parameters.AddWithValue("@telefono", p.Telefono);
                cmd.Parameters.AddWithValue("@CorreoElectronico", p.CorreoElectronico);
                cmd.Parameters.AddWithValue("@Calle", p.Calle);
                cmd.Parameters.AddWithValue("@Numero", p.Numero);
                cmd.Parameters.AddWithValue("@Colonia", p.Colonia);
            }
            catch (Exception ex)
            {
                if (transaction != null) transaction.Rollback();
                if (connection != null) connection.Close();

                throw ex;
            }
        }
    }
}
