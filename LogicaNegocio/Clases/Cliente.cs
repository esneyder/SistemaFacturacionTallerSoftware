using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Clases
{
     public   class Cliente
    {
        public string IdCliente { get; set; }
        public String Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string fechanacimiento { get; set; }
        public int Cupo { get; set; }
    }
}
