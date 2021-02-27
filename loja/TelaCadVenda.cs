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
    public partial class TelaCadVenda : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost; user=root;database=loja;port=3306;password=root;");
        int totalAtual = 0; //Quantidade Atual no Estoque
        int quantidade = 0;

        public TelaCadVenda()
        {
            InitializeComponent();
        }

        private void chkParcelado_CheckedChanged(object sender, EventArgs e)
        {
            if (chkParcelado.Checked == true)
            {
                txtParcelas.Enabled = true;
                txtValorParcela.Enabled = true;
            }
            else
            {
                txtParcelas.Enabled = false;
                txtValorParcela.Enabled = false;
            }
        }

        private void TelaCadVenda_Load(object sender, EventArgs e)
        {
            //Preenche o ComboBox com os cadastros da Tabela - Tipo de Pagamento
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select TipoPag from TipoPagamento";
            MySqlDataReader rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rdr);
            cboTipoPagamento.DisplayMember = "TipoPag";
            cboTipoPagamento.DataSource = dt;
            con.Close();
        }

        private void txtQuantidade_ValueChanged(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "")
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select codProd, nomeProd, codigoBarras, precoProd, quantidadeProd from Produto where codProd='" + txtCodigo.Text + "'";
                MySqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    txtCodigo.Text = rdr[0].ToString();
                    txtProduto.Text = rdr[1].ToString();
                    txtCodigoBarra.Text = rdr[2].ToString();
                    txtValorUnitario.Text = rdr[3].ToString();
                    quantidade = Convert.ToInt32(rdr[4].ToString());
                }
                else
                {
                    MessageBox.Show("Não existe Produto cadastrado com esse Código!", "Atenção!");
                }
                con.Close();
            }
            else if (txtCodigoBarra.Text != "")
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select codProd, nomeProd, codigoBarras, precoProd from Produto where codigoBarras='" + txtCodigoBarra.Text + "'";
                MySqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    txtCodigo.Text = rdr[0].ToString();
                    txtProduto.Text = rdr[1].ToString();
                    txtCodigoBarra.Text = rdr[2].ToString();
                    txtValorUnitario.Text = rdr[3].ToString();
                }
                else
                {
                    MessageBox.Show("Não existe Produto cadastrado com esse Código de Barras!", "Atenção!");
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Por favor digite um Código ou Código de Barras de um Produto Cadastrado.", "Atenção");
            }

        }

        private void txtParcelas_ValueChanged(object sender, EventArgs e)
        {
            if (txtParcelas.Text == "0")
            {
                txtParcelas.Text = "1";
                txtValorParcela.Text = txtValorUnitario.Text;
            }
        }

        private void txtDesconto_MouseHover(object sender, EventArgs e)
        {
            if (txtValorUnitario.Text != "   ,")
            {
                double dbValorUni = Convert.ToDouble(txtValorUnitario.Text);
                double dbParcela = (dbValorUni / (Convert.ToInt32(txtParcelas.Text)));
                if (dbParcela < 100)
                {
                    txtValorParcela.Text = "0" + Convert.ToString(dbParcela) + "00";
                }
                else
                {
                    txtValorParcela.Text = Convert.ToString(dbParcela) + "00";
                }
            }
        }

        private void btnCadastrar_MouseHover(object sender, EventArgs e)
        {
            if (txtValorUnitario.Text != "   ,")
            {
                if (txtDesconto.Text == "   ,")
                {
                    txtDesconto.Text = "000,00";
                }
                double dbValorUni = Convert.ToDouble(txtValorUnitario.Text);
                double dbValorDesc = Convert.ToDouble(txtDesconto.Text);
                double dbtotal = dbValorUni - dbValorDesc;
                if (dbtotal < 100)
                {
                    txtValorTotal.Text = "0" + Convert.ToString(dbtotal);
                }
                else
                {
                    txtValorTotal.Text = Convert.ToString(dbtotal) + "00";
                }
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCliente.Text == "")
                {
                    MessageBox.Show("Digite o Nome do Cliente", "Atenção");
                }
                else if (txtCpfCliente.Text == "   .   .   -  ")
                {
                    MessageBox.Show("É necessário o CPF do Cliente", "Atenção");
                }
                else if (txtCpfCliente.Text == "000.000.000-00")
                {
                    MessageBox.Show("O CPF do Cliente deve ser Válido", "Atenção");
                }
                else if (txtCpfVendedor.Text == "   .   .   -  ")
                {
                    MessageBox.Show("É necessário o CPF do Vendedor", "Atenção");
                }
                else if (txtCpfVendedor.Text == "000.000.000-00")
                {
                    MessageBox.Show("O CPF do Vendedor deve ser Válido", "Atenção");
                }
                else if (txtCodigo.Text == "")
                {
                    MessageBox.Show("É necessário um Produto", "Atenção");
                }
                else if (txtCodigoBarra.Text == "")
                {
                    MessageBox.Show("É necessário um Produto", "Atenção");
                }
                else if (Convert.ToInt32(txtQuantidade.Text) > quantidade)
                {
                    MessageBox.Show("A Quantidade de produtos é maior do que a cadastrada no Estoque", "Atenção");
                }
                else if (txtValorUnitario.Text == "000.00")
                {
                    MessageBox.Show("O Valor Unitário não pode ser 0", "Atenção");
                }
                else if (txtValorUnitario.Text == "   .  ")
                {
                    MessageBox.Show("É necessário digitar um Valor Unitário", "Atenção");
                }
                else if (chkParcelado.Checked == true)
                {
                    if (txtValorParcela.Text == "   .  ")
                    {
                        MessageBox.Show("É necessário digitar Valor da Parcela", "Atenção");
                    }
                    else if (txtValorParcela.Text == "000.00")
                    {
                        MessageBox.Show("O Valor da Parcela não pode ser 0", "Atenção");
                    }
                    else if (txtParcelas.Text == "0")
                    {
                        MessageBox.Show("A Quantidade de Parcelas não pode ser 0", "Atenção");
                    }
                }
                else if (txtValorTotal.Text == "   .  ")
                {
                    //Não efetua o cadastro até atualizar o textBox com o Valor total
                }
                else
                {
                    incluirVenda();
                    retiraEstoque();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void incluirVenda()
        {
            con.Open();
            string sql = "insert into Venda(nomeCliente, cpfCliente, dataCompra, nomeFuncionario, cpfFuncionario, codProd, nomeProd, quantidade, codBarras, tipoPagamento, numParcelas, valorParcela, valorUnitario,desconto, total) values('" + txtCliente.Text + "', '" + txtCpfCliente.Text + "', '" + Convert.ToDateTime(txtDataCompra.Text).ToString("yyyy/MM/dd") + "', '" + txtVendedor.Text + "', '" + txtCpfVendedor.Text + "', '" + txtCodigo.Text + "', '" + txtProduto.Text + "', '" + txtQuantidade.Text + "', '" + txtCodigoBarra.Text + "', '" + cboTipoPagamento.Text + "', '" + txtParcelas.Text + "', '" + txtValorParcela.Text + "', '" + txtValorUnitario.Text + "', '" + txtDesconto.Text + "', '" + txtValorTotal.Text + "')";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Venda Cadastrada.", "Atenção");
            con.Close();
        }

        private void retiraEstoque()
        {
            totalAtual = 0;
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select quantidadeProdEstoq from Estoque where fk_codProd='" + txtCodigo.Text + "'";
            MySqlDataReader rdr = cmd.ExecuteReader();
            int quantidade = 0;
            int quantidadePedido = 0; //Quantidade Digitada na Venda            
            if (rdr.Read())
            {
                quantidade = Convert.ToInt32(rdr[0].ToString());
            }

            quantidadePedido = Convert.ToInt32(txtQuantidade.Text);
            totalAtual = quantidade - quantidadePedido;
            con.Close();
            atualizarEstoque();
        }

        private void atualizarEstoque()
        {
            con.Open();
            string sql = "update Estoque set quantidadeProdEstoq = '" + totalAtual + "' where fk_codProd = '" + txtCodigo.Text + "'";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}

