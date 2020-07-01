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
    public partial class TelaCadProd : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost; user=root;database=loja;port=3306;password=root;");

        public TelaCadProd()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNomeProduto.Text != "")
                {
                    if (txtPreco.Text != "")
                    {
                        if (txtCusto.Text != "")
                        {
                            incluirProd();
                            incluirProdEstoque();
                            limparTela();                            
                        }
                        else
                        {
                            MessageBox.Show("É necessário digitar o Custo");
                        }
                    }
                    else
                    {
                        MessageBox.Show("É necessário digitar um Preço");
                    }
                }
                else
                {
                    MessageBox.Show("É necessário digitar Nome do Produto");
                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.ToString());
            }
        }

        public void incluirProd() {
            con.Open();
            int codCombo = cboTipo.SelectedIndex + 1;
            string sql = "insert into Produto(nomeProd, quantidadeProd, dataCadProd, precoProd, custoProd, marcaProd, dataCompraProd, nomeFornecedor, codTipo, descricaoProd, codigoBarras) values('" + txtNomeProduto.Text + "', '" + txtQuantidade.Text + "', '" + Convert.ToDateTime(txtDtCad.Text).ToString("yyyy/MM/dd") + "', '" + txtPreco.Text + "', '" + txtCusto.Text + "', '" + txtMarca.Text + "', '" + Convert.ToDateTime(txtDtCompra.Text).ToString("yyyy/MM/dd") + "', '" + txtFornecedor.Text + "', '" + codCombo + "', '" + txtDescricao.Text + "', '" + txtCodigoBarra.Text + "')";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Produto Cadastrado.");            
            con.Close();
        }

        public void incluirProdEstoque() {
            con.Open();
            int codCombo = cboTipo.SelectedIndex + 1;
            string sql = "insert into Estoque(nomeProdEstoq, quantidadeProdEstoq, precoProdEstoq, marcaProdEstoq, codTipoProdEstoq) values('" + txtNomeProduto.Text + "', '" + Convert.ToInt32(txtQuantidade.Text) + "', '" + txtPreco.Text + "', '" + txtMarca.Text + "', '" + codCombo + "')";            
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void limparTela() {
            txtNomeProduto.Text = "";
            txtQuantidade.Text = "";
            txtDtCad.Text = "";
            txtPreco.Text = "";
            txtCusto.Text = "";
            txtMarca.Text = "";
            txtDtCompra.Text = "";
            txtFornecedor.Text = "";
            cboTipo.Text = "";
            txtDescricao.Text = "";
            txtCodigoBarra.Text = "";
        }

        private void TelaCadProd_Load(object sender, EventArgs e)
        {
            //Preenche o ComboBox com os cadastros da Tabela - Tipo
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select nomeTipo from TipoProduto";
            MySqlDataReader rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rdr);
            cboTipo.DisplayMember = "nomeTipo";
            cboTipo.DataSource = dt;            
            con.Close();
        }
    }
}
