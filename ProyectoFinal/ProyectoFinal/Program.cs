using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Vistas.Login());
            //Application.Run(new Vistas.Compras());

            Session.UsuarioEnCurso = new Modelo.Usuarios.Usuario() { NivelUsuario = Modelo.Usuarios.Usuario.NivelesUsuario.Visor };
        }
    }
}
