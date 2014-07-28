using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaNegocio;
using LogicaNegocio.Clases;
namespace Sistema_FacturacionTallerSoftware
{
    public partial class frmLoguin : Form
    {

        public frmLoguin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                MessageBox.Show("Debe ingresar un usuario", "Campo usuario vacio",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txtClave.Text == "")
            {
                MessageBox.Show("Debe ingresar una clave de usuario", "Campo password vacio", 
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (!DatosUsuarios.ValidarUsuario(txtUsuario.Text, txtClave.Text))
            {
                MessageBox.Show(DatosUsuarios.Mensaje,"Error al intentar ingresar!",
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtUsuario.Focus();
                return;
            }
            Usuario usuario = DatosUsuarios.ConsultarUsuario(txtUsuario.Text);
            this.Hide();
            frmPrincipal fr = new frmPrincipal();
            fr.UsuarioLogueado = usuario;
            fr.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
