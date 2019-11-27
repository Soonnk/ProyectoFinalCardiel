using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Modelo.Produccion
{
    class LotesProduccion
    {
        public int IdLoteProduccion { get; set; }
        public DetallesPedido DetalleAsociado { get; set; }
    }
}
