using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Goodlife
{
    public partial class Login_Funcionario : Form
    {

        private MySqlConnection Conexao;
        private string data_source = "datasource=localhost; username=root;password=root;database=bd_goodlife";
        public static string nome;
        public Login_Funcionario()
        {
            InitializeComponent();
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {

            try
            {
                int senha = Convert.ToInt32(txt_Senha.Text);
                string email = txt_email.Text;
                Conexao = new MySqlConnection(data_source);
                Conexao.Open();
                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = Conexao;

                cmd.CommandText = "SELECT * FROM tb_funcionario WHERE tb_funcionario_senha = @senha AND tb_funcionario_email = @email";

                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@senha", senha);
                cmd.Parameters.AddWithValue("@email", email);

                MySqlDataReader read = cmd.ExecuteReader();
                if (read.Read())
                {
                    nome = read.GetString(2);
                    this.Hide();
                    var newForm_TInicial = new TelaFuncionario(nome);
                    newForm_TInicial.FormClosed += (s, args) => this.Close();
                    newForm_TInicial.Show();
                }
                else
                {
                    MessageBox.Show("Senha Inválida");
                   
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro" + ex.Number + "ocorreu" + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu" + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Conexao.Close();
            }
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            this.Hide();
               var x = new Cadastro_Funcionario();
            x.FormClosed += (s, args) => this.Close();
            x.Show();
            }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            TelaInicial FrmTInicial = new TelaInicial();
            FrmTInicial.FormClosed += (s, args) => this.Close();
            FrmTInicial.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
