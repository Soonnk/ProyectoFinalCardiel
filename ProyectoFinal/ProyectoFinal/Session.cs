using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    /// <summary>
    /// Clase con miembros estáticos publicos utilizados de forma global por el sistema
    /// <para>NO SE DEBE DECLARAR NADA NO ESTÁTICO EN ESTA CLASE</para>
    /// </summary>
    class Session
    {
        public static Modelo.Usuarios.Usuario UsuarioEnCurso { get; set; }
    }
}
