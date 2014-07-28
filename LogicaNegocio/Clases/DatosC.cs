using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibConexionBD;
namespace LogicaNegocio.Clases
{
    public class DatosC
    {
        private static ConexionBD conexion = new ConexionBD("Parametros.xml");
        private static string mensaje;

        public static string Mensaje
        {
            get { return mensaje; }

        }

        // metodo consultar


        public static Cliente ConsultarCliente(string IdCliente)
        {

            if (!conexion.AbrirConexion())
            {
                mensaje = conexion.Error;
                conexion.CerrarConexion();
                return null;
            }
            conexion.SQL = "SELECT * from Cliente WHERE IDCliente='"+IdCliente+"'";
            conexion.LlenarDataSet(false);
            if (conexion.Ds.Tables[0].Rows.Count == 0)
            {
                mensaje = "Cliente no existe";
                conexion.CerrarConexion();
                return null;
            }
            Cliente cliente = new Cliente();
            cliente.IdCliente = conexion.Ds.Tables[0].Rows[0].ItemArray[0].ToString();
            cliente.Nombre = conexion.Ds.Tables[0].Rows[0].ItemArray[1].ToString();
            cliente.Apellido = conexion.Ds.Tables[0].Rows[0].ItemArray[2].ToString();
            cliente.Direccion = conexion.Ds.Tables[0].Rows[0].ItemArray[3].ToString();
            cliente.Telefono = conexion.Ds.Tables[0].Rows[0].ItemArray[4].ToString();
            cliente.Correo = conexion.Ds.Tables[0].Rows[0].ItemArray[5].ToString();
            cliente.fechanacimiento = conexion.Ds.Tables[0].Rows[0].ItemArray[6].ToString();
            cliente.Cupo = Convert.ToInt32(conexion.Ds.Tables[0].Rows[0].ItemArray[7]);
            mensaje = "Cliente consultado";
            conexion.CerrarConexion();
            return cliente;
        }

        ///metodo para crear un nuevo cliente
        public static bool NuevoCliente(Cliente cliente)
        {
            if (!conexion.AbrirConexion())
            {
                mensaje = conexion.Error;
                conexion.CerrarConexion();
                return false;
            }
            conexion.SQL = "INSERT INTO Cliente (IDCliente,Nombres,Apellidos,Direccion,Telefono,Correo,Fechanacimiento,Cupo)"
                + " VALUES('" + cliente.IdCliente + "','" +
                cliente.Nombre + "','" +
                cliente.Apellido +
                "','" + cliente.Direccion +
                "','" + cliente.Telefono + "','"
                + cliente.Correo + "','" +
                cliente.fechanacimiento +
                "'," + cliente.Cupo + ")";
            if (!conexion.EjecutarSentencia(false))
            {
                mensaje = conexion.Error;
                conexion.CerrarConexion();
                return false;
            }
            mensaje = "Cliente creado correctamente!";
            conexion.CerrarConexion();
            return true;
        }

        ///metodo para actuliazar un cliente
        ///
        public static bool ActualizarCliente(Cliente cliente)
        {

            if (!conexion.AbrirConexion())
            {
                mensaje = conexion.Error;
                conexion.CerrarConexion();
                return false;
            }
            conexion.SQL = "UPDATE Cliente SET Nombres='" + cliente.Nombre + "',"
              + "Apellidos='" + cliente.Apellido + "',"
              + "Direccion='" + cliente.Direccion + "',"
              + "Telefono='" + cliente.Telefono + "',"
              + "Correo='" + cliente.Correo + "',"
              + "FechaNacimiento=" + cliente.fechanacimiento + ","
              + "Cupo=" + cliente.Cupo + " "
              + "WHERE IDCliente='" + cliente.IdCliente+"'";
            if (!conexion.EjecutarSentencia(false))
            {
                mensaje = conexion.Error;
                conexion.CerrarConexion();
                return false;
            }
            mensaje = "Cliente actualizado correctamente!";
            return true;
        }
        //metodo para eliminar un cliente existente
        public static bool EliminarCliente(string idCliente)
        {
            if (!conexion.AbrirConexion())
            {
                mensaje = conexion.Error;
                conexion.CerrarConexion();
                return false;
            }
            conexion.SQL = "DELETE FROM Cliente WHERE IDCliente=" + idCliente;
            if (conexion.EjecutarSentencia(false))
            {
                mensaje = conexion.Error;
                conexion.CerrarConexion();
                return false;
            }
            mensaje = "Cliente eliminado..!";
            conexion.CerrarConexion();
            return true;
        }
    }
}
