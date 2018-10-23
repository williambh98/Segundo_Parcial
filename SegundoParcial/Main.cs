using SegundoParcial.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegundoParcial
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

      
        private void registroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RVendedorSegundoP vs = new RVendedorSegundoP();
            vs.Show();
            vs.MdiParent = this;

        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaVendedorS vs = new ConsultaVendedorS();
            vs.Show();
            vs.MdiParent = this;
        }
    }
}
