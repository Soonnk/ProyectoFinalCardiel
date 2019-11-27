using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Modelo
{
    class DetallePedido
    {
        public int IdDetallePedido { get; set; }
        public Base Base { get; set; }  //**************
        public Design Design { get; set; }
        public Pedido Pedido { get; set; }
        public int Cantidad { get; set; }
        public double Precio { get; set; }
    }
}
