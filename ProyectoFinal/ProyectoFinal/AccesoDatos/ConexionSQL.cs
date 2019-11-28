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
        private readonly string Server = "localhost";
        private readonly string DBName = "SGPV";
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
            string conString = "DATA SOURCE = " + Server + "; USER ID = " + user.Username + "; PASSWORD = " + user.Password + "; INITIAL CATALOG = " + DBName + "; TIMEOUT = 10;";

            SqlConnection conn = new SqlConnection(conString);

            return conn;
        }

        #region "mafufadas para el control de Usuarios"
        private bool IsUserLevelSetted = false;
        private Modelo.Usuarios.Usuario.NivelesUsuario nUsuario = Modelo.Usuarios.Usuario.NivelesUsuario.Visor;
        public Modelo.Usuarios.Usuario.NivelesUsuario NivelUsuario
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
                    case Modelo.Usuarios.Usuario.NivelesUsuario.Administrador:
                        return new DBUser() { Username = "Admin", Password = "Admin" };
                    case Modelo.Usuarios.Usuario.NivelesUsuario.Jefe:
                        return new DBUser() { Username = "Jefe", Password = "Jefe" };
                    case Modelo.Usuarios.Usuario.NivelesUsuario.Obrero:
                        return new DBUser() { Username = "Obrero", Password = "Obrero" };
                    case Modelo.Usuarios.Usuario.NivelesUsuario.Vendedor:
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
        
        private class DBUser
        {
            public string Username { get; set; }
            public string Password { get; set; }
        }
        #endregion
    }
}
