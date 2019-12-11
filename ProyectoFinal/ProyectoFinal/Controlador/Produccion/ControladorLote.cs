using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProyectoFinal.Modelo.Produccion;

namespace ProyectoFinal.Controlador.Produccion
{
    public class ControladorLote :AccesoDatos.ConexionSQL
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

                cmd.CommandText = "INSERT INTO [Produccion].[LotesProduccion] VALUES (@DetalleAsociado)" + Environment.NewLine +
                                    "SELECT CAST(SCOPE_IDENTITY() as int)";

                cmd.Parameters.AddWithValue("@DetalleAsociado", l.DetalleAsociado.IdDetallePedido);

                int id = (int)cmd.ExecuteScalar();
                l.IdLoteProduccion = id;
                return id;
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

        public void CerrarEtapa(LoteProduccion l, LoteEtapa.EtapasProduccion e)
        {
            SqlConnection connection = null;
            SqlCommand cmd = null;

            try
            {
                connection = GetConnection();
                connection.Open();
                cmd = connection.CreateCommand();

                cmd.CommandText = "UPDATE [Produccion].[LotesEtapas] " +
                    "SET " +
                    "AutorizadoPor = @AutorizadoPor, " +
                    "FechaAutorizacion = GETDATE() " +
                    "WHERE Lote = @Lote AND Etapa = @Etapa";

                cmd.Parameters.AddWithValue("@AutorizadoPor", Session.UsuarioEnCurso.IdUsuario);
                cmd.Parameters.AddWithValue("@Lote", l.IdLoteProduccion);
                cmd.Parameters.AddWithValue("@Etapa", e);

                cmd.ExecuteNonQuery();
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

        public void AgregarEtapa(LoteProduccion l, LoteEtapa.EtapasProduccion e)
        {
            SqlConnection connection = null;
            SqlCommand cmd = null;

            try
            {
                connection = GetConnection();
                connection.Open();
                cmd = connection.CreateCommand();

                cmd.CommandText = "INSERT INTO [Produccion].[LotesEtapas] (OrdenadoPor,FechaOrdenamiento,Lote,Etapa) VALUES (" + Environment.NewLine +
                    "@OrdenadoPor," + Environment.NewLine +
                    "GETDATE()," + Environment.NewLine +
                    "@Lote," + Environment.NewLine +
                    "@Etapa" + Environment.NewLine +
                    ")" + Environment.NewLine +
                    "SELECT CAST(SCOPE_IDENTITY() as int)";

                cmd.Parameters.AddWithValue("@OrdenadoPor", Session.UsuarioEnCurso.IdUsuario);
                cmd.Parameters.AddWithValue("@Lote", l.IdLoteProduccion);
                cmd.Parameters.AddWithValue("@Etapa", (int)e);

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
                        IdLoteProduccion = (int)reader["IdLoteProduccion"]
                    };

                    int idDetalle = (int)reader["DetalleAsociado"];

                    l.DetalleAsociado = new Ventas.ControladorDetallePedido().GetById(idDetalle);
                }
                else {
                    return null;
                }

                reader.Close();

                cmd.CommandText = "SELECT * FROM [Produccion].[LotesEtapas] WHERE Lote = @idLote";
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Modelo.Produccion.LoteEtapa e = new LoteEtapa();
                    e.IdLoteEtapa = (int)reader["IdLoteEtapa"];
                    e.AutorizadoPor = reader["AutorizadoPor"] == DBNull.Value ? null : new Controlador.Usuarios.ControladorUsuario().GetById((int)reader["AutorizadoPor"]);
                    e.OrdenadoPor = reader["OrdenadoPor"] == DBNull.Value ? null : new Controlador.Usuarios.ControladorUsuario().GetById((int)reader["OrdenadoPor"]);
                    e.FechaAutorizacion = reader["FechaAutorizacion"] == DBNull.Value ? DateTime.Today : (DateTime)reader["FechaAutorizacion"];
                    e.FechaOrdemamiento = (DateTime)reader["FechaOrdenamiento"];
                    e.Etapa = (LoteEtapa.EtapasProduccion)reader["Etapa"];
                    e.GastosMateriales = new Controlador.Produccion.ControladorLoteEtapa().CargarGastosMaterial(e);

                    l.Add(e);
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

        public DataTable GetAll() {
            SqlConnection connection = null;
            SqlDataAdapter adapter = null;
            DataTable dt = new DataTable();
            try
            {
                connection = GetConnection();
                string query = "SELECT" + Environment.NewLine +
                    "	d.*," + Environment.NewLine +
                    "	m.Descripcion as BaseName," + Environment.NewLine +
                    "	Design.Descripcion as DesignName," + Environment.NewLine +
                    "	l.*," + Environment.NewLine +
                    "	e1.*," + Environment.NewLine +
                    "	c.Nombre as ClienteOrdenante," + Environment.NewLine +
                    "	pO.Nombre as UsuarioOrdenante," + Environment.NewLine +
                    "	pA.Nombre as UsuarioAutorizante" + Environment.NewLine +
                    "FROM Ventas.DetallesPedido d" + Environment.NewLine +
                    "INNER JOIN Ventas.Pedidos p" + Environment.NewLine +
                    "	on p.IdPedido = d.Pedido" + Environment.NewLine +
                    "INNER JOIN Ventas.Clientes c" + Environment.NewLine +
                    "	on c.IdCliente = p.Cliente" + Environment.NewLine +
                    "LEFT JOIN Produccion.LotesProduccion l" + Environment.NewLine +
                    "	on d.IdDetalle = l.DetalleAsociado" + Environment.NewLine +
                    "INNER JOIN Produccion.Design" + Environment.NewLine +
                    "	on IdDesign = d.Design" + Environment.NewLine +
                    "INNER JOIN Produccion.Materiales m" + Environment.NewLine +
                    "	on m.IdMaterial = d.Base" + Environment.NewLine +
                    "LEFT JOIN  Produccion.LotesEtapas e1" + Environment.NewLine +
                    "	on e1.Lote = l.IdLoteProduccion" + Environment.NewLine +
                    "LEFT JOIN  Produccion.LotesEtapas e2" + Environment.NewLine +
                    "	on (e2.Lote = l.IdLoteProduccion " + Environment.NewLine +
                    "		AND (e1.FechaOrdenamiento < e2.FechaOrdenamiento " + Environment.NewLine +
                    "		OR (e1.FechaOrdenamiento = e2.FechaOrdenamiento AND e1.IdLoteEtapa<e2.IdLoteEtapa)))" + Environment.NewLine +
                    "LEFT JOIN Usuarios.Usuarios uA" + Environment.NewLine +
                    "	on uA.IdUsuario = e1.AutorizadoPor" + Environment.NewLine +
                    "LEFT JOIN Personas pA" + Environment.NewLine +
                    "	on pA.IdPersona = uA.Persona" + Environment.NewLine +
                    "LEFT JOIN Usuarios.Usuarios uO" + Environment.NewLine +
                    "	on uO.IdUsuario = e1.OrdenadoPor" + Environment.NewLine +
                    "LEFT JOIN Personas pO" + Environment.NewLine +
                    "	on pO.IdPersona = uO.Persona" + Environment.NewLine +
                    "WHERE e2.IdLoteEtapa IS NULL";
                adapter = new SqlDataAdapter(query, connection);

                adapter.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                if (connection != null) {
                    connection.Close();
                    connection.Dispose();
                }
            }
        }
    }
}
