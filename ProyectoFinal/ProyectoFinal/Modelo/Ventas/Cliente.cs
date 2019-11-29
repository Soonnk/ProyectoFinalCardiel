using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Modelo.Ventas
{
    class Cliente
    {
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string CorreoElectronico { get; set; }
        public string Calle { get; set; }
        public string Numero { get; set; }
        public string Colonia { get; set; }
        public RegimenesFiscales RegimenFiscal { get; set; }
        public string RFC { get; set; }
        public ListaContactos ListaContactos { get; set; }
        
        public enum RegimenesFiscales : int
        {
            PersonaMoral = 1,
            PersonaFisica = 2
        }
    }
}