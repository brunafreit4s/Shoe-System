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
    public partial class frmCadProd : Form
    {
        private MySqlConnection con = new MySqlConnection("server=localhost; user=root;database=loja;port=3306;password=root;");
        private int codProd;
        private String msgErro;

        public frmCadProd()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos())
                {
                    cadProduto();
                    cadProdEstoque();
                    LimparTela();
                }
                else
                {
                    MessageBox.Show(msgErro, "Atenação!");
                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.ToString());
            }
        }        

        private void cadProdEstoque()
        {
            getCodProduto();
            con.Open();
            int codCombo = cboTipo.SelectedIndex + 1;
            string sql = "insert into Estoque(nomeProdEstoq, quantidadeProdEstoq, precoProdEstoq, marcaProdEstoq, codTipoProdEstoq, fk_codProd) values('" + txtNomeProduto.Text + "', '" + Convert.ToInt32(txtQuantidade.Text) + "', '" + txtPreco.Text + "', '" + txtMarca.Text + "', '" + codCombo + "', '" + codProd + "')";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void cadProduto()
        {
            con.Open();
            int codCombo = cboTipo.SelectedIndex + 1;
            string sql = "insert into Produto(nomeProd, quantidadeProd, dataCadProd, precoProd, custoProd, marcaProd, dataCompraProd, nomeFornecedor, codTipo, descricaoProd, codigoBarras) values('" + txtNomeProduto.Text + "', '" + txtQuantidade.Text + "', '" + Convert.ToDateTime(txtDtCad.Text).ToString("yyyy/MM/dd") + "', '" + txtPreco.Text + "', '" + txtCusto.Text + "', '" + txtMarca.Text + "', '" + Convert.ToDateTime(txtDtCompra.Text).ToString("yyyy/MM/dd") + "', '" + txtFornecedor.Text + "', '" + codCombo + "', '" + txtDescricao.Text + "', '" + txtCodigoBarra.Text + "')";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Produto Cadastrado.", "Atenção");
            con.Close();
        }

        private void frmCadProd_Load(object sender, EventArgs e)
        {
            //Preenche o ComboBox com os cadastros da Tabela - Tipo de Produto
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

        private void getCodProduto()
        { //Pega o código do Produto para cadastrar no Estoque
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select codProd from Produto where codigoBarras = '" + txtCodigoBarra.Text + "' ";
            MySqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.Read())
            {
                codProd = Convert.ToInt32(rdr[0].ToString());
            }
            con.Close();
        }

        private Boolean ValidarCampos()
        {
            if (txtNomeProduto.Text == "") { MessageBox.Show("É necessário digitar Nome do Produto"); return false; }

            if (txtQuantidade.Text == "0") { MessageBox.Show("A Quantidade deve ser maior que 0"); return false; }

            if (txtPreco.Text == "   ,") { MessageBox.Show("É necessário digitar um Preço"); return false; }

            if (txtPreco.Text == "000,00") { MessageBox.Show("É necessário digitar um Preço Válido"); return false; }

            if (txtCusto.Text == "   ,") { MessageBox.Show("É necessário digitar o Custo"); return false; }

            if (txtCusto.Text == "000,00") { MessageBox.Show("É necessário digitar um Custo Válido"); return false; }

            if (txtMarca.Text == "") { MessageBox.Show("É necessário digitar uma Marca"); return false; }

            if (txtFornecedor.Text == "") { MessageBox.Show("É necessário digitar o Nome do Fornecedor"); return false; }

            if (txtCodigoBarra.Text == "") { MessageBox.Show("É necessário digitar um Código de Barras"); return false; }

            if (txtCodigoBarra.Text == "0000000") { MessageBox.Show("É necessário digitar um Código de Barras Válido"); return false; }

            return true;
        }

        private void LimparTela()
        {
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
    }
}
