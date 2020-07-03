using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loja
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaCadFunc Form = new TelaCadFunc();
            Form.Show();
            Visible = true;
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaConsFunc Form = new TelaConsFunc();
            Form.Show();
            Visible = true;
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TelaCadProd Form = new TelaCadProd();
            Form.Show();
            Visible = true;
        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TelaConsProd Form = new TelaConsProd();
            Form.Show();
            Visible = true;
        }

        private void consultarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            TelaConsEstoque Form = new TelaConsEstoque();
            Form.Show();
            Visible = true;
        }

        private void consultarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            TelaCadVenda Form = new TelaCadVenda();
            Form.Show();
            Visible = true;
        }

        private void consultarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            TelaConsVenda Form = new TelaConsVenda();
            Form.Show();
            Visible = true;
        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
