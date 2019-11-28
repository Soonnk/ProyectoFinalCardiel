using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Modelo
{
    class Pedido
    {
        public int IdPedido { get; set; }
        public Cliente Cliente { get; set; }
        public Usuario Vendedor { get; set; }
        public String FechaPedido { get; set; }
    }
}