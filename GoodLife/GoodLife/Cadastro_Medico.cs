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

namespace Goodlife
{
    public partial class Cadastro_Medico : Form
    {
        private static string nome_func;
        private MySqlConnection Conexao;
        private string data_source = "datasource=localhost; username=root;password=root;database=bd_goodlife";
        public Cadastro_Medico(String nome)
        {
            InitializeComponent();
            nome_func = nome;
        
        }

        private void btn_Cadastro_Click(object sender, EventArgs e)
        {
            
            if (txt_Crm.Text == txt_ConfirmCRM.Text)
            {

                try
                {

                    Conexao = new MySqlConnection(data_source);
                    Conexao.Open();

                    MySqlCommand cmd = new MySqlCommand();

                    cmd.Connection = Conexao;

                    cmd.CommandText = "INSERT INTO tb_medico" +
                        "(TB_MEDICO_CRM, TB_MEDICO_NOME, TB_MEDICO_ESPECIALIZACAO, TB_MEDICO_PRECO)" +
                        "VALUES" +
                        "(@crm, @nome, @especializacao, @preco)";

                    cmd.Parameters.Clear();


                    cmd.Parameters.AddWithValue("@crm", txt_Crm.Text);
                    cmd.Parameters.AddWithValue("@nome", txt_Nome.Text);
                    cmd.Parameters.AddWithValue("@especializacao", txt_espec.Text);
                    cmd.Parameters.AddWithValue("@preco", txt_preco.Text);


                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Médico inserido com sucesso!",
                        "Sucesso!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                        this.Close();
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
            } else
            {
                MessageBox.Show("Erro! o confirmar senha deve ser igual a senha",
                    "Erro confirmar senha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            limparCampos();
        }

        public void limparCampos()
        {
            txt_ConfirmCRM.Text = string.Empty;
            txt_Crm.Text = string.Empty;
            txt_espec.Text = string.Empty;
            txt_Nome.Text = string.Empty;

        }

        private void lnk_return_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            TelaFuncionario FrmTFunc = new TelaFuncionario(nome_func);
            FrmTFunc.FormClosed += (s, args) => this.Close();
            FrmTFunc.ShowDialog();
        }
    }
}
