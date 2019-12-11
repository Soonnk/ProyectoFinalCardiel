using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Controlador
{
    public class Utils
    {
        /// <summary>
        /// Devuelve la string necesaria para insertar una Lista de contactos (Para que no tengan que aprender a
        /// usar secuencias)
        /// </summary>
        /// <remarks>
        /// Se volvió necesario ya que esa tabla unicamente tiene su Id, como identity no permite insertar y sin
        /// identity caemos en la necesidad de consultar el maximo de una tabla y volver a insertar
        /// </remarks>
        public static readonly string InsertListaContactos = "INSERT INTO ListaContactos VALUES (next value for seq_ListaContactos)" + Environment.NewLine +
            "SELECT Max(IdListaContactos) FROM ListaContactos";

        /// <summary>
        /// Obtiene todos los registros de una tabla
        /// </summary>
        /// <param name="catalog">Nombre de la tabla a consultar</param>
        /// <returns>Todos los campos de la tabla</returns>
        /// <remarks>
        /// Aunque parece tentador, esta tabla no tendra inner joins ni cosas por el estilo.
        /// Esta funcion fue pensada unicamente para devolver los catalogos especificos de usuarios, materiales
        /// , etc...
        /// </remarks>
        public static DataTable GetCatalog(string catalog) {
            AccesoDatos.ConexionSQL conector = null;
            SqlConnection connection = null;
            SqlDataAdapter adapter = null;

            DataTable dt = new DataTable();
            try
            {
                conector = new AccesoDatos.ConexionSQL() { NivelUsuario = Modelo.Usuarios.Usuario.NivelesUsuario.Visor };
                connection = conector.GetConnection();
                connection.Open();

                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT * FROM " + catalog;
                adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);

                return dt;
            }
            catch(Exception ex)
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

        /// <summary>
        /// Reemplaza los parametros null de un <see cref="SqlCommand"/> por <see cref="DBNull.Value"/>
        /// </summary>
        /// <param name="Parameters"></param>
        /// <remarks>
        /// Necesario para que si se envian parametros null SqlServer no devuelva un error de "Esperando parametro"
        /// Llamenlo justo antes de cualquier <see cref="SqlCommand.ExecuteNonQuery"/> o 
        /// <see cref="SqlCommand.ExecuteScalar"/> para que se limpien los campos
        /// </remarks>
        public static void ClearNullParameterValues(IDataParameterCollection Parameters)
        {
            foreach (IDataParameter p in Parameters)
                if (p.Value == null) p.Value = DBNull.Value;
        }


        public static DataTable CargarProductividad() {
            AccesoDatos.ConexionSQL conector = null;
            SqlConnection connection = null;
            SqlDataAdapter adapter = null;

            DataTable dt = new DataTable();
            try
            {
                conector = new AccesoDatos.ConexionSQL() { NivelUsuario = Modelo.Usuarios.Usuario.NivelesUsuario.Visor };
                connection = conector.GetConnection();
                connection.Open();

                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = @"SELECT 
	*
FROM Ventas.Pedidos p
LEFT JOIN Ventas.DetallesPedido d
	on p.IdPedido = d.Pedido
LEFT JOIN Produccion.Materiales m
	on m.IdMaterial = d.Base
LEFT JOIN Produccion.Design de
	on de.IdDesign = d.Design
LEFT JOIN Produccion.LotesProduccion l
	on l.DetalleAsociado = d.IdDetalle
LEFT JOIN Produccion.LotesEtapas e
	on e.Lote = l.IdLoteProduccion
LEFT JOIN Produccion.GastosMaterial g
	on g.LoteEtapa = e.IdLoteEtapa
LEFT JOIN Produccion.c_EtapasProduccion ce
	on ce.IdEtapaProduccion = e.Etapa
LEFT JOIN Produccion.c_TipoGasto cg
	on cg.IdTipoGasto = g.Tipo
LEFT JOIN Produccion.c_TiposMateriales ct
	on ct.IdTipoMaterial = m.Tipo
";
                adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);

                return dt;
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
