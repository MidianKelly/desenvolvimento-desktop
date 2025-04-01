using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultApp.Windows
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();

        }

        private void MenuCalculadoraImc_Click(object sender, EventArgs e)
        {

            var form = new frmCalculadoraIMC();
            form.MdiParent = this;
            form.Show();
        }

        private void Principal_Shown(object sender, EventArgs e)
        {
            var loading = new SplashScreen();
            loading.ShowDialog();
        }

        private void calculadoraAposentadoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmCalculadoraAposentadoria ();
            form.MdiParent = this;
            form.Show();
        }

        private void carteirinhaDoParqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmCarteirinha();
            form.MdiParent = this;
            form.Show();
        }
 
        private void lojaDeAçaíToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var form = new frmLojaAcai();
            form.ShowDialog();
        }
    }
}
