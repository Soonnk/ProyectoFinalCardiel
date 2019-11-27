using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Modelo.Produccion
{
    class LotesEtapas
    {
        public int IdLoteEtapa { get; set; }
        public Usuarios OrdenadoPor { get; set; }
        public DateTime FechaOrdemamiento { get; set; }
        public LotesProduccion Lote { get; set; }
        public EtapasProduccion Etapa { get; set; }
        public Usuarios AutorizadoPor { get; set; }
        public DateTime FechaAutorizacion { get; set; }

        public enum EtapasProduccion : int
        {

            IdEtapaProduccion = 1,
            Descripcion = 2
        }
    }
}
