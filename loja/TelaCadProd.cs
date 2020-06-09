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
                            int codCombo = 0;
                            con.Open();

                            if (cboTipo.Text == "Sapato")
                            {
                                codCombo = 1;
                            }
                            else if (cboTipo.Text == "Salto")
                            {
                                codCombo = 2;
                            }
                            else if (cboTipo.Text == "Tênis")
                            {
                                codCombo = 3;
                            }
                            else if (cboTipo.Text == "Bota")
                            {
                                codCombo = 4;
                            }

                            string sql = "insert into Produto(nomeProd, quantidadeProd, dataCadProd, precoProd, custoProd, marcaProd, dataCompraProd, nomeFornecedor, codTipo, estoque, descricaoProd, codigoBarras) values('" + txtNomeProduto.Text + "', '" + txtQuantidade.Text + "', '" + Convert.ToDateTime(txtDtCad.Text).ToString("yyyy/MM/dd") + "', '" + txtPreco.Text + "', '" + txtCusto.Text + "', '" + txtMarca.Text + "', '" +Convert.ToDateTime(txtDtCompra.Text).ToString("yyyy/MM/dd")+ "', '" + txtFornecedor.Text+"', '" + codCombo + "', '" + txtEstoque.Text + "', '" + txtDescricao.Text+ "', '" + txtCodigoBarra.Text + "')";
                            MySqlCommand cmd = new MySqlCommand(sql, con);
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Produto Cadastrado.");
                            txtNomeProduto.Text = "";
                            txtQuantidade.Text = "";
                            txtDtCad.Text = "";
                            txtPreco.Text = "";
                            txtCusto.Text = "";
                            txtMarca.Text = "";
                            txtDtCompra.Text = "";
                            txtFornecedor.Text = "";
                            cboTipo.Text = "";
                            txtEstoque.Text = "";
                            txtDescricao.Text = "";
                            txtCodigoBarra.Text = "";
                            con.Close();
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
