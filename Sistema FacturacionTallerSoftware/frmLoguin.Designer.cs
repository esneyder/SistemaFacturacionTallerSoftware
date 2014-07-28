namespace Sistema_FacturacionTallerSoftware
{
    partial class frmLoguin
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoguin));
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.btnLogueo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(669, 227);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(113, 20);
            this.txtUsuario.TabIndex = 2;
            this.txtUsuario.Text = "Usuario";
            // 
            // txtClave
            // 
            this.txtClave.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtClave.Location = new System.Drawing.Point(669, 253);
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.Size = new System.Drawing.Size(113, 20);
            this.txtClave.TabIndex = 3;
            this.txtClave.Text = "password";
            // 
            // btnLogueo
            // 
            this.btnLogueo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogueo.BackgroundImage = global::Sistema_FacturacionTallerSoftware.Properties.Resources._1396048506_Next;
            this.btnLogueo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogueo.Location = new System.Drawing.Point(724, 279);
            this.btnLogueo.Name = "btnLogueo";
            this.btnLogueo.Size = new System.Drawing.Size(58, 44);
            this.btnLogueo.TabIndex = 4;
            this.btnLogueo.UseVisualStyleBackColor = false;
            this.btnLogueo.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Image = global::Sistema_FacturacionTallerSoftware.Properties.Resources._1396325531_system_log_out;
            this.button1.Location = new System.Drawing.Point(1, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 22);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frmLoguin
            // 
            this.AcceptButton = this.btnLogueo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sistema_FacturacionTallerSoftware.Properties.Resources.configuracion_facturacion_en_linea_a_traves_internet_colombia;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(814, 328);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLogueo);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLoguin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso al Sistema";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Button btnLogueo;
        private System.Windows.Forms.Button button1;
    }
}

