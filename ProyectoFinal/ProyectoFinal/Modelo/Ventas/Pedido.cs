using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Modelo.Ventas
{
    class Pedido
    {
        public int IdPedido { get; set; }
        public Cliente Cliente { get; set; }
        public Usuarios.Usuario Vendedor { get; set; }
        public String FechaPedido { get; set; }
        public List<DetallePedido> DetallePedido { get; set; }
    }
}