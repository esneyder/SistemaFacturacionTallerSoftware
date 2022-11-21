using System;
using System.Windows.Forms;
using System.Threading;
using Sistema_FacturacionTallerSoftware.Formularios;
using Sistema_FacturacionTallerSoftware.Mantenimiento;

namespace Sistema_FacturacionTallerSoftware
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {

            Thread tiempo = new Thread(new ThreadStart(Screnn));
            tiempo.Start();
            Thread.Sleep(7500);//tiempo que tomara la ejecucion en milesimas de segundos
            InitializeComponent();
            tiempo.Abort();


        }
        public void Screnn()
        {
            Application.Run(new frmScreen());
        }
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            if (usuarioLogueado.perfil != 1)
            {
                listarUsuariosToolStripMenuItem.Enabled = false;
                departamentoToolStripMenuItem.Enabled = false;
            }

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarios usu = new frmUsuarios();
            usu.UsuarioLogueado = UsuarioLogueado;
            usu.MdiParent = this;
            usu.Show();
        }

        private void listarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoUsuarios frl = new frmListadoUsuarios();
            frl.MdiParent = this;
            frl.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes fc = new frmClientes();
            fc.MdiParent = this;
            fc.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductos fp = new frmProductos();
            fp.UsuarioLogueado = this.usuarioLogueado;
            fp.MdiParent = this;
            fp.Show();

        }

        private void ivaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ivaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmIva fr = new frmIva();

            fr.MdiParent = this;
            fr.Show();
        }

        private void departamentoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmDepartamento fr = new frmDepartamento();
            fr.MdiParent = this;
            fr.Show();
        }

        private void nuevaFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFactura frfac = new frmFactura();
            frfac.MdiParent = this;
            frfac.Show();
        }

        private void reporteFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteFacturas f = new frmReporteFacturas();
            f.MdiParent = this;
            f.Show();
        }

        private void departamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void facturaTemporalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFacturaTemporal ftmp = new frmFacturaTemporal();
            ftmp.MdiParent = this;
            ftmp.Show();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.Exit();
        }
    }
}