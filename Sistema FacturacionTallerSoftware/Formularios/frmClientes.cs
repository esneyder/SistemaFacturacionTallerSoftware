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

namespace Sistema_FacturacionTallerSoftware.Formularios
{
    public partial class frmClientes : Form
    {
        private LlenarGrids llenarGrid = new LlenarGrids("Parametros.xml");
        public frmClientes()
        {
            InitializeComponent();
        }

        private void tbConsultar_Click(object sender, EventArgs e)
        {
            if (txtIdCliente.Text=="")
            {
                MessageBox.Show("Debe ingresar un Id del cliente que decea consultar!", "Campo vacio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIdCliente.Focus();
                return;
            }

            Cliente cliente = DatosC.ConsultarCliente(txtIdCliente.Text);
            if (cliente == null)
            {
                MessageBox.Show(DatosC.Mensaje);
                txtIdCliente.Focus();
                return;
            }
            txtIdCliente.Text = cliente.IdCliente.ToString();
            txtNombres.Text = cliente.Nombre.ToString();
            txtApellido.Text = cliente.Apellido.ToString();
            txtDireccion.Text = cliente.Direccion.ToString();
            txttelefono.Text = cliente.Telefono.ToString();
            txtEmail.Text = cliente.Correo.ToString();
            txtFecha.Text = cliente.fechanacimiento.ToString();
            txtCupo.Text = cliente.Cupo.ToString();


        }

        private void tbLImpiar_Click(object sender, EventArgs e)
        {

            Limpiar();
        }

        private void Limpiar(){
        txtIdCliente.Text = "";
            txtNombres.Text = "";
            txtApellido.Text = "";
            txtDireccion.Text = "";
            txttelefono.Text = "";
            txtEmail.Text = "";
            txtFecha.Text = "";
            txtCupo.Text = "";
        
        }

        private void tbNuevo_Click(object sender, EventArgs e)
        {
            if (txtIdCliente.Text == "")
            {
                MessageBox.Show("Debe ingresar un id para el cliente");
                txtIdCliente.Focus();
                return;
            }
            if (txtNombres.Text == "")
            {
                MessageBox.Show("Debe ingresar un nombre para el cliente");
                txtNombres.Focus();
                return;
            }
            if (txtApellido.Text == "")
            {
                MessageBox.Show("Debe ingresar un apellido para el cliente");
                txtApellido.Focus();
                return;

            }
            if (txtDireccion.Text == "")
            {
                MessageBox.Show("Debe ingresar una direccón de ubicación o residensia del cliente");
                txtDireccion.Focus();
                return;
            }
            if (txtEmail.Text == "")
            {
                MessageBox.Show("Debe ingresar un email de contacto del cliente");
                txtEmail.Focus();
                return;
            }
            if (txtFecha.Text == "")
            {
                MessageBox.Show("Debe ingresar una fecha de nacimiento del cliente!");
                txtFecha.Focus();
                return;
            }
            if (txtCupo.Text == "")
            {
                MessageBox.Show("Debe ingresar un cupo para el cliente");
                txtCupo.Focus();
                return;
            }
            int cupo;
            try
            {
                cupo = Convert.ToInt32(txtCupo.Text);
            }
            catch (Exception)
            { cupo = 0; }
            if (cupo == 0)
            {
                MessageBox.Show("Debe ingresar un vaor numerico para el cupo");
            }
            Cliente cliente = new Cliente();
            cliente.IdCliente = txtIdCliente.Text;
            cliente.Nombre = txtNombres.Text;
            cliente.Apellido = txtApellido.Text;
            cliente.Direccion = txtDireccion.Text;
            cliente.Telefono = txttelefono.Text;
            cliente.Correo = txtEmail.Text;
            cliente.fechanacimiento = txtFecha.Text;
            cliente.Cupo = Convert.ToInt32(txtCupo.Text);
            DatosC.NuevoCliente(cliente);
            MessageBox.Show("Cliente creado");
            Limpiar();

        }

        private void tbActualizar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Nombre = txtNombres.Text;
            cliente.Apellido = txtApellido.Text;
            cliente.Direccion = txtDireccion.Text;
            cliente.Telefono = txttelefono.Text;
            cliente.Correo = txtEmail.Text;
            cliente.fechanacimiento = txtFecha.Text;
            cliente.Cupo =Convert.ToInt32( txtCupo.Text);
           
                DatosC.ActualizarCliente(cliente);////le lanzo los parametros que deceo actualizar
           
            MessageBox.Show(DatosC.Mensaje);
            llenarGrid.LlenarGridWindows(dgClientes);
            txtIdCliente.Focus();
           
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
          
            llenarGrid.SQL = "SELECT * FROM Cliente";
            llenarGrid.LlenarGridWindows(dgClientes);
 
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            llenarGrid.SQL = "SELECT * FROM Cliente WHERE Nombres  LIKE '" + txtcliente.Text + "%'";
            llenarGrid.LlenarGridWindows(dgClientes);
 
        }

        private void tbEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Decea eliminar el cliente", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.No)
            {
                txtIdCliente.Focus();
                
                return;
            }
            DatosC.EliminarCliente(txtIdCliente.Text);
            MessageBox.Show(DatosC.Mensaje);
            llenarGrid.LlenarGridWindows(dgClientes);
            Limpiar();
            txtIdCliente.Focus();
        }

        
        }
    }

