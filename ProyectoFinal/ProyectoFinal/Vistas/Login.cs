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
        public Login()
        {
            InitializeComponent();
        }

        public void ingresar(string username, string password)
        {

            try
            {

                SqlCommand cmd = new SqlCommand("SELECT Username, NivelUsuario FROM [Usuarios].[Usuarios] WHERE ");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { }
            

        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
