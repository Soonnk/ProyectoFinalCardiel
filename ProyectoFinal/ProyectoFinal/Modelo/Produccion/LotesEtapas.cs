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
        public Object OrdenadoPor { get; set; }
        public DateTime FechaOrdemamiento { get; set; }
        public LotesProduccion Lote { get; set; }
        public EtapasProduccion Etapa { get; set; }
        public Object AutorizadoPor { get; set; }
        public DateTime FechaAutorizacion { get; set; }

        public enum EtapasProduccion : int
        {
            Corte = 1,
            Depilado = 2,
            Tapado = 3,
            Grabado = 4,
            Enlimpieza = 5,
            Entregado = 6
            
        }
    }
}
