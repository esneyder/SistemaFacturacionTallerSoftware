using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibLlenarGrids;
namespace Sistema_FacturacionTallerSoftware.Formularios
{
    public partial class frmReporteFacturas : Form
    {
        LlenarGrids llenargrid = new LlenarGrids("Parametros.xml");
        public frmReporteFacturas()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmReporteFacturas_Load(object sender, EventArgs e)
        {
           
            llenargrid.SQL = "SELECT     dbo.Factura.Fecha, dbo.Factura.IDCliente, dbo.Cliente.Nombres + ' ' + dbo.Cliente.Apellidos AS NombreCompleto, dbo.Factura.IDFactura, dbo.DetalleFactura.IDLinea, dbo.DetalleFactura.IDProducto, "
                +"dbo.DetalleFactura.Descripcion, dbo.DetalleFactura.Precio, dbo.DetalleFactura.Cantidad, dbo.DetalleFactura.Precio * dbo.DetalleFactura.Cantidad AS Valor "
                +"FROM dbo.Cliente INNER JOIN dbo.Factura ON dbo.Cliente.IDCliente = dbo.Factura.IDCliente INNER JOIN "
                +"dbo.DetalleFactura ON dbo.Factura.IDFactura = dbo.DetalleFactura.IDFactura";
            llenargrid.LlenarGridWindows(dgReportes);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            llenargrid.SQL = "SELECT     dbo.Factura.Fecha, dbo.Factura.IDCliente, dbo.Cliente.Nombres + ' ' + dbo.Cliente.Apellidos AS NombreCompleto, dbo.Factura.IDFactura, dbo.DetalleFactura.IDLinea, dbo.DetalleFactura.IDProducto, "
               + "dbo.DetalleFactura.Descripcion, dbo.DetalleFactura.Precio, dbo.DetalleFactura.Cantidad, dbo.DetalleFactura.Precio * dbo.DetalleFactura.Cantidad AS Valor "
               + "FROM dbo.Cliente INNER JOIN dbo.Factura ON dbo.Cliente.IDCliente = dbo.Factura.IDCliente INNER JOIN "
               + "dbo.DetalleFactura ON dbo.Factura.IDFactura = dbo.DetalleFactura.IDFactura WHERE dbo.Cliente.Nombres + ' ' + dbo.Cliente.Apellidos LIKE '"+txtBuscar.Text+"%'";
            llenargrid.LlenarGridWindows(dgReportes);
        }
    }
}
