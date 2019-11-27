using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Modelo
{
    class DetalleCompra
    {
        public int IdDetalleCompra { get; set; }
        public Compra Compra { get; set; }
        //TODO  Reemplaza tipo Object por su correspondiente clase especializada
        public Object Material { get; set; }
        public double Cantidad { get; set; }
        public double Costo { get; set; }
    }
}
