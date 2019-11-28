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
        public int InsertarLote(LoteProduccion l)
        {
            SqlConnection connection = null;
            SqlCommand cmd = null;

            try
            {
                connection = GetConnection();
                connection.Open();
                cmd = connection.CreateCommand();

                cmd.CommandText = "INSER";
                return 0;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
