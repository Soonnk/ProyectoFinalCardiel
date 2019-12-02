using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Modelo
{
    public class ListaContactos : List<Contacto>
    {
        public int IdListaContactos { get; set; }
    }
}
