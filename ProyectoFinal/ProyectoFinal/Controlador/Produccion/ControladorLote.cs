using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProyectoFinal.Modelo.Produccion;

namespace ProyectoFinal.Controlador.Produccion
{
    class ControladorLote:AccesoDatos.ConexionSQL
    {
        public ControladorLote()
        {
            this.NivelUsuario = Session.UsuarioEnCurso.NivelUsuario;
        }

        public int InsertarLote(LoteProduccion l)
        {
            SqlConnection connection = null;
            SqlCommand cmd = null;

            try
            {
                connection = GetConnection();
                connection.Open();
                cmd = connection.CreateCommand();

                cmd.CommandText = "INSERT INTO [Produccion].[Lotes] VALUES (@DetalleAsociado)" + Environment.NewLine +
                                    "SELECT SCOPE_IDENTITY()";

                cmd.Parameters.AddWithValue("@DetalleAsociado", l.DetalleAsociado.IdDetallePedido);

                int id = (int)cmd.ExecuteScalar();

                return id;
            }
            catch (Exception ex)
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

        public void AgregarEtapa(LoteProduccion l, LoteEtapa.EtapasProduccion e)
        {
            SqlConnection connection = null;
            SqlCommand cmd = null;

            try
            {
                connection = GetConnection();
                connection.Open();
                cmd = connection.CreateCommand();

                cmd.CommandText = "INSERT INTO [Produccion].[LotesEtapas] (OrdenadoPor,FechaOrdenamiento,Lote,Etapa) VALUES (" +
                    "@OrdenadoPor," +
                    "GETDATE()," +
                    "@Lote," +
                    "@Etapa" +
                    ")" + Environment.NewLine +
                    "SELECT SCOPE_IDENTITY()";

                cmd.Parameters.AddWithValue("@OrdenadoPor", Session.UsuarioEnCurso.IdUsuario);
                cmd.Parameters.AddWithValue("@Lote", l.IdLoteProduccion);
                cmd.Parameters.AddWithValue("@Etapa", e);

                int id = (int)cmd.ExecuteScalar();
                l.Add(new LoteEtapa() { IdLoteEtapa = id, OrdenadoPor = Session.UsuarioEnCurso, Etapa = e });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (connection != null) {
                    connection.Close();
                    connection.Dispose();
                }
            }
        }

        public LoteProduccion GetById(int id)
        {
            SqlConnection connection = null;
            SqlCommand cmd = null;
            SqlDataReader reader = null;
            LoteProduccion l = null;
            try
            {
                connection = GetConnection();
                connection.Open();
                cmd = connection.CreateCommand();

                cmd.CommandText = "SELECT * FROM [Produccion].[LotesProduccion] WHERE idLoteProduccion = @idLote";

                cmd.Parameters.AddWithValue("@idLote", id);

                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    l = new LoteProduccion() {
                        IdLoteProduccion = (int) reader["IdLoteProduccion"]
                    };

                    int idDetalle = (int)reader["DetalleAsociado"];

                    l.DetalleAsociado = new Ventas.ControladorDetallePedido().GetById(idDetalle);


                }

                return l;
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
