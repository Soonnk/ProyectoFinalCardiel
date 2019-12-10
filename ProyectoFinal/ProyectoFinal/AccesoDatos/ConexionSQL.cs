using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.AccesoDatos
{
    public class ConexionSQL
    {
        /// <summary>
        /// Nombre del servidor a conectar.
        /// </summary>
        private readonly string Server = "(local)";
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
            string conString = @"DATA SOURCE = DESKTOP-PQOR5LH\SQLEXPRESS ; USER ID = " + user.Username + "; PASSWORD = " + user.Password + "; INITIAL CATALOG = " + DBName + "; TIMEOUT = 10;";
            
            SqlConnection conn = new SqlConnection(conString);

            return conn;
        }
        

        public Boolean iniciarSesion(String nomb, String con)
        {
            this.NivelUsuario = Modelo.Usuarios.Usuario.NivelesUsuario.Visor;
            
            SqlConnection connection = null;

            connection = GetConnection();
            connection.Open();

            SqlParameter parNom = new SqlParameter("@nomb", nomb);
            SqlParameter parCon = new SqlParameter("@con", con);

            SqlCommand comando = new SqlCommand("SELECT * FROM [Usuarios].[Usuarios] u INNER JOIN [Personas] p on p.IdPersona = u.Persona " +
                "WHERE Username = @nomb AND Password = @con", connection);
            comando.Parameters.Add(parNom);
            comando.Parameters.Add(parCon);

            SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                Session.UsuarioEnCurso = new Modelo.Usuarios.Usuario()
                {
                    IdUsuario = (int)lector["IdUsuario"],
                    IdPersona = (int)lector["IdPersona"],
                    Nombre = (string)lector["Nombre"],
                    ApellidoMaterno = (string)lector["ApellidoMaterno"],
                    ApellidoPaterno = (string)lector["ApellidoPaterno"],
                    Calle = (string)lector["Calle"],
                    Numero = (string)lector["Numero"],
                    Colonia = (string)lector["Colonia"],
                    CorreoElectronico = (string)lector["CorreoElectronico"],
                    Telefono = (string)lector["Telefono"],
                    Departamento = (Modelo.Usuarios.Usuario.Departamentos)lector["Departamento"],
                    NivelUsuario = (Modelo.Usuarios.Usuario.NivelesUsuario)lector["NivelUsuario"],
                    Estatus = (bool)lector["Estatus"],
                    Username = (string)lector["Username"],
                    Password = (string)lector["Password"]
                };
            }
            lector.Close();
            connection.Close();

            if (Session.UsuarioEnCurso == null)
            {
                return false;
            }
            else
            {
                return true;
            }

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
