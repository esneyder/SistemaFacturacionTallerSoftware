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
using LogicaNegocio.ClasesMantenimiento;

namespace Sistema_FacturacionTallerSoftware.Mantenimiento
{
    public partial class frmIva : Form
    {
        LlenarGrids llenarGriv = new LlenarGrids("Parametros.xml");
        public frmIva()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmIva_Load(object sender, EventArgs e)
        {
            llenarGriv.SQL = "SELECT * FROM IVA";
            llenarGriv.LlenarGridWindows(dgvIvas);
        }
        //método para limpiar campos
        private void Limpiar() {
            txtIDIVA.Text = "";
            txtDescripcion.Text = "";
            txtTarifa.Text = "";
        
        }
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (txtIDIVA.Text == "")
            {
                MessageBox.Show("Debe ingresar un id de iva ","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtIDIVA.Focus();
                return;
            }
            IVA iva =DatosIva.ConsultarIva(Convert.ToInt32(txtIDIVA.Text));
            
            txtDescripcion.Text = iva.Descripcion.ToString();
            txtTarifa.Text = iva.Tarifa.ToString();
            MessageBox.Show(DatosIva.Mensaje);
          
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (txtDescripcion.Text == "")
            {    MessageBox.Show("Debe ingresar un descripción de iva");
            txtDescripcion.Focus();
            return;                
            }
            if (txtTarifa.Text=="")
            {
                MessageBox.Show("Debe ingresar un tarifa para el iva");
                txtTarifa.Focus();
                return;
            }
            //valido que sea un numerico
            decimal tarifa;
            try
            {
                tarifa = Convert.ToDecimal(txtTarifa.Text);
            }
            catch (Exception)
            { tarifa = 0; }
            if (tarifa==0)
            {
                MessageBox.Show("Debe ingresar un valor númerico para la tarifa");
            }
            IVA iva = new IVA();
            iva.Descripcion = txtDescripcion.Text;
            iva.Tarifa =Convert.ToDecimal( txtTarifa.Text);
            DatosIva.NuevoIva(iva);
            MessageBox.Show(DatosIva.Mensaje);
            llenarGriv.LlenarGridWindows(dgvIvas);
            Limpiar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtIDIVA.Text=="")
            {
                MessageBox.Show("Debe ingresar un id a modificar.!");
                txtIDIVA.Focus();
                return;
            }
            IVA iva = new IVA();
            iva.IDIva =Convert.ToInt32( txtIDIVA.Text);
            iva.Descripcion = txtDescripcion.Text;
            iva.Tarifa = Convert.ToDecimal(txtTarifa.Text);
            DatosIva.ActualizarIva(iva);
            MessageBox.Show(DatosIva.Mensaje);
            llenarGriv.LlenarGridWindows(dgvIvas);
            Limpiar();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtIDIVA.Text=="")
            {
                MessageBox.Show("Debe ingresar un id iva a eliminar","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtIDIVA.Focus();
                return;
            }
            DialogResult dr = MessageBox.Show("Seguro decea eliminar el registro","Confirmación",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dr==DialogResult.No)
            {
                txtIDIVA.Focus();
                txtIDIVA.Text = "";
                return;
            }
            DatosIva.EliminarIva(Convert.ToInt32(txtIDIVA.Text));
            MessageBox.Show(DatosIva.Mensaje);
            txtIDIVA.Focus();
            llenarGriv.LlenarGridWindows(dgvIvas);
            Limpiar();

        }
    }
}
