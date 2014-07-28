using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Clases
{
    public class Factura
    {
        public int IDFactura { get; set; }
        public int IDLinea { get; set; }
        public int IDProducto { get; set; }
        public string Descripcion { get; set; }
        public Decimal Precio { get; set; }
        public int Cantidad { get; set; }
    }
}
