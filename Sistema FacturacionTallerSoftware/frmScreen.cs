using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_FacturacionTallerSoftware
{
    public partial class frmScreen : Form
    {
        public frmScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);///permte incrementar en 1 la barra

            if (progressBar1.Value==100)
            {
                this.timer1.Stop();   //detengo el timer  cuando llegue a 100
                 
            }
        }

        private void frmScreen_Load(object sender, EventArgs e)
        {
             
        }
    }
}
