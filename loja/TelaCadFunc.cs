using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace loja
{
    public partial class TelaCadFunc : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost; user=root;database=loja;port=3306;password=root;");

        public TelaCadFunc()
        {
            InitializeComponent();
        }

        private void TelaCadFunc_Load(object sender, EventArgs e)
        {
            //Preenche o ComboBox com os cadastros da Tabela - Cargo
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select nomeCargo from Cargo";
            MySqlDataReader rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rdr);
            comboCargo.DisplayMember = "nomeCargo";
            comboCargo.DataSource = dt;
            con.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                int codCombo = 0;
                con.Open();

                if (comboCargo.Text == "Atendente")
                {
                    codCombo = 2;
                }
                else if (comboCargo.Text == "Gerente")
                {
                    codCombo = 1;
                }
                string sql = "insert into funcionario(nomeCargo, nomeFunc, cpf, RG, endereco, dataNascimento, codRestricao, telefone, celular, numeroEndereco, cidade, UF, email, bairro, CEP, login, senha) values('" + comboCargo.Text + "', '" + txtNome.Text + "', '" + txtCpf.Text + "', '" + txtRg.Text + "', '" + txtEndereco.Text + "', '" + Convert.ToDateTime(txtDataNasc.Text).ToString("yyyy/MM/dd") + "', '" + codCombo + "', '" + txtTelefone.Text + "', '" + txtCelular.Text + "', '" + txtNumEndereco.Text + "', '" + txtCidade.Text + "', '" + txtUf.Text + "', '" + txtEmail.Text + "', '" + txtBairro.Text + "', '" + txtCep.Text + "', '" + txtLogin.Text + "', '" + txtSenha.Text + "')";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Funcionário Cadastrado.");
                txtBairro.Text = "";
                txtCelular.Text = "";
                txtCep.Text = "";
                txtCidade.Text = "";
                txtCpf.Text = "";
                txtDataNasc.Text = "";
                txtEmail.Text = "";
                txtEndereco.Text = "";
                txtLogin.Text = "";
                txtNome.Text = "";
                txtNumEndereco.Text = "";
                txtRg.Text = "";
                txtSenha.Text = "";
                txtTelefone.Text = "";
                txtUf.Text = "";
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
