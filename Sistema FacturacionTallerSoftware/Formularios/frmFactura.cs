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
using LibLlenarCombos;
using LogicaNegocio.Clases;

namespace Sistema_FacturacionTallerSoftware.Formularios
{
    public partial class frmFactura : Form
    {
        LlenarGrids llenarGrid = new LlenarGrids("Parametros.xml");
        LlenarCombos llenarcombos = new LlenarCombos("Parametros.xml");
        public frmFactura()
        {
            InitializeComponent();
        }
       
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void barraMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void Limpiar() {
            cbFadtura.SelectedIndex = -1;
            txtidFactura.Text = "";
            cbProducto.SelectedIndex = -1;
            txtdescripcion.Text = "";
            txtprecio.Text = "";
            txtcantidad.Text = "";
        
        
        }
        private void frmFactura_Load(object sender, EventArgs e)
        {///lleno la grid
            llenarGrid.SQL = "SELECT dbo.Factura.IDFactura,"
                 + " dbo.DetalleFactura.IDLinea,"
                 + " dbo.Producto.Descripcion,"
                 + " dbo.DetalleFactura.Descripcion"
                 + " AS Factura, dbo.DetalleFactura.Precio,"
                 + " dbo.DetalleFactura.Cantidad "
                 + "FROM dbo.DetalleFactura INNER JOIN "
                 + "dbo.Factura ON dbo.DetalleFactura.IDFactura = dbo.Factura.IDFactura "
                 + " INNER JOIN dbo.Producto "
                 + " ON dbo.DetalleFactura.IDProducto = dbo.Producto.IDProducto";
            llenarGrid.LlenarGridWindows(dgFacturas);
            //lleno el combo IDFctura

            llenarcombos.SQL = "SELECT IDFactura from Factura ORDER BY 1";
            llenarcombos.CampoID = "IDFactura";
            llenarcombos.CampoTexto = "IDFactura";
            llenarcombos.LlenarComboWindows(cbFadtura);
            cbFadtura.SelectedIndex = -1;

            //lleno el combo IDProducto

            llenarcombos.SQL = "SELECT IDProducto,Descripcion FROM Producto ORDER BY 2";
            llenarcombos.CampoID = "IDProducto";
            llenarcombos.CampoTexto = "Descripcion";
            llenarcombos.LlenarComboWindows(cbProducto);
            cbProducto.SelectedIndex = -1;
            tbEliminar.Enabled = false;
        }

