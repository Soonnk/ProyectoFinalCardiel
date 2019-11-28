using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Modelo.Ventas
{
    class DetallePedido
    {
        public int IdDetalle { get; set; }
        public Produccion.Material Base { get; set; }
        public Produccion.Design Design { get; set; }
        public int Cantidad { get; set; }
        public double Precio { get; set; }
    }
}
