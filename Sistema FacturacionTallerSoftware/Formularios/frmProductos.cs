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
using LibLlenarCombos;
using LibLlenarGrids;
namespace Sistema_FacturacionTallerSoftware.Formularios
{
    public partial class frmProductos : Form
    {
        LlenarGrids llenarGid = new LlenarGrids("Parametros.xml");
        LlenarCombos llenarCombos = new LlenarCombos("Parametros.xml");

        private Usuario usuarioLogueado; 
        public Usuario UsuarioLogueado
        {
            get { return usuarioLogueado; }
            set { usuarioLogueado = value; }
        }
        public frmProductos()
        {
            InitializeComponent();
        }

        private void Limpiar() {
            txtIdProducto.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
            txtNotas.Text="";
            cbIva.SelectedIndex=-1;
            cbDepertamento.SelectedIndex = -1;
        
        }
        private void tbConsultar_Click(object sender, EventArgs e)
        {
            if (txtIdProducto.Text == "")
            {
                MessageBox.Show("Debe ingresar un id de producto que decea cosultar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtIdProducto.Focus();
                return;
            }
            int idProducto;
            try
            {
                idProducto = Convert.ToInt32(txtIdProducto.Text);
            }
            catch (Exception)
            { idProducto = 0; }
            if (idProducto == 0)
            {
                MessageBox.Show("Debe ingresar un id numerico para realizar la consulta..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Producto producto = DatosP.ConsultarProducto(Convert.ToInt32(txtIdProducto.Text));
            if (producto == null)
            {
                MessageBox.Show(DatosP.Mensaje);
                txtIdProducto.Focus();
                return;
            }
            txtIdProducto.Text = producto.IDProducto.ToString();
            txtDescripcion.Text = producto.Descripcion.ToString();
            txtPrecio.Text = producto.Precio.ToString();
            txtStock.Text = producto.Stock.ToString();
            txtNotas.Text = producto.Notas.ToString();
            cbIva.SelectedValue = producto.IDIva.ToString();
            cbDepertamento.SelectedValue = producto.IDDepartamento.ToString();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            //llenar grid


            llenarGid.SQL = "SELECT dbo.Producto.IDProducto, dbo.Producto.Descripcion," +
                " dbo.Producto.Precio, dbo.Producto.Stock, dbo.Producto.Notas,"
                + " dbo.IVA.Descripcion AS Iva, dbo.Departamento.Descripcion AS Departamento "
                + "FROM dbo.Departamento INNER JOIN "
                + "dbo.Producto ON dbo.Departamento.IDDepartamento = dbo.Producto.IDDepartamento "
                + " INNER JOIN dbo.IVA ON dbo.Producto.IDIVA = dbo.IVA.IDIVA";
            llenarGid.LlenarGridWindows(dgProductos);

            //llena combo iva
            llenarCombos.SQL = "SELECT IDIVA, Descripcion FROM IVA ORDER BY 2";
            llenarCombos.CampoID = "IDIVA";
            llenarCombos.CampoTexto = "Descripcion";
            llenarCombos.LlenarComboWindows(cbIva);
            //llenar combo departamento
            llenarCombos.SQL = "SELECT IDDepartamento, Descripcion FROM Departamento ORDER BY 2";
            llenarCombos.CampoID = "IDDepartamento";
            llenarCombos.CampoTexto = "Descripcion";
            llenarCombos.LlenarComboWindows(cbDepertamento);

            //valido el usuario logueado
            if (usuarioLogueado.perfil !=1)
            {
                tbNuevo.Enabled = false;
                tbActualizar.Enabled = false;
                tbEliminar.Enabled = false;
                dgProductos.Enabled = false;
                
            }
        }

        private void txtProducto_TextChanged(object sender, EventArgs e)
        {
            llenarGid.SQL = "SELECT dbo.Producto.IDProducto, dbo.Producto.Descripcion," +
             " dbo.Producto.Precio, dbo.Producto.Stock, dbo.Producto.Notas,"
             + " dbo.IVA.Descripcion AS Iva, dbo.Departamento.Descripcion AS Departamento "
             + "FROM dbo.Departamento INNER JOIN "
             + "dbo.Producto ON dbo.Departamento.IDDepartamento = dbo.Producto.IDDepartamento "
             + " INNER JOIN dbo.IVA ON dbo.Producto.IDIVA = dbo.IVA.IDIVA WHERE Producto.Descripcion LIKE '" + txtProducto.Text + "%'";
            llenarGid.LlenarGridWindows(dgProductos);
        }

        private void tbNuevo_Click(object sender, EventArgs e)
        {
            if (txtDescripcion.Text=="")
            {
                MessageBox.Show("Debe ingresar una descripción");
                txtDescripcion.Focus();
                return;
            }
            if (txtPrecio.Text=="")
            {
                MessageBox.Show("Debe ingresar un precio para el producto");
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
            if (precio==0)
            {
                MessageBox.Show("Debe ingresar un valor $ para el precio");
            }
            if (txtStock.Text=="")
            {
                MessageBox.Show("Debe ingresar un stock de producto");
                txtStock.Focus();
                return;
            }
            int stock;
            try
            {
                stock = Convert.ToInt32(txtStock.Text);
            }
            catch (Exception)
            { stock = 0; }
            if (stock == 0)
            {
                MessageBox.Show("Debe ingresar un valor númerico para el stock","Error"
                    ,MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            Producto producto = new Producto();
            producto.Descripcion = txtDescripcion.Text;
            producto.Precio = Convert.ToDecimal(txtPrecio.Text);
            producto.Stock = Convert.ToInt32(txtStock.Text);
            producto.Notas = txtNotas.Text;
            producto.IDIva = Convert.ToInt32(cbIva.SelectedValue);
            producto.IDDepartamento = Convert.ToInt32(cbDepertamento.SelectedValue);
            //lanzo el producto para crearlo
            DatosP.NuevoProducto(producto);
            MessageBox.Show(DatosP.Mensaje);
            llenarGid.LlenarGridWindows(dgProductos);
             //limpio los campos
            Limpiar();
        }

        private void tbActualizar_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            producto.Descripcion = txtDescripcion.Text;
            producto.Precio = Convert.ToDecimal(txtPrecio.Text);
            producto.Stock = Convert.ToInt32(txtStock.Text);
            producto.Notas = txtNotas.Text;
            producto.IDIva = Convert.ToInt32(cbIva.SelectedValue);
            producto.IDDepartamento = Convert.ToInt32(cbDepertamento.SelectedValue);
            DatosP.ActualizarProducto(producto);//lanzo los parametros que deceo actualizar
            MessageBox.Show(DatosP.Mensaje);
            txtIdProducto.Focus();
            llenarGid.LlenarGridWindows(dgProductos);
            Limpiar();
        }

        private void tbEliminar_Click(object sender, EventArgs e)
        {
            if (txtIdProducto.Text=="")
            {
                MessageBox.Show("Debe ingresar un id del producto que decea elimianr..!!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtIdProducto.Focus();
                return;
            }
            DialogResult dr = MessageBox.Show("Esta seguro que decea eliminar el producto","Confirmación",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dr==DialogResult.No)
            {
                txtIdProducto.Focus();
                txtIdProducto.Text = "";
                return;
            }
            DatosP.EliminarProducto(Convert.ToInt32(txtIdProducto.Text));
            MessageBox.Show(DatosP.Mensaje);
            txtIdProducto.Focus();
            txtIdProducto.Text = "";
            llenarGid.LlenarGridWindows(dgProductos);
        }

        private void barraMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
