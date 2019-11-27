using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.AccesoDatos
{
    class ConexionSQL
    {
        /// <summary>
        /// Nombre del servidor a conectar.
        /// </summary>
        private readonly string server = "localhost";
        /* 
         * ARE YOU LOST? Usuarios y contraseñas se deben configurar
         * desde la funcion GetDBUser(). Recuerda que cada nivel de
         * usuario tiene su propio usuario en base de datos y si no
         * se establece uno se utiliza uno la clase arrojará un error
         * cuando aun no has autenticado al usuario utiliza el permiso
         * de Visor
        */


        /// <summary>
        /// Devuelve una conexion a SQL Server con los parametos preconfigurados
        /// de la clase <see cref="ConexionSQL"/>
        /// </summary>
        /// <returns>Conexión nueva SIN ABRIR</returns>
        /// <remarks>
        /// El usuario de esta clase será el responsable de abrir y cerrar las
        /// conexiones devueltas. Esta clase solo ayuda a mantener los parametros
        /// de conexion juntos para facilitar el mantenimiento.
        /// </remarks>
        public SqlConnection GetConnection() {
            DBUser user = GetDBUser();
            string conString = "DATA SOURCE = " + server + "; USER ID = " + user.Username + "; PASSWORD = " + user.Password + "; TIMEOUT = 10;";

            SqlConnection conn = new SqlConnection(conString);

            return conn
        }

        #region "mafufadas para el control de Usuarios"
        private bool IsUserLevelSetted = false;
        //TODO Cambiar Referencias al enum de la clase Usuario
        private NivelesUsuario nUsuario = NivelesUsuario.Visor;
        public NivelesUsuario NivelUsuario
        {
            set {
                this.nUsuario = value;
                this.IsUserLevelSetted = true;
            }
        }
        
        private DBUser GetDBUser()
        {
            if (IsUserLevelSetted)
            {
                switch (this.nUsuario){
                    case NivelesUsuario.Administrador:
                        return new DBUser() { Username = "Admin", Password = "Admin" };
                    case NivelesUsuario.Jefe:
                        return new DBUser() { Username = "Jefe", Password = "Jefe" };
                    case NivelesUsuario.Obrero:
                        return new DBUser() { Username = "Obrero", Password = "Obrero" };
                    case NivelesUsuario.Vendedor:
                        return new DBUser() { Username = "Vendedor", Password = "Vendedor" };
                    default:
                        return new DBUser() { Username = "Visor", Password = "Visor" };
                }
            }
            else
            {
                throw new Exception("No se ha establecido el nivel de usuario a acceder");
            }
        }

        //TODO Borrar este enum y utilizar el de Usuario
        public enum NivelesUsuario : int {
            Administrador=1,
            Jefe = 2,
            Obrero = 3,
            Vendedor = 4,
            Visor = 5
        }

        private class DBUser
        {
            public string Username { get; set; }
            public string Password { get; set; }
        }
        #endregion
    }
}
