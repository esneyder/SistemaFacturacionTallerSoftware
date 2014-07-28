using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibConexionBD;
using LogicaNegocio.Clases;
 
namespace LogicaNegocio
{
    public class DatosUsuarios
    {
        private static string mensaje;
        private static ConexionBD conexion = new ConexionBD("Parametros.xml");
        public static String Mensaje { get { return mensaje; } }

        //metodo que valida el logueo de un usuario
        public static bool ValidarUsuario(string usuario, string clave)
        {
            if (!conexion.AbrirConexion())
            {
                mensaje = conexion.Error;
                conexion.CerrarConexion();
                return false;
            }
            conexion.SQL = "SELECT (1) from Usuario WHERE Usuario='" + usuario + "' AND Clave='" + clave + "'";
            if (!conexion.ConsultarValorUnico(false))
            {
                mensaje = conexion.Error;
                conexion.CerrarConexion();
                return false;
            }
            if (conexion.ValorUnico == null)
            {
                mensaje = "el usuario o contraseña son incorrectos";
                conexion.CerrarConexion();
                return false;
            }
            conexion.CerrarConexion();
            return true;
        }

        //metodo consultar un usuario desde la interfaz
        public static Usuario ConsultarUsuario(string IdUduario)
        {
            if (!conexion.AbrirConexion())
            {
                mensaje = conexion.Error;
                conexion.CerrarConexion();
                return null;
            }
            conexion.SQL = " select * from Usuario where Usuario='" + IdUduario+"'";
            conexion.LlenarDataSet(false);
            if (conexion.Ds.Tables[0].Rows.Count == 0)
            {
                mensaje = "El usuario no existe!!";
                conexion.CerrarConexion();
                return null;
            }
            Usuario usuario = new Usuario();
            usuario.usuario = conexion.Ds.Tables[0].Rows[0].ItemArray[0].ToString();
            usuario.clave = conexion.Ds.Tables[0].Rows[0].ItemArray[1].ToString();
            usuario.nombres = conexion.Ds.Tables[0].Rows[0].ItemArray[2].ToString();
            usuario.apellidos = conexion.Ds.Tables[0].Rows[0].ItemArray[3].ToString();
            usuario.perfil = Convert.ToInt32(conexion.Ds.Tables[0].Rows[0].ItemArray[4]);
            mensaje = "usuario consultado correctamente!";
            conexion.CerrarConexion();
            return usuario;
        }

 
        //metodo para crear un nuevo usuario

        public static bool NuevoUsuario(Usuario usu) {
            if (!conexion.AbrirConexion())
            {
                mensaje = conexion.Error;
                conexion.CerrarConexion();
                return false;
            }
            conexion.SQL = "INSERT INTO Usuario (Usuario,Clave,Nombres,Apellidos,IDPerfil) VALUES('"+usu.usuario+"','"
                +usu.clave+"','"+
                usu.nombres+"','"+
                usu.apellidos+"',"+
                usu.perfil+")";
            if (!conexion.EjecutarSentencia(false))
            {
                mensaje = conexion.Error;
                conexion.CerrarConexion();
                return false;
            }
            mensaje = "Usuario ingresado corrrectamente";
            conexion.CerrarConexion();
            return true;
        }

        public static bool ActualizarUsuario(Usuario usu) {

            if (!conexion.AbrirConexion())
            {
                mensaje = conexion.Error;
                conexion.CerrarConexion();
                return false;
            }
            conexion.SQL = "UPDATE Usuario SET Clave='" + usu.clave
                + "',Nombres='"
                + usu.nombres
                + "',Apellidos='"
                + usu.apellidos
                + "',IDPerfil="
                + usu.perfil + " WHERE Usuario='" +
                usu.usuario + "'";
            if (!conexion.EjecutarSentencia(false))
            {
                mensaje = conexion.Error;
                conexion.CerrarConexion();
                return false;
            }
            mensaje = "Usuario modificado correctamente!";
            conexion.CerrarConexion();
            return true;
        }
    }
}