        private void cbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbFadtura_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbConsultar_Click(object sender, EventArgs e)
        {
            if (txtidFactura.Text == "")
            {
                MessageBox.Show("Debe ingresar un id de factura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtidFactura.Focus();
                return;
            }
            Factura factura = DatosFacturas.ConsultarFactura(Convert.ToInt32(txtidFactura.Text));
            cbFadtura.SelectedValue =Convert.ToInt32( factura.IDFactura.ToString());
            txtidFactura.Text = factura.IDLinea.ToString();
            cbProducto.SelectedValue =Convert.ToInt32( factura.IDProducto.ToString());
            txtdescripcion.Text = factura.Descripcion.ToString();
            txtprecio.Text = factura.Precio.ToString();
            txtcantidad.Text = factura.Cantidad.ToString();
            MessageBox.Show(DatosFacturas.Mensaje);
            txtidFactura.Focus();
        }

        private void tbLImpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void tbNuevo_Click(object sender, EventArgs e)
        {
            if (cbFadtura.SelectedIndex==-1)
            {
                MessageBox.Show("Debe seleccionar una factura");
                cbFadtura.Focus();
                return;
            }
            if (cbProducto.SelectedIndex==-1)
            {
                MessageBox.Show("Debe seleccionar un producto");
                cbProducto.Focus();
                return;
            }
            if (txtdescripcion.Text=="")
            {
                MessageBox.Show("Debe ingresar una descripción de la factura.!");
                txtdescripcion.Focus();
                return;
            }
            if (txtprecio.Text=="")
            {
                MessageBox.Show("Debe ingresar un  valor para la factura.!");
                txtprecio.Focus();
                return;
            }
            decimal precio;
            try
            {
                precio = Convert.ToDecimal(txtprecio.Text);
            }
            catch (Exception)
            {precio = 0;  }
            if (precio==0)
            {
                MessageBox.Show("Debe ingresar un valor en $ en el precio.!!");
            }
            if (txtcantidad.Text=="")
            {
                MessageBox.Show("Debe  ingresar una cantida.!!");
            }
            int cantidad;
            try
            {
                cantidad = Convert.ToInt32(txtcantidad.Text);
            }
            catch (Exception)
            { cantidad = 0; }
            if (cantidad==0)
            {
                MessageBox.Show("Ingrese un valor en númerico en la cantidad");
            }

            Factura factura = new Factura();

            factura.IDFactura = Convert.ToInt32(cbFadtura.SelectedValue);
            factura.IDProducto = Convert.ToInt32(cbProducto.SelectedValue);
            factura.Descripcion = txtdescripcion.Text;
            factura.Precio = Convert.ToDecimal(txtprecio.Text);
            factura.Cantidad = Convert.ToInt32(txtcantidad.Text);
            DatosFacturas.NuevoFactura(factura);
            MessageBox.Show(DatosFacturas.Mensaje);
            llenarGrid.LlenarGridWindows(dgFacturas);
            txtidFactura.Focus();
            Limpiar();
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            llenarGrid.SQL = "SELECT dbo.Factura.IDFactura,"
                + " dbo.DetalleFactura.IDLinea,"
                + " dbo.Producto.Descripcion,"
                + " dbo.DetalleFactura.Descripcion"
              + " AS Factura, dbo.DetalleFactura.Precio,"
                + " dbo.DetalleFactura.Cantidad "
                + "FROM dbo.DetalleFactura INNER JOIN "
                + "dbo.Factura ON dbo.DetalleFactura.IDFactura = dbo.Factura.IDFactura "
                + " INNER JOIN dbo.Producto "
                + " ON dbo.DetalleFactura.IDProducto = dbo.Producto.IDProducto "
                + " WHERE dbo.DetalleFactura.Descripcion LIKE '" + txtbuscar.Text + "%'";
            llenarGrid.LlenarGridWindows(dgFacturas);
        }

        private void tbActualizar_Click(object sender, EventArgs e)
        {
            if (txtidFactura.Text=="")
            {
                MessageBox.Show("Debe ingresar un id o realizar una consulta para actualizar..!");
                txtidFactura.Focus();
                return;
            }
            Factura factura = new Factura();

            factura.IDFactura = Convert.ToInt32(cbFadtura.SelectedValue);
            factura.IDProducto = Convert.ToInt32(cbProducto.SelectedValue);
            factura.Descripcion = txtdescripcion.Text;
            factura.Precio = Convert.ToDecimal(txtprecio.Text);
            factura.Cantidad = Convert.ToInt32(txtcantidad.Text);
            DatosFacturas.ActualizarFactura(factura);
            MessageBox.Show(DatosFacturas.Mensaje);
            llenarGrid.LlenarGridWindows(dgFacturas);
            txtidFactura.Focus();
            Limpiar();
            
        }

        private void tbEliminar_Click(object sender, EventArgs e)
        {
            if (txtidFactura.Text=="")
            {
                MessageBox.Show("Debe ingresar el id que decea eliminar");
                DialogResult dr = MessageBox.Show("Decea eliminar el registro","Confirmación",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (dr==DialogResult.No)
                {
                    txtidFactura.Focus();
                    return;
                }
                DatosFacturas.EliminarFactura(Convert.ToInt32(txtidFactura.Text));
                MessageBox.Show(DatosFacturas.Mensaje);
                txtidFactura.Focus();
                txtidFactura.Text = "";
                llenarGrid.LlenarGridWindows(dgFacturas);
            }
        }
    }
}
