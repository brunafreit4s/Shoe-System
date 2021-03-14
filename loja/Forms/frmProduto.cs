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
    public partial class frmProduto : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost; user=root;database=loja;port=3306;password=root;");
        Boolean retorno = false;
        Boolean consultarPorCod = false;

        public frmProduto()
        {
            InitializeComponent();
        }

        public void ConsultaBanco()
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            if (consultarPorCod == true)
            {
                cmd.CommandText = "Select a.*, b.nomeTipo, c.fk_codProd from Produto a, TipoProduto b, Estoque c where a.codTipo = b.codTipo and a.codProd='" + txtCodProd.Text + "' and c.fk_codProd = a.codProd ";
            }
            else
            {
                cmd.CommandText = "Select a.*, b.nomeTipo, c.fk_codProd from Produto a, TipoProduto b, Estoque c where a.codTipo = b.codTipo and a.codigoBarras='" + txtCodigoBarra.Text + "' and c.fk_codProd = a.codProd ";
            }
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
            if (txtCodProd.Text != "")
            {
                try
                {
                    consultarPorCod = true;
                    ConsultaBanco();

                    if (retorno == false)
                    {
                        MessageBox.Show("Não foi possível encontrar os valores digitados!", "Atenção");
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
            else if (txtCodigoBarra.Text != "")
            {
                try
                {
                    consultarPorCod = false;
                    ConsultaBanco();

                    if (retorno == false)
                    {
                        MessageBox.Show("Não foi possível encontrar os valores digitados!", "Atenção");
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
                MessageBox.Show("É nescessário um Código do Produto ou um Código de Barras!", "Atenção");
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCodProd.Text != "")
                {
                    if (Convert.ToInt32(txtQuantidade.Text) > 0)
                    {
                        alterarProd();
                        alterarProdEstoque();
                        limparTela();
                        MessageBox.Show("Produto Alterado.");
                    }
                    else
                    {
                        if (MessageBox.Show("A quantidade de Produto é igual a 0. Deseja Excluir o Produto? Também Será Excluído do Estoque!", "Atenção!",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            excluirProdEstoque();
                            excluirProd();                 
                            limparTela();
                            MessageBox.Show("Produto Excluído.", "Atenção");
                        }
                        else
                        {
                            MessageBox.Show("O Produto não foi Deletado do Estoque e não pode ser Alterado com o valor da quantidade igual a 0!", "Atenção!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("É nescessário Consultar um Produto para efetuar a Alteração", "Atenção");
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
                MessageBox.Show("É necessário consultar um Produto para efetuar a Exclusão", "Atenção");
            }
            else
            {
                try
                {
                    excluirProdEstoque();
                    excluirProd();                    
                    limparTela();
                    MessageBox.Show("Produto Excluído.", "Atenção");
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

        private void alterarProdEstoque() {
            con.Open();
            int codCombo = cboTipo.SelectedIndex + 1;
            string sql = "update Estoque set nomeProdEstoq = '" + txtNomeProduto.Text + "', quantidadeProdEstoq = '" + txtQuantidade.Text + "', precoProdEstoq = '" + txtPreco.Text + "', marcaProdEstoq = '" + txtMarca.Text + "', codTipoProdEstoq = '" + codCombo + "' where fk_codProd = '" + txtCodProd.Text + "'";            
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.ExecuteNonQuery();            
            con.Close();
        }

        private void alterarProd() {
            con.Open();
            int codCombo = cboTipo.SelectedIndex + 1;
            string sql = "update Produto set nomeProd = '" + txtNomeProduto.Text + "', quantidadeProd = '" + txtQuantidade.Text + "', dataCadProd = '" + Convert.ToDateTime(txtDtCad.Text).ToString("yyyy/MM/dd") + "', precoProd = '" + txtPreco.Text + "', custoProd = '" + txtCusto.Text + "', marcaProd = '" + txtMarca.Text + "', dataCompraProd = '" + Convert.ToDateTime(txtDtCompra.Text).ToString("yyyy/MM/dd") + "', nomeFornecedor = '" + txtFornecedor.Text + "', codTipo = '" + codCombo + "', descricaoProd = '" + txtDescricao.Text + "', codigoBarras = '" + txtCodigoBarra.Text + "' where codProd ='" + txtCodProd.Text + "'";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void excluirProdEstoque() {
            con.Open();
            string sql = "delete from Estoque where fk_codProd = '" + txtCodProd.Text + "'";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.ExecuteNonQuery();            
            con.Close();
        }

        private void excluirProd() {
            con.Open();
            string sql = "delete from Produto where codProd ='" + txtCodProd.Text + "'";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();            
        }        
    }
}
