﻿namespace Sistema_FacturacionTallerSoftware.Formularios
{
    partial class frmFacturaTemporal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFacturaTemporal));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbProducto = new System.Windows.Forms.ComboBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtIdFactura = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.barraMenu = new System.Windows.Forms.ToolStrip();
            this.tbConsultar = new System.Windows.Forms.ToolStripButton();
            this.tbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tbActualizar = new System.Windows.Forms.ToolStripButton();
            this.tbEliminar = new System.Windows.Forms.ToolStripButton();
            this.tbLImpiar = new System.Windows.Forms.ToolStripButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgfacturaTemp = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.barraMenu.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgfacturaTemp)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbProducto);
            this.groupBox1.Controls.Add(this.txtCantidad);
            this.groupBox1.Controls.Add(this.txtPrecio);
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.txtIdFactura);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(653, 184);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Mantenimiento facturas temporales";
            // 
            // cbProducto
            // 
            this.cbProducto.FormattingEnabled = true;
            this.cbProducto.Location = new System.Drawing.Point(97, 58);
            this.cbProducto.Name = "cbProducto";
            this.cbProducto.Size = new System.Drawing.Size(173, 21);
            this.cbProducto.TabIndex = 9;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(97, 147);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 8;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(97, 120);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 7;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescripcion.Location = new System.Drawing.Point(97, 86);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(503, 28);
            this.txtDescripcion.TabIndex = 6;
            // 
            // txtIdFactura
            // 
            this.txtIdFactura.Location = new System.Drawing.Point(97, 32);
            this.txtIdFactura.Name = "txtIdFactura";
            this.txtIdFactura.Size = new System.Drawing.Size(48, 20);
            this.txtIdFactura.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cantidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Producto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Factura";
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
            this.barraMenu.Size = new System.Drawing.Size(747, 25);
            this.barraMenu.TabIndex = 3;
            this.barraMenu.Text = "toolStrip1";
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgfacturaTemp);
            this.groupBox2.Location = new System.Drawing.Point(12, 250);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(653, 233);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Listado facturas temporales";
            // 
            // dgfacturaTemp
            // 
            this.dgfacturaTemp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgfacturaTemp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgfacturaTemp.Location = new System.Drawing.Point(20, 51);
            this.dgfacturaTemp.Name = "dgfacturaTemp";
            this.dgfacturaTemp.Size = new System.Drawing.Size(580, 159);
            this.dgfacturaTemp.TabIndex = 0;
            // 
            // frmFacturaTemporal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 495);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.barraMenu);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFacturaTemporal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento Factura Temporal";
            this.Load += new System.EventHandler(this.frmFacturaTemporal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.barraMenu.ResumeLayout(false);
            this.barraMenu.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgfacturaTemp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbProducto;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtIdFactura;
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
        private System.Windows.Forms.DataGridView dgfacturaTemp;
    }
}