using LogicaNegocio.Clases;
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

namespace Sistema_FacturacionTallerSoftware.Formularios
{
    public partial class frmFacturaTemporal : Form
    {
        LlenarGrids llenarGied = new LlenarGrids("Parametros.xml");
        LlenarCombos llenarCombo = new LlenarCombos("Parametros.xml");
        public frmFacturaTemporal()
        {
            InitializeComponent();
        }
        private void Limpiar()
        {
            txtIdFactura.Text = "";
            cbProducto.SelectedIndex = -1;
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            txtCantidad.Text = "";

        }
        private void tbConsultar_Click(object sender, EventArgs e)
        {
            if (txtIdFactura.Text == "")
            {
                MessageBox.Show("Debe ingresar un id de factura a consultar..!",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIdFactura.Focus();
                return;
            }
            FacturaTemp factemp = DatosFacturasTemp.ConsultarFacturaTemp(Convert.ToInt32(txtIdFactura.Text));
            txtIdFactura.Text = factemp.IDFactura.ToString();
            cbProducto.SelectedValue = factemp.IDProducto.ToString();
            txtDescripcion.Text = factemp.Descripcion.ToString();
            txtPrecio.Text = factemp.Cantidad.ToString();
            txtCantidad.Text = factemp.Cantidad.ToString();
            MessageBox.Show(DatosFacturasTemp.Mensaje);
            txtIdFactura.Focus();

        }

        private void frmFacturaTemporal_Load(object sender, EventArgs e)
        {
            //lleno la griv
            llenarGied.SQL = "SELECT * FROM DetalleFacturaTmp";
            llenarGied.LlenarGridWindows(dgfacturaTemp);

            //llenar combo
            llenarCombo.SQL = "SELECT IDProducto,Descripcion FROM Producto ORDER BY 2";
            llenarCombo.CampoID = "IDProducto";
            llenarCombo.CampoTexto = "Descripcion";
            llenarCombo.LlenarComboWindows(cbProducto);
            cbProducto.SelectedValue = -1;
        }

        private void tbNuevo_Click(object sender, EventArgs e)
        {
            if (cbProducto.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un producto..!! ");
                cbProducto.Focus();
                return;
            }
            if (txtDescripcion.Text == "")
            {
                MessageBox.Show("Debe ingresar una descripción.!.");
                txtDescripcion.Focus();
                return;
            }
            if (txtPrecio.Text == "")
            {
                MessageBox.Show("Debe ingresar un precio..!!");
                txtPrecio.Focus();
                return;
            }
            decimal precio;
            try
            {
                precio = Convert.ToDecimal(txtPrecio.Text);
            }
            catch (Exception)
            { precio = 0; }
            if (precio == 0)
            {
                MessageBox.Show("Debe ingresar un valor $ para el precio.!!");
            }
            if (txtCantidad.Text == "")
            {
                MessageBox.Show("Debe ingresar una cantida.!!");
                txtCantidad.Focus();
                return;
            }
            FacturaTemp ftmp = new FacturaTemp();
            ftmp.IDProducto = Convert.ToInt32(cbProducto.SelectedValue);
            ftmp.Descripcion = txtDescripcion.Text;
            ftmp.Precio = Convert.ToDecimal(txtPrecio.Text);
            ftmp.Cantidad = Convert.ToInt32(txtCantidad.Text);
            DatosFacturasTemp.NuevaFacturaTemp(ftmp);
            MessageBox.Show(DatosFacturasTemp.Mensaje);
            llenarGied.LlenarGridWindows(dgfacturaTemp);
            txtIdFactura.Focus();
            Limpiar();
        }

        private void tbActualizar_Click(object sender, EventArgs e)
        {
            if (cbProducto.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un producto..!! ");
                cbProducto.Focus();
                return;
            }
            if (txtDescripcion.Text == "")
            {
                MessageBox.Show("Debe ingresar una descripción.!.");
                txtDescripcion.Focus();
                return;
            }
            if (txtPrecio.Text == "")
            {
                MessageBox.Show("Debe ingresar un precio..!!");
                txtPrecio.Focus();
                return;
            }
            decimal precio;
            try
            {
                precio = Convert.ToDecimal(txtPrecio.Text);
            }
            catch (Exception)
            { precio = 0; }
            if (precio == 0)
            {
                MessageBox.Show("Debe ingresar un valor $ para el precio.!!");
            }
            if (txtCantidad.Text == "")
            {
                MessageBox.Show("Debe ingresar una cantida.!!");
                txtCantidad.Focus();
                return;
            }
            FacturaTemp ftmp = new FacturaTemp();
            ftmp.IDProducto = Convert.ToInt32(cbProducto.SelectedValue);
            ftmp.Descripcion = txtDescripcion.Text;
            ftmp.Precio = Convert.ToDecimal(txtPrecio.Text);
            ftmp.Cantidad = Convert.ToInt32(txtCantidad.Text);
            DatosFacturasTemp.ActualizarFacturaTmp(ftmp);
            MessageBox.Show(DatosFacturasTemp.Mensaje);
            llenarGied.LlenarGridWindows(dgfacturaTemp);
            txtIdFactura.Focus();
            Limpiar();
        }

        private void tbEliminar_Click(object sender, EventArgs e)
        {
            if (txtIdFactura.Text=="")
            {
                MessageBox.Show("Debe ingresar un id");
            }
            DialogResult dr = MessageBox.Show("Decea eliminar el registro","Confirmación",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dr==DialogResult.No)
            {
                txtIdFactura.Focus();
                txtIdFactura.Text = "";
                return;
            }
            DatosFacturasTemp.elminarFacturaTmp(Convert.ToInt32(txtIdFactura.Text));
            MessageBox.Show(DatosFacturasTemp.Mensaje);
            llenarGied.LlenarGridWindows(dgfacturaTemp);
            txtIdFactura.Focus();
        }

        private void tbLImpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
