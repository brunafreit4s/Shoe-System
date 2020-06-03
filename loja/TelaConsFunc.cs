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
    public partial class TelaConsFunc : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost; user=root;database=loja;port=3306;password=root;");
        Boolean retorno = false;

        public TelaConsFunc()
        {
            InitializeComponent();
        }

        public void ConsultaBanco()
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from funcionario where codFuncionario='" + txtMatricula.Text + "' or nomeFunc='" + txtNome.Text + "' or cpf='" + txtCpf.Text + "'";
            MySqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.Read())
            {
                txtMatricula.Text = rdr[0].ToString();
                comboCargo.Text = rdr[1].ToString();
                txtNome.Text = rdr[2].ToString();
                txtCpf.Text = rdr[3].ToString();
                txtRg.Text = rdr[4].ToString();
                txtEndereco.Text = rdr[5].ToString();
                txtDataNasc.Text = rdr[6].ToString();
                txtTelefone.Text = rdr[8].ToString();
                txtCelular.Text = rdr[9].ToString();
                txtNumEndereco.Text = rdr[10].ToString();
                txtCidade.Text = rdr[11].ToString();
                txtUf.Text = rdr[12].ToString();
                txtEmail.Text = rdr[13].ToString();
                txtBairro.Text = rdr[14].ToString();
                txtCep.Text = rdr[15].ToString();
                txtLogin.Text = rdr[16].ToString();
                txtSenha.Text = rdr[17].ToString();
                retorno = true;
            }
            else
            {
                retorno = false;
                rdr.Close();
            }

            con.Close();
        }

        private void TelaConsFunc_Load(object sender, EventArgs e)
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

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (txtMatricula.Text != "" | txtNome.Text != "" | txtCpf.Text != "")
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
                MessageBox.Show("É nescessário uma Matrícula, ou Nome, ou CPF do Funcionário!");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtMatricula.Text = "";
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

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNome.Text != "")
                {
                    if (txtCpf.Text != "")
                    {
                        if (txtLogin.Text != "")
                        {
                            TelaPrincipal tl = new TelaPrincipal();
                            con.Open();

                            if (comboCargo.Text == "Gerente")
                            {
                                tl.txtCodRestric.Text = "1";
                            }
                            else
                            {
                                tl.txtCodRestric.Text = "2";
                            }

                            string sql = "update funcionario set nomeCargo = '" + comboCargo.Text + "', nomeFunc = '" + txtNome.Text + "', cpf = '" + txtCpf.Text + "', RG = '" + txtRg.Text + "', endereco = '" + txtEndereco.Text + "', dataNascimento = '" + Convert.ToDateTime(txtDataNasc.Text).ToString("yyyy/MM/dd") + "', codRestricao = '" + tl.txtCodRestric.Text + "', telefone = '" + txtTelefone.Text + "', celular = '" + txtCelular.Text + "', numeroEndereco = '" + txtNumEndereco.Text + "', cidade = '" + txtCidade.Text + "', UF = '" + txtUf.Text + "', email = '" + txtEmail.Text + "', bairro = '" + txtBairro.Text + "', CEP = '" + txtCep.Text + "', login = '" + txtLogin.Text + "', senha = '" + txtSenha.Text + "' where codFuncionario ='" + txtMatricula.Text + "'";
                            MySqlCommand cmd = new MySqlCommand(sql, con);
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Funcionário Alterado.");
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
                        else
                        {
                            MessageBox.Show("É nescessário digitar um login de acesso ao Sistema");
                        }
                    }
                    else
                    {
                        MessageBox.Show("É nescessário digitar um CPF");
                    }
                }
                else
                {
                    MessageBox.Show("É nescessário digitar um Nome");
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
                if (txtMatricula.Text != "")
                {
                    con.Open();
                    string sql = "delete from funcionario where codFuncionario ='" + txtMatricula.Text + "'";

                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Funcionário Excluído.");
                    txtMatricula.Text = "";
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
                else {
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
