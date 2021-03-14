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
    public partial class frmLogin : Form
    {
        private MySqlConnection con = new MySqlConnection("server=localhost; user=root;database=loja;port=3306;password=root;");
        private Boolean retorno = false;
        private DashBoard Form = new DashBoard();
        private frmFuncionarios FormConsFunc = new frmFuncionarios();
        private frmCadVenda FormCadVenda = new frmCadVenda();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void AcessarTelaPrincipal()
        {
            Form.Show();
            Visible = true;
            if (Form.txtCodRestric.Text == "1")
            {
                DesabilitaCampos(true);
            }
            else
            {
                DesabilitaCampos(true);
                Form.menuCadFunc.Enabled = false;
                Form.menuCadProd.Enabled = false;
            }
        }


        private void ConexaoBanco()
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

        private void btnLogar_Click(object sender, EventArgs e)
        {
            Form = new DashBoard();
            if (txtLogin.Text == "")
            {
                MessageBox.Show("Digite um Login", "Atenção");
            }
            else if(txtSenha.Text == "") {
                MessageBox.Show("Digite uma Senha", "Atenção");
            }
            else {
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
                        MessageBox.Show("Verifique Login e Senha digitado", "Atenção");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void DesabilitaCampos(Boolean Enabled) {
            Form.menuCadFunc.Enabled = Enabled;
            Form.menuConsFunc.Enabled = Enabled;
            Form.menuCadProd.Enabled = Enabled;
            Form.menuConsProd.Enabled = Enabled;
            Form.menuCadVenda.Enabled = Enabled;
            Form.menuConsVenda.Enabled = Enabled;
            Form.menuConsEstoque.Enabled = Enabled;
        }
    }
}