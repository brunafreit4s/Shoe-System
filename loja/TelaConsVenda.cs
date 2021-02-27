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
    public partial class TelaConsVenda : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost; user=root;database=loja;port=3306;password=root;");

        public TelaConsVenda()
        {
            InitializeComponent();
        }

        private void TelaConsVenda_Load(object sender, EventArgs e)
        {

        }

        public DataTable consVendaCliente()
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select codVenda As Código, nomeCliente As Nome_Cliente, cpfCliente As CPF_Cliente," +
            "dataCompra As Data_Compra, nomeFuncionario As Nome_Funcionário, cpfFuncionario As Nome_Funcionário, " +
            "nomeProd As Nome_Produto, quantidade As Quantidade, codBarras As Código_Barras, tipoPagamento As Tipo_Pagamento, " +
            "numParcelas As Número_Parcelas, valorParcela As Valor_Parcela, valorUnitario As Preço_Produto, " +
            "desconto As Desconto, total As Total from Venda where cpfCliente = '" + txtCpfCliente.Text + "'";
            MySqlDataReader rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rdr);
            con.Close();
            return dt;
        }

        public DataTable consVendaFunc()
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select codVenda As Código, nomeCliente As Nome_Cliente, cpfCliente As CPF_Cliente," +
            "dataCompra As Data_Compra, nomeFuncionario As Nome_Funcionário, cpfFuncionario As Nome_Funcionário, " +
            "nomeProd As Nome_Produto, quantidade As Quantidade, codBarras As Código_Barras, tipoPagamento As Tipo_Pagamento, " +
            "numParcelas As Número_Parcelas, valorParcela As Valor_Parcela, valorUnitario As Preço_Produto, " +
            "desconto As Desconto, total As Total from Venda where cpfFuncionario = '" + txtCpfVendedor.Text + "'";
            MySqlDataReader rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rdr);
            con.Close();
            return dt;
        }

        public DataTable consVenda()
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select codVenda As Código, nomeCliente As Nome_Cliente, cpfCliente As CPF_Cliente," +
            "dataCompra As Data_Compra, nomeFuncionario As Nome_Funcionário, cpfFuncionario As Nome_Funcionário, " +
            "nomeProd As Nome_Produto, quantidade As Quantidade, codBarras As Código_Barras, tipoPagamento As Tipo_Pagamento, " +
            "numParcelas As Número_Parcelas, valorParcela As Valor_Parcela, valorUnitario As Preço_Produto, " +
            "desconto As Desconto, total As Total from Venda";
            MySqlDataReader rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rdr);
            con.Close();
            return dt;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (txtCpfCliente.Text != "   ,   ,   -")
            {
                dataGridView1.DataSource = consVendaCliente();
                txtCpfCliente.Text = "";
            }
            else if (txtCpfVendedor.Text != "   ,   ,   -")
            {
                dataGridView1.DataSource = consVendaFunc();
                txtCpfVendedor.Text = "";
            }
            else
            {
                dataGridView1.DataSource = consVenda();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCpfCliente.Text = "";
            txtCpfVendedor.Text = "";
        }
    }
}
