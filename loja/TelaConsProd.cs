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
    public partial class TelaConsProd : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost; user=root;database=loja;port=3306;password=root;");
        Boolean retorno = false;

        public TelaConsProd()
        {
            InitializeComponent();
        }

        public void ConsultaBanco()
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select a.*, b.nomeTipo, c.fk_codProd from Produto a, TipoProduto b, Estoque c where a.codTipo = b.codTipo and a.codProd='" + txtCodProd.Text + "' and c.fk_codProd ='" + txtCodProd.Text + "' ";
            MySqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.Read())
            {
                txtCodProd.Text = rdr[0].ToString();
                txtNomeProduto.Text = rdr[1].ToString();
                txtQuantidade.Text = rdr[2].ToString();
                txtDtCad.Text = rdr[3].ToString();
                txtPreco.Text = rdr[4].ToString();
                txtCusto.Text = rdr[5].ToString();
                txtMarca.Text = rdr[6].ToString();
                txtDtCompra.Text = rdr[7].ToString();
                txtFornecedor.Text = rdr[8].ToString();
                cboTipo.Text = rdr[12].ToString();
                txtEstoque.Text = rdr[13].ToString();
                txtDescricao.Text = rdr[10].ToString();
                txtCodigoBarra.Text = rdr[11].ToString();
                retorno = true;
            }
            else
            {
                retorno = false;
                rdr.Close();
            }

            con.Close();
        }

        private void TelaConsProd_Load(object sender, EventArgs e)
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

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparTela();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (txtCodProd.Text == "")
            {
                MessageBox.Show("É nescessário um Código, ou Nome, ou Código de Barras!");
            }
            else
            {
                try
                {
                    ConsultaBanco();

                    if (retorno == false)
                    {
                        MessageBox.Show("Não foi possível encontrar os valores digitados!");
                    }
                    else
                    {
                        btnAlterar.Enabled = true;
                        btnExcluir.Enabled = true;
                    }
                }
                catch (Exception ex)
                {
                    con.Close();
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCodProd.Text == "")
                {
                    MessageBox.Show("É nescessário digitar o Código do Produto");
                }
                else if (Convert.ToInt32(txtQuantidade.Text) >= 0)
                {
                    con.Open();
                    int codCombo = cboTipo.SelectedIndex + 1;
                    string sql = "update Produto set nomeProd = '" + txtNomeProduto.Text + "', quantidadeProd = '" + txtQuantidade.Text + "', dataCadProd = '" + Convert.ToDateTime(txtDtCad.Text).ToString("yyyy/MM/dd") + "', precoProd = '" + txtPreco.Text + "', custoProd = '" + txtCusto.Text + "', marcaProd = '" + txtMarca.Text + "', dataCompraProd = '" + Convert.ToDateTime(txtDtCompra.Text).ToString("yyyy/MM/dd") + "', nomeFornecedor = '" + txtFornecedor.Text + "', codTipo = '" + codCombo + "', estoque = '" + txtEstoque.Text + "', descricaoProd = '" + txtDescricao.Text + "', codigoBarras = '" + txtCodigoBarra.Text + "' where codProd ='" + txtCodProd.Text + "'";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Produto Alterado.");
                    con.Close();
                    limparTela();
                }
                else
                {
                    if (MessageBox.Show("A quantidade de Produto é igual a 0. Deseja Excluir o Produto do Estoque?", "Confirmação",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        //tem que executar o Delte na tabela de Estoque 
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Atenção! O Produto não foi Deletado do Estoque e não pode ser Alterado com o valor da quantidade igual a 0!");
                    }
                }

            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtCodProd.Text == "")
            {
                MessageBox.Show("É necessário consultar uma matrícula para efetuar a Exclusão");
            }
            else
            {
                try
                {
                    con.Open();
                    string sql = "delete from Produto where codProd ='" + txtCodProd.Text + "'";

                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Produto Excluído.");
                    con.Close();
                    limparTela();
                }
                catch (Exception ex)
                {
                    con.Close();
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        public void limparTela()
        {
            txtCodProd.Text = "";
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
        }
    }
}
