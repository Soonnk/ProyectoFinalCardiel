using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Controlador
{
    class Utils
    {
        public static readonly string InsertListaContactos = "INSERT INTO ListaContactos VALUES (next value for seq_ListaContactos)" + Environment.NewLine +
            "SELECT Max(IdListaContactos) FROM ListaContactos";
    }
}
