using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Modelo.Compras
{
    public class Proveedor
    {
        public int IdProveedor { get; set; }
        public String Nombre { get; set; }
        public String Telefono { get; set; }
        public String CorreoElectronico { get; set; }
        public String Calle { get; set; }
        public String Numero { get; set; }
        public String Colonia { get; set; }
        public bool Estatus { get; set; }
        public ListaContactos Contactos { get; set; }
    }
}
