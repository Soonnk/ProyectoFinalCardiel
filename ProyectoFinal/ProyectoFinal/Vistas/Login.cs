using ProyectoFinal.AccesoDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal.Vistas
{
    public partial class Login : Form
    {
        ConexionSQL conexionSQL = new ConexionSQL();
        Modelo.Usuarios.Usuario usu;
        


        public Login()
        {
            InitializeComponent();
        }

       
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtUsuario.Text) && !String.IsNullOrEmpty(txtContrasenia.Text))
            {
                
                try
                {
                    ConexionSQL conn = new ConexionSQL();
                    Boolean res = conn.iniciarSesion(txtUsuario.Text, txtContrasenia.Text);
                    if (res)
                    {
                        this.Hide();
                        MDI menuPrincipal = new MDI();
                        menuPrincipal.Show();
                    }
                    else
                    {
                        MessageBox.Show("Datos incorrectos");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error inesperado"+ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Ingrese el usuario y la contraseña para acceder al sistema"+MessageBoxIcon.Information);
            }
            


        }
    }
}
