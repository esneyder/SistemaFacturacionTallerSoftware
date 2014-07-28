using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibConexionBD;

namespace LogicaNegocio.Clases
{
    public class DatosP
    {
        private static ConexionBD conexion = new ConexionBD("Parametros.xml");
        private static string mensaje;
        public static string Mensaje { get { return mensaje; } }
        //metodo para consultar un produto en la base de datos


        public static Producto ConsultarProducto(int IDProducto)
        {

            if (!conexion.AbrirConexion())
            {
                mensaje = conexion.Error;
                conexion.CerrarConexion();
                return null;
            }
            conexion.SQL = "SELECT * FROM Producto WHERE IDProducto='" + IDProducto + "'";
            conexion.LlenarDataSet(false);
            if (conexion.Ds.Tables[0].Rows.Count == 0)
            {
                mensaje = "Producto no existe";
                conexion.CerrarConexion();
                return null;
            }
            Producto producto = new Producto();
            producto.IDProducto = Convert.ToInt32(conexion.Ds.Tables[0].Rows[0].ItemArray[0]);
            producto.Descripcion = conexion.Ds.Tables[0].Rows[0].ItemArray[1].ToString();
            producto.Precio = Convert.ToDecimal(conexion.Ds.Tables[0].Rows[0].ItemArray[2].ToString());
            producto.Stock = Convert.ToInt32(conexion.Ds.Tables[0].Rows[0].ItemArray[3].ToString());
            producto.Notas = conexion.Ds.Tables[0].Rows[0].ItemArray[4].ToString();
            producto.IDIva = Convert.ToInt32(conexion.Ds.Tables[0].Rows[0].ItemArray[5].ToString());
            producto.IDDepartamento = Convert.ToInt32(conexion.Ds.Tables[0].Rows[0].ItemArray[6].ToString());
            mensaje = "Producto consultado.!";
            conexion.CerrarConexion();
            return producto;
        }


        ///metodo para crear un nuevo producto
        public static bool NuevoProducto(Producto producto)
        {
            if (!conexion.AbrirConexion())
            {
                mensaje = conexion.Error;
                conexion.CerrarConexion();
                return false;
            }
            conexion.SQL = "INSERT INTO Producto (Descripcion,Precio," +
              "Stock,Notas,IDIVA,IDDepartamento)" +
              "VALUES ('" + producto.Descripcion + "',"
              + producto.Precio + ","
              + producto.Stock + ",'"
              + producto.Notas + "',"
              + producto.IDIva + "," +
              producto.IDDepartamento + ")";
            if (!conexion.EjecutarSentencia(false))
            {
                mensaje = conexion.Error;
                conexion.CerrarConexion();
                return false;
            }
            mensaje = "Producto ingresado";
            conexion.CerrarConexion();
            return true;
        }

        //   metodo para actualizar un producto
        public static bool ActualizarProducto(Producto producto)
        {
            if (!conexion.AbrirConexion())
            {
                mensaje = conexion.Error;
                conexion.CerrarConexion();
                return false;
            }
            conexion.SQL = "UPDATE Producto SET "
             + "Descripcion='" + producto.Descripcion + "',"
             + " Precio=" + producto.Precio + ","
             + " Stock=" + producto.Stock + ","
             + " Notas='" + producto.Notas + "',"
             + " IDIVA=" + producto.IDIva + ","
             + " IDDepartamento=" + producto.IDDepartamento + " "
             + " WHERE IDProducto=" + producto.IDProducto;
            if (!conexion.EjecutarSentencia(false))
            {
                mensaje = conexion.Error;
                conexion.CerrarConexion();
                return false;
            }
            mensaje = "Producto actualizado exitozamente!";
            conexion.CerrarConexion();
            return true;
        }
        //metodo para eliminar un produxto
        public static bool EliminarProducto(int IDProducto)
        {
            if (!conexion.AbrirConexion())
            {
                mensaje = conexion.Error;
                conexion.CerrarConexion();
                return false;
            }
            conexion.SQL = "DELETE FROM Producto WHERE IDProducto=" + IDProducto;
            if (!conexion.EjecutarSentencia(false))
            {
                mensaje = conexion.Error;
                conexion.CerrarConexion();
                return false;
            }
            mensaje = "Producto eliminado correctamente!.";
            conexion.CerrarConexion();
            return true;
        }

    }

}

