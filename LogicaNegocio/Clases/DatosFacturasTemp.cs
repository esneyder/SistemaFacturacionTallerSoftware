using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibConexionBD;
namespace LogicaNegocio.Clases
{
    public class DatosFacturasTemp
    {
        private static string mensaje;
        private static ConexionBD conexion = new ConexionBD("Parametros.xml");
        public static string Mensaje { get { return mensaje; } }
        //metodo para consultar una factura

        public static FacturaTemp ConsultarFacturaTemp(int IDFactura)
        {
            if (!conexion.AbrirConexion())
            {
                mensaje = conexion.Error;
                conexion.CerrarConexion();
                return null;
            }
            conexion.SQL = "SELECT * FROM DetalleFacturaTmp WHERE IDLinea=" + IDFactura;
            conexion.LlenarDataSet(false);
            if (conexion.Ds.Tables[0].Rows.Count == 0)
            {
                mensaje = "El registro consultado no existe:.!!";
                conexion.CerrarConexion();
                return null;
            }
            FacturaTemp ftemp = new FacturaTemp();

            ftemp.IDFactura = Convert.ToInt32(conexion.Ds.Tables[0].Rows[0].ItemArray[0].ToString());
            ftemp.IDProducto = Convert.ToInt32(conexion.Ds.Tables[0].Rows[0].ItemArray[1].ToString());
            ftemp.Descripcion = conexion.Ds.Tables[0].Rows[0].ItemArray[2].ToString();
            ftemp.Precio = Convert.ToDecimal(conexion.Ds.Tables[0].Rows[0].ItemArray[3].ToString());
            ftemp.Cantidad = Convert.ToInt32(conexion.Ds.Tables[0].Rows[0].ItemArray[4].ToString());
            mensaje = "Registro encontrado..!!";
            conexion.CerrarConexion();
            return ftemp;
        }

        //metodo para crear una factura temporal
        public static bool NuevaFacturaTemp(FacturaTemp fTemp)
        {
            if (!conexion.AbrirConexion())
            {
                mensaje = conexion.Error;
                conexion.CerrarConexion();
                return false;
            }
            conexion.SQL = "INSERT INTO DetalleFacturaTmp (IDproducto,Descripcion,Precio,Cantidad) "
                + " VALUES (" + fTemp.IDProducto + ",'"
                + fTemp.Descripcion + "',"
                + fTemp.Precio + ","
                + fTemp.Cantidad + ")";
            if (!conexion.EjecutarSentencia(false))
            {
                mensaje = conexion.Error;
                conexion.CerrarConexion();
                return false;
            }
            mensaje = "Registro ingresado correctamente..!";
            conexion.CerrarConexion();
            return true;
        }

        //método para actualizar una factura temporal
        public static bool ActualizarFacturaTmp(FacturaTemp fTmp)
        {
            if (!conexion.AbrirConexion())
            {
                mensaje = conexion.Error;
                conexion.CerrarConexion();
                return false;
            }
            conexion.SQL = "UPDATE DetalleFacturaTmp SET "
                + " IDProducto=" + fTmp.IDProducto + ","
                + " Descripcion='" + fTmp.Descripcion + "',"
                + " Precio=" + fTmp.Precio + ","
                + "Cantidad=" + fTmp.Cantidad + " "
                + "WHERE IDLinea=" + fTmp.IDFactura;
            if (!conexion.EjecutarSentencia(false))
            {
                mensaje = conexion.Error;
                conexion.CerrarConexion();
                return false;
            }
            mensaje = "Registro acualizado correctamente..!";
            conexion.CerrarConexion();
            return true;
        }
        //método para eliminar un registro de factura temporal
        public static bool elminarFacturaTmp(int idFactura) {
           if (!conexion.AbrirConexion())
           {
               mensaje = conexion.Error;
               conexion.CerrarConexion();
               return false;
           }
           conexion.SQL="DELETE DetalleFacturaTmp WHERE IDLinea="+idFactura;
           if (conexion.EjecutarSentencia(false)){
               mensaje=conexion.Error;
           conexion.CerrarConexion();
           return false;}
           mensaje = "Registro eliminado correctamente...!";
           conexion.CerrarConexion();
           return true;
       
       }
    }
}
