using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Modelo.Compras
{
    public class Compra
    {
        public int IdCompra { get; set; }
        public Proveedor Proveedor { get; set; }
        public DateTime FechaOrden { get; set; }
        public DateTime FechaRecepcion { get; set; }
        public Usuarios.Usuario CompradoPor { get; set; }
        public List<DetalleCompra> DetalleCompras { get; set; }
    }
}
