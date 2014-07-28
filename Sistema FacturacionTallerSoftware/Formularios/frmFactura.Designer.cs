namespace Sistema_FacturacionTallerSoftware.Formularios
{
    partial class frmFactura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFactura));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.cbProducto = new System.Windows.Forms.ComboBox();
            this.txtidFactura = new System.Windows.Forms.TextBox();
            this.cbFadtura = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.barraMenu = new System.Windows.Forms.ToolStrip();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgFacturas = new System.Windows.Forms.DataGridView();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbConsultar = new System.Windows.Forms.ToolStripButton();
            this.tbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tbActualizar = new System.Windows.Forms.ToolStripButton();
            this.tbEliminar = new System.Windows.Forms.ToolStripButton();
            this.tbLImpiar = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            this.barraMenu.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtcantidad);
            this.groupBox1.Controls.Add(this.txtprecio);
            this.groupBox1.Controls.Add(this.txtdescripcion);
            this.groupBox1.Controls.Add(this.cbProducto);
            this.groupBox1.Controls.Add(this.txtidFactura);
            this.groupBox1.Controls.Add(this.cbFadtura);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(808, 166);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mantenimiento Facturas";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(89, 140);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(119, 20);
            this.txtcantidad.TabIndex = 11;
            this.txtcantidad.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(89, 112);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(119, 20);
            this.txtprecio.TabIndex = 10;
            this.txtprecio.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtdescripcion.Location = new System.Drawing.Point(89, 60);
            this.txtdescripcion.Multiline = true;
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(448, 46);
            this.txtdescripcion.TabIndex = 9;
            // 
            // cbProducto
            // 
            this.cbProducto.FormattingEnabled = true;
            this.cbProducto.Location = new System.Drawing.Point(347, 33);
            this.cbProducto.Name = "cbProducto";
            this.cbProducto.Size = new System.Drawing.Size(190, 21);
            this.cbProducto.TabIndex = 8;
            this.cbProducto.SelectedIndexChanged += new System.EventHandler(this.cbProducto_SelectedIndexChanged);
            // 
            // txtidFactura
            // 
            this.txtidFactura.Location = new System.Drawing.Point(200, 31);
            this.txtidFactura.Name = "txtidFactura";
            this.txtidFactura.Size = new System.Drawing.Size(59, 20);
            this.txtidFactura.TabIndex = 7;
            // 
            // cbFadtura
            // 
            this.cbFadtura.FormattingEnabled = true;
            this.cbFadtura.Location = new System.Drawing.Point(89, 30);
            this.cbFadtura.Name = "cbFadtura";
            this.cbFadtura.Size = new System.Drawing.Size(33, 21);
            this.cbFadtura.TabIndex = 6;
            this.cbFadtura.SelectedIndexChanged += new System.EventHandler(this.cbFadtura_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = " Cantidad";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = " Precio";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = " Descripción";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = " ID Factura";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = " Factura";
            // 
            // barraMenu
            // 
            this.barraMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbConsultar,
            this.tbNuevo,
            this.tbActualizar,
            this.tbEliminar,
            this.tbLImpiar});
            this.barraMenu.Location = new System.Drawing.Point(0, 0);
            this.barraMenu.Name = "barraMenu";
            this.barraMenu.Size = new System.Drawing.Size(857, 25);
            this.barraMenu.TabIndex = 3;
            this.barraMenu.Text = "toolStrip1";
            this.barraMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.barraMenu_ItemClicked);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgFacturas);
            this.groupBox2.Controls.Add(this.txtbuscar);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(12, 217);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(808, 286);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " Listado Facturas";
            // 
            // dgFacturas
            // 
            this.dgFacturas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFacturas.Location = new System.Drawing.Point(18, 58);
            this.dgFacturas.Name = "dgFacturas";
            this.dgFacturas.Size = new System.Drawing.Size(752, 199);
            this.dgFacturas.TabIndex = 2;
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(89, 32);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(119, 20);
            this.txtbuscar.TabIndex = 1;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = " Busqueda";
            // 
            // tbConsultar
            // 
            this.tbConsultar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbConsultar.Image = global::Sistema_FacturacionTallerSoftware.Properties.Resources._1394555287_Select;
            this.tbConsultar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbConsultar.Name = "tbConsultar";
            this.tbConsultar.Size = new System.Drawing.Size(23, 22);
            this.tbConsultar.Text = "Permite consular un registro";
            this.tbConsultar.Click += new System.EventHandler(this.tbConsultar_Click);
            // 
            // tbNuevo
            // 
            this.tbNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbNuevo.Image = global::Sistema_FacturacionTallerSoftware.Properties.Resources._1394349252_Save;
            this.tbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbNuevo.Name = "tbNuevo";
            this.tbNuevo.Size = new System.Drawing.Size(23, 22);
            this.tbNuevo.Text = " Permite guardar un nuevo registro";
            this.tbNuevo.Click += new System.EventHandler(this.tbNuevo_Click);
            // 
            // tbActualizar
            // 
            this.tbActualizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbActualizar.Image = global::Sistema_FacturacionTallerSoftware.Properties.Resources._1396204973_Update;
            this.tbActualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbActualizar.Name = "tbActualizar";
            this.tbActualizar.Size = new System.Drawing.Size(23, 22);
            this.tbActualizar.Text = " Permite actualizar un registro";
            this.tbActualizar.Click += new System.EventHandler(this.tbActualizar_Click);
            // 
            // tbEliminar
            // 
            this.tbEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbEliminar.Image = global::Sistema_FacturacionTallerSoftware.Properties.Resources._1394349145__trash;
            this.tbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbEliminar.Name = "tbEliminar";
            this.tbEliminar.Size = new System.Drawing.Size(23, 22);
            this.tbEliminar.Text = " Permite eliminar un registro";
            this.tbEliminar.Click += new System.EventHandler(this.tbEliminar_Click);
            // 
            // tbLImpiar
            // 
            this.tbLImpiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbLImpiar.Image = global::Sistema_FacturacionTallerSoftware.Properties.Resources._1394349313_Gnome_Edit_Clear_64;
            this.tbLImpiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbLImpiar.Name = "tbLImpiar";
            this.tbLImpiar.Size = new System.Drawing.Size(23, 22);
            this.tbLImpiar.Text = " Limpia los campos";
            this.tbLImpiar.Click += new System.EventHandler(this.tbLImpiar_Click);
            // 
            // frmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(857, 515);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.barraMenu);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mantenimiento Factura";
            this.Load += new System.EventHandler(this.frmFactura_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.barraMenu.ResumeLayout(false);
            this.barraMenu.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFacturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.ComboBox cbProducto;
        private System.Windows.Forms.TextBox txtidFactura;
        private System.Windows.Forms.ComboBox cbFadtura;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip barraMenu;
        private System.Windows.Forms.ToolStripButton tbConsultar;
        private System.Windows.Forms.ToolStripButton tbNuevo;
        private System.Windows.Forms.ToolStripButton tbActualizar;
        private System.Windows.Forms.ToolStripButton tbEliminar;
        private System.Windows.Forms.ToolStripButton tbLImpiar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgFacturas;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label label7;
    }
}