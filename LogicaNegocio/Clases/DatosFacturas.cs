using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibConexionBD;
namespace LogicaNegocio.Clases
{
  public class DatosFacturas
    {
      private static string mensaje;
      private static ConexionBD conexion = new ConexionBD("Parametros.xml");
      public static string Mensaje { get {return mensaje; } }
      //método para consultar un registro de facturas
      public static Factura ConsultarFactura(int IDLinea) {
          if (!conexion.AbrirConexion())
          {
              mensaje = conexion.Error;
              conexion.CerrarConexion();
              return null;
          }
         //ejecuto la sencencia
          conexion.SQL = "SELECT * FROM DetalleFactura WHERE IDLinea="+IDLinea;
          conexion.LlenarDataSet(false);
          if (conexion.Ds.Tables[0].Rows.Count==0)
          {
              mensaje = "El registro consultado no existe..!!";
              conexion.CerrarConexion();
              return null;
          }
          Factura factura = new Factura();
          factura.IDFactura = Convert.ToInt32(conexion.Ds.Tables[0].Rows[0].ItemArray[0].ToString());
          factura.IDLinea=Convert.ToInt32(conexion.Ds.Tables[0].Rows[0].ItemArray[1].ToString());
          factura.IDProducto=Convert.ToInt32(conexion.Ds.Tables[0].Rows[0].ItemArray[2].ToString());
          factura.Descripcion=conexion.Ds.Tables[0].Rows[0].ItemArray[3].ToString();
          factura.Precio=Convert.ToDecimal(conexion.Ds.Tables[0].Rows[0].ItemArray[4].ToString());
          factura.Cantidad=Convert.ToInt32(conexion.Ds.Tables[0].Rows[0].ItemArray[5].ToString());
          mensaje="El registro se encontro correctamente..!";
          conexion.CerrarConexion();
          return factura;
      }
      //metodo para crear nueva factura
      public static bool NuevoFactura(Factura factura) {
          if (!conexion.AbrirConexion())
          {
              mensaje = conexion.Error;
              conexion.CerrarConexion();
              return false;
          }
          conexion.SQL = "INSERT INTO DetalleFactura "
              + " (IDFactura,IDProducto,Descripcion,Precio,Cantidad)"
              + " VALUES (" + factura.IDFactura
              + "," + factura.IDProducto
              + ",'" + factura.Descripcion
              + "'," + factura.Precio
              + "," + factura.Cantidad + ")";
          if (!conexion.EjecutarSentencia(false))
          {
              mensaje = conexion.Error;
              conexion.CerrarConexion();
              return false;
          }
          mensaje = "Factura creada correctamente.!!";
          conexion.CerrarConexion();
          return true;
      }
      //metod para actualizar una factura
      public static bool ActualizarFactura(Factura factura) {
          if (!conexion.AbrirConexion())
          {
              mensaje=conexion.Error;
              conexion.CerrarConexion();
              return false;
          }
          conexion.SQL = "UPDATE DetalleFactura "
              + " SET IDFactura="+factura.IDFactura+", "
              + "IDProducto="+factura.IDProducto+","
              + " Descripcion='"+factura.Descripcion+"', "
              + "Precio="+factura.Precio+","
              + "Cantidad="+factura.Cantidad+" "
              + "WHERE IDLinea="+factura.IDLinea+"";
          if (!conexion.EjecutarSentencia(false))
          {
              mensaje = conexion.Error;
              conexion.CerrarConexion();
              return false;
              
          }
          mensaje = "factura actualizada correctamente.!";
          conexion.CerrarConexion();
          return true;
      }
      //metodo para eliminar una factura
      public static bool EliminarFactura(int IDLinea) {
          if (!conexion.AbrirConexion())
          {
              mensaje = conexion.Error;
              conexion.CerrarConexion();
              return false;
          }
          conexion.SQL = "DELETE FROM DetalleFactura WHERE IDLinea="+IDLinea;
          if (!conexion.EjecutarSentencia(false))
          {
              mensaje = conexion.Error;
              conexion.CerrarConexion();
              return false;
          }
          mensaje = "Factura eliminada correctamente..!!";
          conexion.CerrarConexion();
          return true;
      }
    }
}
