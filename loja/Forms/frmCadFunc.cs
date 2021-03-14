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
    public partial class frmCadFunc : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost; user=root;database=loja;port=3306;password=root;");

        private String msgError;

        public frmCadFunc()
        {
            InitializeComponent();
        }

        private void frmCadFunc_Load(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos())
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

                    MessageBox.Show("Funcionário Cadastrado.", "Atenção");
                    LimparCampos();
                    con.Close();
                }
                else
                {
                    MessageBox.Show(msgError, "Atenção!");
                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.ToString());
            }
        }

        private Boolean ValidarCampos()
        {
            if (txtNome.Text == "") { msgError = "É necessário digitar um Nome"; return false; }

            if (txtRg.Text == "  ,   ,   -") { msgError = "É necessário digitar um RG"; return false; }

            if (txtRg.Text == "00,000,000-0") { msgError = "É necessário digitar um RG Válido"; return false; }

            if (txtCpf.Text == "   ,   ,   -") { msgError = "É necessário digitar um CPF"; return false; }

            if (txtCpf.Text == "000,000,000-0") { msgError = "É necessário digitar um CPF Válido"; return false; }

            if (txtTelefone.Text == "(  )    -    ") { msgError = "É necessário digitar um Telefone"; return false; }

            if (txtTelefone.Text == "(00)0000-0000") { msgError = "É necessário digitar um Telefone Válido"; return false; }

            if (txtCelular.Text == "(  )     -    ") { msgError = "É necessário digitar um Celular"; return false; }

            if (txtCelular.Text == "(00)00000-0000") { msgError = "É necessário digitar um Celular Válido"; return false; }

            if (txtNumEndereco.Text == "") { msgError = "É necessário digitar um Número de Endereço"; return false; }

            if (txtNumEndereco.Text == "0000") { msgError = "É necessário digitar um Número de Endereço Válido"; return false; }

            if (txtCep.Text == "  .   -   ") { msgError = "É necessário digitar um Cep"; return false; }

            if (txtCep.Text == "00.000-000") { msgError = "É necessário digitar um Cep Válido"; return false; }

            if (txtLogin.Text == "") { msgError = "É necessário digitar um Login de acesso ao Sistema"; return false; }

            if (txtSenha.Text == "") { msgError = "É necessário digitar um Senha de acesso ao Sistema"; return false; }

            return true;
        }

        private void LimparCampos()
        {
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
        }
    }
}
