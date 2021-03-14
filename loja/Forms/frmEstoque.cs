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
    public partial class frmEstoque : Form
    {
        private MySqlConnection con = new MySqlConnection("server=localhost; user=root;database=loja;port=3306;password=root;");

        public frmEstoque()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtCodProd.Text != "")
            {
                dataGridView1.DataSource = consCodProd();
            }
            else
            {
                dataGridView1.DataSource = consProduto();
            }
        }

        private DataTable consCodProd() {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select a.codEstoque As Código, a.nomeProdEstoq As Nome, a.quantidadeProdEstoq As Quantidade, a.precoProdEstoq As Preço, a.marcaProdEstoq As Marca, b.nomeTipo As Tipo from Estoque a, TipoProduto b, Produto c where a.codTipoProdEstoq = b.codTipo and a.fk_codProd = '" + txtCodProd.Text + "'";
            MySqlDataReader rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rdr);
            con.Close();
            return dt;
        }

        private DataTable consProduto()
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select a.codEstoque As Código, a.nomeProdEstoq As Nome, a.quantidadeProdEstoq As Quantidade, a.precoProdEstoq As Preço, a.marcaProdEstoq As Marca, b.nomeTipo As Tipo from Estoque a, TipoProduto b where a.codTipoProdEstoq = b.codTipo";
            MySqlDataReader rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rdr);
            con.Close();
            return dt;
        }

        private void dataGridView1_CellContent(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.CurrentRow.Selected = true;
                txtCodProd.Text = dataGridView1.Rows[e.RowIndex].Cells["Código"].FormattedValue.ToString();
                txtNomeItem.Text = dataGridView1.Rows[e.RowIndex].Cells["Nome"].FormattedValue.ToString();
                txtQuantidade.Text = dataGridView1.Rows[e.RowIndex].Cells["Quantidade"].FormattedValue.ToString();
                txtPreco.Text = dataGridView1.Rows[e.RowIndex].Cells["Preço"].FormattedValue.ToString();
                txtMarca.Text = dataGridView1.Rows[e.RowIndex].Cells["Marca"].FormattedValue.ToString();
                cboTipo.Text = dataGridView1.Rows[e.RowIndex].Cells["Tipo"].FormattedValue.ToString();
            }
        }
    }
}
