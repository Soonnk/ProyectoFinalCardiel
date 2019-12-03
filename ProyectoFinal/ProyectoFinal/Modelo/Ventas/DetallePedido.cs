using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Modelo.Ventas
{
    public class DetallePedido
    {
        public int IdDetallePedido { get; set; }
        public Produccion.Material Base { get; set; }
        public Produccion.Design Design { get; set; }
        public double Cantidad { get; set; }
        public double Precio { get; set; }
    }
}
