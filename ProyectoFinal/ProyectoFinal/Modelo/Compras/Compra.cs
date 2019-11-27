using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Modelo
{
    class Compra
    {
        public int IdCompra { get; set; }
        public Proveedor Proveedor { get; set; }
        public DateTime FechaOrden { get; set; }
        public DateTime FechaRecepcion { get; set; }
        //TODO Reemplazar los Object por su correspondiente clase especializada
        public Object CompradoPor { get; set; }
    }
}
