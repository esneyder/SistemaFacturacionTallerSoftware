using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Clases
{
  public  class Producto
    {
        public int IDProducto { get; set; }
        public string Descripcion { get; set; }
        public Decimal Precio { get; set; }
        public int Stock { get; set; }
        public string Notas { get; set; }
        public int IDIva { get; set; }
        public int IDDepartamento { get; set; }
    }
}
