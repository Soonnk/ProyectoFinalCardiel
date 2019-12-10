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

                cmd.CommandText = "INSERT INTO [Produccion].[Lotes] VALUES (@DetalleAsociado)" + Environment.NewLine +
                                    "SELECT CAST(SCOPE_IDENTITY() as int)";

                cmd.Parameters.AddWithValue("@DetalleAsociado", l.DetalleAsociado.IdDetallePedido);

                int id = (int)cmd.ExecuteScalar();

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
                    "SELECT CAST(SCOPE_IDENTITY() as int)";

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

        public DataTable GetAll() {
            SqlConnection connection = null;
            SqlDataAdapter adapter = null;
            DataTable dt = new DataTable();
            try
            {
                connection = GetConnection();
                string query = @"SELECT
	d.*,
	m.Descripcion as BaseName,
	Design.Descripcion as DesignName,
	l.*,
	e1.*,
	c.Nombre as ClienteOrdenante,
	pO.Nombre as UsuarioOrdenante,
	pA.Nombre as UsuarioAutorizante
FROM Ventas.DetallesPedido d
INNER JOIN Ventas.Pedidos p
	on p.IdPedido = d.Pedido
INNER JOIN Ventas.Clientes c
	on c.IdCliente = p.Cliente
LEFT JOIN Produccion.LotesProduccion l
	on d.IdDetalle = l.DetalleAsociado
INNER JOIN Produccion.Design
	on IdDesign = d.Design
INNER JOIN Produccion.Materiales m
	on m.IdMaterial = d.Base
LEFT JOIN  Produccion.LotesEtapas e1
	on e1.Lote = l.IdLoteProduccion
LEFT JOIN  Produccion.LotesEtapas e2
	on (e2.Lote = l.IdLoteProduccion 
		AND (e1.FechaOrdenamiento < e2.FechaOrdenamiento 
		OR (e1.FechaOrdenamiento = e2.FechaOrdenamiento AND e1.IdLoteEtapa<e2.IdLoteEtapa)))
LEFT JOIN Usuarios.Usuarios uA
	on uA.IdUsuario = e1.AutorizadoPor
LEFT JOIN Personas pA
	on pA.IdPersona = uA.Persona
LEFT JOIN Usuarios.Usuarios uO
	on uO.IdUsuario = e1.OrdenadoPor
LEFT JOIN Personas pO
	on pO.IdPersona = uO.Persona
WHERE e2.IdLoteEtapa IS NULL";

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
