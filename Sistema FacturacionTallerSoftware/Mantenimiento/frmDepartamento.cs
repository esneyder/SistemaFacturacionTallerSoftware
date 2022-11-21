using System;
using System.Windows.Forms;
using LibLlenarGrids;
using LogicaNegocio.ClasesMantenimiento;

namespace Sistema_FacturacionTallerSoftware.Mantenimiento
{
    public partial class frmDepartamento : Form
    {
        LlenarGrids llenarGrid = new LlenarGrids("Parametros.xml");
        public frmDepartamento()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (txtIdDepartamento.Text == "")
            {
                this.btnModificar.Visible = false;
                this.btnEliminar.Visible = false;
                MessageBox.Show("Debe ingresar un id departamento..!");
                txtIdDepartamento.Focus();
                return;
            }
            Departamento dto = DatosDepartamento.ConsultarDepartamento(Convert.ToInt32(txtIdDepartamento.Text));

            if (dto == null)
            {
                this.btnModificar.Visible = false;
                this.btnEliminar.Visible = false;
                return;
            }

            txtIdDepartamento.Text = dto.IDDepartamento.ToString();
            txtDescripcion.Text = dto.Descripcion.ToString();
            MessageBox.Show(DatosDepartamento.Mensaje);

            btnModificar.Visible = true;
            btnEliminar.Visible = true;
        }

        private void frmDepartamento_Load(object sender, EventArgs e)
        {

            llenarGrid.SQL = "SELECT * FROM Departamento";
            llenarGrid.LlenarGridWindows(dgDepartamento);
            btnModificar.Visible = false;
            btnEliminar.Visible = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (txtDescripcion.Text == "")
            {
                MessageBox.Show("Debe ingresar una descripción de departamento..!!");
                txtDescripcion.Focus();
                return;
            }
            Departamento dto = new Departamento();
            dto.Descripcion = txtDescripcion.Text;
            DatosDepartamento.NuevoDepartamento(dto);
            MessageBox.Show(DatosDepartamento.Mensaje);
            txtDescripcion.Text = "";
            llenarGrid.LlenarGridWindows(dgDepartamento);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtIdDepartamento.Text == "")
            {
                MessageBox.Show("Debe realizar una consulta con el id del departamento..!!");
                txtIdDepartamento.Focus();
                return;
            }
            Departamento dto = new Departamento();
            dto.IDDepartamento = Convert.ToInt32(txtIdDepartamento.Text);
            dto.Descripcion = txtDescripcion.Text;
            DatosDepartamento.ActuliazarDepartamento(dto);
            MessageBox.Show(DatosDepartamento.Mensaje);
            llenarGrid.LlenarGridWindows(dgDepartamento);

            btnModificar.Visible = false;
            btnEliminar.Visible = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtIdDepartamento.Text == "")
            {
                MessageBox.Show("Debe ingresar un id departament.!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtIdDepartamento.Focus();
                return;
            }
            DialogResult dr = MessageBox.Show("Decea eliminar el registro", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                txtIdDepartamento.Focus();
                return;
            }
            DatosDepartamento.EliminarDto(Convert.ToInt32(txtIdDepartamento.Text));
            MessageBox.Show(DatosDepartamento.Mensaje);
            llenarGrid.LlenarGridWindows(dgDepartamento);
            txtIdDepartamento.Focus();
            btnModificar.Visible = false;
            btnEliminar.Visible = false;
        }
    }
}
