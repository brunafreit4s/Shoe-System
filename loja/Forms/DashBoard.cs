using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace loja
{
    public partial class DashBoard : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost; user=root;database=loja;port=3306;password=root;");
        public DashBoard()
        {
            InitializeComponent();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadFunc Form = new frmCadFunc();
            Form.Show();
            Visible = true;
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFuncionarios Form = new frmFuncionarios();
            Form.Show();
            Visible = true;
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCadProd Form = new frmCadProd();
            Form.Show();
            Visible = true;
        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmProduto Form = new frmProduto();
            Form.Show();
            Visible = true;
        }

        private void consultarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmEstoque Form = new frmEstoque();
            Form.Show();
            Visible = true;
        }

        private void consultarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmCadVenda Form = new frmCadVenda();
            Form.Show();
            Visible = true;

            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select nomeFunc, cpf from Funcionario where cpf = '" + txtCpf.Text + "'";
            MySqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.Read())
            {
                Form.txtVendedor.Text = rdr[0].ToString();
                Form.txtCpfVendedor.Text = rdr[1].ToString();
            }
            con.Close();
        }

        private void consultarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frmVendas Form = new frmVendas();
            Form.Show();
            Visible = true;
        }

        private void produtoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRptProduto Form = new frmRptProduto();
            Form.Show();
            Visible = true;
        }

        private void estoqueToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRptEstoque Form = new frmRptEstoque();
            Form.Show();
            Visible = true;
        }

        private void vendaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRptVendas Form = new frmRptVendas();
            Form.Show();
            Visible = true;
        }
    }
}
