using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Modelo.Produccion
{
    public class Design
    {
        public int IdDesign { get; set; }
        public String  Descripcion { get; set; }
        public double Alto { get; set; }
        public double Ancho { get; set; }
        public Byte[] Archivo { get; set; }
    }
}
