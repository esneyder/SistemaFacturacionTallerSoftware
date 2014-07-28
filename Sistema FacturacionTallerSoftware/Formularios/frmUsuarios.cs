using LogicaNegocio;
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
 

namespace Sistema_FacturacionTallerSoftware.Formularios
{
    public partial class frmUsuarios : Form
    {
        private Usuario usuarioLogueado;

        public Usuario UsuarioLogueado
        {
            get { return usuarioLogueado; }
            set { usuarioLogueado = value; }
        }
        public frmUsuarios()
        {
            InitializeComponent();
        }
       
        private void frmUsuarios_Load(object sender, EventArgs e)
        {

            if (usuarioLogueado.perfil !=1)
            {
                btnModificar.Enabled = false;
                btnGuardar.Enabled = false;
            }

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                MessageBox.Show("Debe ingresar el usuario que decea consultar",
                    "Campo usuario vacio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsuario.Focus();
                return;
            }
            Usuario usuario = DatosUsuarios.ConsultarUsuario(txtUsuario.Text);
            if (usuario == null)
            {
                MessageBox.Show(DatosUsuarios.Mensaje);
                txtUsuario.Focus();
                return;
            }
            txtUsuario.Text = usuario.usuario.ToString();
            txtClave.Text = usuario.clave.ToString();
            txtNombre.Text = usuario.nombres.ToString();
            txtApellido.Text = usuario.apellidos.ToString();
            txtPerfil.Text = usuario.perfil.ToString();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                MessageBox.Show("Debe ingresar un usuario");
                txtUsuario.Focus();
                return;
            }
            if (txtClave.Text == "")
            {
                MessageBox.Show("Debe ingresar una clave para el usuario");
                txtClave.Focus();
                return;
            }
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Debe ingresar un nombre para el usuario");
                txtNombre.Focus();
                return;
            }
            if (txtApellido.Text == "")
            {
                MessageBox.Show("Debe ingresar un apellido para el usuario");
                txtApellido.Focus();
                return;
            }
            if (txtPerfil.Text == "")
            {
                MessageBox.Show("Debe ingresar un perfil para le usuario");
                txtPerfil.Focus();
                return;
            }
            int perfil;
            try
            {
                perfil = Convert.ToInt32(txtPerfil.Text);
            }
            catch (Exception)
            {
                perfil = 0;
            }
            if (perfil==0)
            {
                MessageBox.Show("Debe ingresar un valor numerico para el perfil.");
                txtPerfil.Focus();
                return;
            }
          
              Usuario  usu = new Usuario();
            
            usu.usuario = txtUsuario.Text;
            usu.clave = txtClave.Text;
            usu.nombres = txtNombre.Text;
            usu.apellidos = txtApellido.Text;
            usu.perfil =Convert.ToInt32( txtPerfil.Text);
           
                DatosUsuarios.NuevoUsuario(usu);
                MessageBox.Show("Usuario creado correctamente");
              
          
          }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                MessageBox.Show("Debe ingresar un usuario");
                txtUsuario.Focus();
                return;
            }
           
            int perfil;
            try
            {
                perfil = Convert.ToInt32(txtPerfil.Text);
            }
            catch (Exception)
            {
                perfil = 0;
            }
            if (perfil == 0)
            {
                MessageBox.Show("Debe ingresar un valor numerico para el perfil.");
                txtPerfil.Focus();
                return;
            }

            Usuario usu = new Usuario();

            usu.usuario = txtUsuario.Text;
            usu.clave = txtClave.Text;
            usu.nombres = txtNombre.Text;
            usu.apellidos = txtApellido.Text;
            usu.perfil = Convert.ToInt32(txtPerfil.Text);

            DatosUsuarios.ActualizarUsuario(usu);
            MessageBox.Show("Usuario actualizado correctamente");
        }
    }
}
