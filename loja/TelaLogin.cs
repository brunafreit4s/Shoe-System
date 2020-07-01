using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Server;
using Microsoft.SqlServer;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace loja
{
    public partial class TelaLogin : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost; user=root;database=loja;port=3306;password=root;");
        Boolean retorno = false;
        TelaPrincipal Form = new TelaPrincipal();
        TelaConsFunc FormConsFunc = new TelaConsFunc();

        public TelaLogin()
        {
            InitializeComponent();
        }

        public void AcessarTelaPrincipal()
        {
            Form.Show();
            Visible = true;
            if (Form.txtCodRestric.Text == "1")
            {
                Form.menuCadFunc.Enabled = true;
                Form.menuConsFunc.Enabled = true;
                Form.menuCadProd.Enabled = true;
                Form.menuConsProd.Enabled = true;
                Form.menuCadVenda.Enabled = true;
                Form.menuConsVenda.Enabled = true;
                Form.menuCadEstoque.Enabled = true;
                Form.menuConsEstoque.Enabled = true;
            }
            else
            {
                Form.menuCadFunc.Enabled = false;
                Form.menuConsFunc.Enabled = true;
                Form.menuCadProd.Enabled = false;
                Form.menuConsProd.Enabled = true;
                Form.menuCadVenda.Enabled = false;
                Form.menuConsVenda.Enabled = true;
                Form.menuCadEstoque.Enabled = false;
                Form.menuConsEstoque.Enabled = true;
            }
        }


        public void ConexaoBanco()
        {
            int i = 0;
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from funcionario where login='" + txtLogin.Text + "' and senha='" + txtSenha.Text + "' ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());
            MySqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.Read())
            {
                Form.txtNome.Text = rdr[2].ToString();
                Form.txtCpf.Text = rdr[3].ToString();
                Form.txtCodRestric.Text = rdr[7].ToString();
            }

            if (i > 0)
            {
                retorno = true;
            }
            else
            {
                retorno = false;
            }

            con.Close();
        }

        private void TelaLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            Form = new TelaPrincipal();
            if (txtLogin.Text != "" && txtSenha.Text != "")
            {
                try
                { //Tratando erro na conexão com o banco
                    ConexaoBanco();

                    if (retorno == true)
                    {
                        Form.txtCpf.Enabled = false;
                        Form.txtNome.Enabled = false;
                        AcessarTelaPrincipal();
                    }
                    else
                    {
                        MessageBox.Show("Verifique Login e Senha digitado");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Digite um Login e uma Senha");
            }

        }
    }
}