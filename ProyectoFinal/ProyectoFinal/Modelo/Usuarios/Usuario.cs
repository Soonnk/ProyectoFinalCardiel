using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Modelo.Usuarios
{
    class Usuario:Persona
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public NivelesUsuario NivelUsuario { get; set; }
        

        public enum NivelesUsuario : int
        {
            Administrador = 1,
            Jefe = 2,
            Obrero = 3,
            Vendedor = 4,
            Visor = 5
        }

        public enum Departamento : int
        {
            Administracion = 1,
            Ventas = 2,
            Corte = 3,
            Depilado = 4,
            Tapado = 5,
            Grabado = 6,
            Limpieza = 7
        }
    }
}
