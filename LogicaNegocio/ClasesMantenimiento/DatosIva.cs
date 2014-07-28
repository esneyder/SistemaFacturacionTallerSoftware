using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibConexionBD;
namespace LogicaNegocio.ClasesMantenimiento
{
    public class DatosIva
    {
        private static string mensaje;
        private static ConexionBD conexion = new ConexionBD("Parametros.xml");
        public static string Mensaje { get { return mensaje; } }
        //metodo consultar ivas
        public static IVA ConsultarIva(int iva)
        {

            if (!conexion.AbrirConexion())
            {
                mensaje = conexion.Error;
                conexion.CerrarConexion();
                return null;
            }
            conexion.SQL = "SELECT * FROM IVA WHERE IDIVA=" + iva;
            conexion.LlenarDataSet(false);
            if (conexion.Ds.Tables[0].Rows.Count == 0)
            {
                mensaje = "El registro solicitado no existe..!!";
                conexion.CerrarConexion();
                return null;
            }
            IVA ivas = new IVA();
            ivas.IDIva = Convert.ToInt32(conexion.Ds.Tables[0].Rows[0].ItemArray[0].ToString());
            ivas.Descripcion = conexion.Ds.Tables[0].Rows[0].ItemArray[1].ToString();
            ivas.Tarifa = Convert.ToDecimal(conexion.Ds.Tables[0].Rows[0].ItemArray[2].ToString());
            mensaje = "registro consultado correctamente..!";
            conexion.CerrarConexion();
            return ivas;
        }

        ///método para crear un nuevo iva
        public static bool NuevoIva(IVA iva)
        {
            if (!conexion.AbrirConexion())
            {
                mensaje = conexion.Error;
                conexion.CerrarConexion();
                return false;
            }
            conexion.SQL = "INSERT INTO IVA (Descripcion,Tarifa) VALUES('" + iva.Descripcion + "'," + iva.Tarifa + ")";
            if (!conexion.EjecutarSentencia(false))
            {
                mensaje = conexion.Error;
                conexion.CerrarConexion();
                return false;
            }
            mensaje = "Registro guardado exitozamente..!!";
            conexion.CerrarConexion();
            return true;
        }

        //Método para modificar un registro iva
        public static bool ActualizarIva(IVA iva)
        {
            if (!conexion.AbrirConexion())
            {
                mensaje = conexion.Error;
                conexion.CerrarConexion();
                return false;
            }
            conexion.SQL = "UPDATE IVA SET Descripcion='"
                + iva.Descripcion + "',Tarifa="
                + iva.Tarifa + "" + "WHERE IDIVA=" + iva.IDIva;
            if (!conexion.EjecutarSentencia(false))
            {
                mensaje = conexion.Error;
                conexion.CerrarConexion();
                return false;
            }
            mensaje = "Registro modificado correctamente.!";
            conexion.CerrarConexion();
            return true;
        }

        ///método eliminar registros
        public static bool EliminarIva(int IDIVA)
        {
            if (!conexion.AbrirConexion())
            {
                mensaje = conexion.Error;
                conexion.CerrarConexion();
                return false;
            }
            conexion.SQL = "DELETE FROM IVA WHERE IDIVA="+IDIVA;
            if (!conexion.EjecutarSentencia(false))
            {
                mensaje = conexion.Error;
                conexion.CerrarConexion();
                return false;
            }
            mensaje = "Registro eliminado correctamente";
            conexion.CerrarConexion();
            return true;
        }
    }
}
