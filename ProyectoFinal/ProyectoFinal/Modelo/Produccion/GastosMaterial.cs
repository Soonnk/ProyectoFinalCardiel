using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Modelo.Produccion
{
    class GastosMaterial
    {
        public int IdGastoMaterial { get; set; }
        public Materiales Material { get; set; }
        public LotesEtapas LoteEtapa { get; set; }
        public double Cantidad { get; set; }

        public TiposGasto Tipo { get; set; }

        public String Observacion { get; set; }



        public enum TiposGasto : int {

            Consumo = 1,
            Merma = 2
        }

    }
}
