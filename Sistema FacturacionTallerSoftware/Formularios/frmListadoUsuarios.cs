using LibLlenarGrids;
using System;
using System.Windows.Forms;

namespace Sistema_FacturacionTallerSoftware.Formularios
{
    public partial class frmListadoUsuarios : Form
    {
        LlenarGrids llenarGrid = new LlenarGrids("Parametros.xml");
        public frmListadoUsuarios()
        {
            InitializeComponent();
        }

        private void frmListadoUsuarios_Load(object sender, EventArgs e)
        {
          
            llenarGrid.SQL = "SELECT * FROM Usuario";
            llenarGrid.LlenarGridWindows(dgvUsuarios);
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            llenarGrid.SQL = "SELECT * FROM Usuario WHERE Usuario LIKE '" + txtUsuario.Text+"%'";
            llenarGrid.LlenarGridWindows(dgvUsuarios);
        }
    }
}