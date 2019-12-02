using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Modelo.Compras
{
    public class DetalleCompra
    {
        public int IdDetalleCompra { get; set; }
        public Produccion.Material Material { get; set; }
        public double Cantidad { get; set; }
        public double Costo { get; set; }
    }
}
