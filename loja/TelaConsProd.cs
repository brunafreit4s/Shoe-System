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
            cmd.CommandText = "Select a.*, b.nomeTipo from Produto a, TipoProduto b where a.codTipo = b.codTipo and a.codProd='" + txtCodProd.Text + "'";
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
                cboTipo.Text = rdr[13].ToString();
                txtEstoque.Text = rdr[10].ToString();
                txtDescricao.Text = rdr[11].ToString();
                txtCodigoBarra.Text = rdr[12].ToString();
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

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (txtCodProd.Text != "")
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
            else
            {
                MessageBox.Show("É nescessário um Código, ou Nome, ou Código de Barras!");
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCodProd.Text != "")
                {
                    con.Open();

                    int codCombo = cboTipo.SelectedIndex + 1;
                    string sql = "update Produto set nomeProd = '" + txtNomeProduto.Text + "', quantidadeProd = '" + txtQuantidade.Text + "', dataCadProd = '" + Convert.ToDateTime(txtDtCad.Text).ToString("yyyy/MM/dd") + "', precoProd = '" + txtPreco.Text + "', custoProd = '" + txtCusto.Text + "', marcaProd = '" + txtMarca.Text + "', dataCompraProd = '" + Convert.ToDateTime(txtDtCompra.Text).ToString("yyyy/MM/dd") + "', nomeFornecedor = '" + txtFornecedor.Text + "', codTipo = '" + codCombo + "', estoque = '" + txtEstoque.Text + "', descricaoProd = '" + txtDescricao.Text + "', codigoBarras = '" + txtCodigoBarra.Text + "' where codProd ='" + txtCodProd.Text + "'";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Produto Alterado.");
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
                    con.Close();
                }
                else
                {
                    MessageBox.Show("É nescessário digitar o Código do Produto");
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
            try
            {
                if (txtCodProd.Text != "")
                {
                    con.Open();
                    string sql = "delete from Produto where codProd ='" + txtCodProd.Text + "'";

                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Produto Excluído.");
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
                    con.Close();
                }
                else
                {
                    MessageBox.Show("É necessário consultar uma matrícula para efetuar a Exclusão");
                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
