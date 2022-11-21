using LibConexionBD;
using System;

namespace LogicaNegocio.ClasesMantenimiento
{
    public class DatosDepartamento
    {

        private static string mensaje;
        private static ConexionBD conexion = new ConexionBD("Parametros.xml");
        public static string Mensaje { get { return mensaje; } }

        //metodo consultar un  deparatamentos
        public static Departamento ConsultarDepartamento(int idDto)
        {
            if (!conexion.AbrirConexion())
            {
                mensaje = conexion.Error;
                conexion.CerrarConexion();
                return null;
            }
            conexion.SQL = "SELECT * FROM Departamento WHERE IDDepartamento=" + idDto;
            conexion.LlenarDataSet(false);
            if (conexion.Ds.Tables[0].Rows.Count == 0)
            {
                mensaje = "El registro consultado no existe";
                conexion.CerrarConexion();
                return null;

            }
            Departamento dto = new Departamento();
            dto.IDDepartamento = Convert.ToInt32(conexion.Ds.Tables[0].Rows[0].ItemArray[0].ToString());
            dto.Descripcion = conexion.Ds.Tables[0].Rows[0].ItemArray[1].ToString();
            mensaje = "Registro consultado correctamente";
            conexion.CerrarConexion();
            return dto;
        }

        //metodo para crear un  nuevo departamento

        public static bool NuevoDepartamento(Departamento dto)
        {
            if (!conexion.AbrirConexion())
            {
                mensaje = conexion.Error;
                conexion.CerrarConexion();
                return false;
            }
            conexion.SQL = "INSERT INTO Departamento (Descripcion) VALUES('" + dto.Descripcion + "')";
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
        //método para actualizar u depto
        public static bool ActuliazarDepartamento(Departamento dto)
        {
            if (!conexion.AbrirConexion())
            {
                mensaje = conexion.Error;
                conexion.CerrarConexion();
                return false;
            }
            conexion.SQL = "UPDATE Departamento SET Descripcion='' WHERE IDDepartamento='" + dto.Descripcion + "'" + dto.IDDepartamento + "";
            if (!conexion.EjecutarSentencia(false))
            {
                mensaje = conexion.Error;
                conexion.CerrarConexion();
                return false;
            }
            mensaje = "Registro actualizado correctamente..!";
            conexion.CerrarConexion();
            return true;

        }

        //método eliminar departamento
        public static bool EliminarDto(int idDepartamento)
        {
            if (!conexion.AbrirConexion())
            {
                mensaje = conexion.Error;
                conexion.CerrarConexion();
                return false;
            }
            conexion.SQL = "DELETE FROM Departamento WHERE IDDepartamento=" + idDepartamento;
            if (!conexion.EjecutarSentencia(false))
            {
                mensaje = conexion.Error;
                conexion.CerrarConexion();
                return false;
            }
            mensaje = "Departamento eliminado";
            conexion.CerrarConexion();
            return true;
        }

    }
}
