using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Modelo.Produccion
{
    class LoteProduccion: List<LoteEtapa>
    {
        public int IdLoteProduccion { get; set; }
        public Ventas.DetallePedido DetalleAsociado { get; set; }
    }
}
