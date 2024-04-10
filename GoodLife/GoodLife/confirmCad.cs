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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Goodlife
{
    public partial class confirmCad : Form
    {
        private MySqlConnection Conexao;
        private string data_source = "datasource=localhost; username=root;password=root;database=bd_goodlife";
        private string nome;
        private string email;
        private int senha, senha_desc;

        
        
        public confirmCad(string nome, string email, int senha)
        {
            InitializeComponent();
            this.nome = nome;
            this.email = email;
            this.senha = senha;
        }

        private void lnk_return_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            this.Hide();
            Login_Funcionario FrmTFunc = new Login_Funcionario();
            FrmTFunc.FormClosed += (s, args) => this.Close();
            FrmTFunc.ShowDialog();
        }

        private void btn_verifCad_Click(object sender, EventArgs e)
        {
            
            try
            {
                 int senha_id, senha_form;
                string senha_tipo;
                senha_form = Convert.ToInt32(txt_verifCad.Text);

                Conexao = new MySqlConnection(data_source);
                Conexao.Open();

                MySqlCommand password = new MySqlCommand();
                password.Connection = Conexao;
                password.CommandText = "SELECT * FROM TB_SENHA WHERE TB_SENHA_ID = 1;";

                
                MySqlDataReader list_pass = password.ExecuteReader();

                while (list_pass.Read())
                {
                        senha_id = Convert.ToInt32(list_pass.GetString(0));
                    senha_desc = Convert.ToInt32(list_pass.GetString(1));
                    senha_tipo = list_pass.GetString(2);
                }
                MessageBox.Show(senha_desc.ToString()) ;
                Conexao.Close();
                
                if (senha_desc == senha_form)
                {
                    Conexao.Open();
                    MySqlCommand cmd = new MySqlCommand();

                    cmd.Connection = Conexao;

                    cmd.CommandText = " INSERT INTO tb_funcionario" +
                    "(TB_FUNCIONARIO_NOME, TB_FUNCIONARIO_EMAIL, TB_FUNCIONARIO_SENHA)" +
                    "VALUES" +
                    "(@nome, @email, @senha);";

                    cmd.Parameters.Clear();


                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@senha", senha);


                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Funcionário inserido com sucesso!",
                        "Sucesso!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    this.Hide();
                    var x = new Login_Funcionario();
                    x.FormClosed += (s, args) => this.Close();
                    x.ShowDialog();

                } else
                {
                    MessageBox.Show("ERROR");
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
            { Conexao.Close(); }
        }
        
}
}

