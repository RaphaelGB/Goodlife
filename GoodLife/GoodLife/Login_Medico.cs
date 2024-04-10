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
    public partial class Login_Medico : Form
    {
        private MySqlConnection Conexao;
        private string data_source = "datasource=localhost; username=root;password=root;database=bd_goodlife";
        private static string nome_func;
        public Login_Medico()
        {
            InitializeComponent();
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            try
            {
                int Crm = Convert.ToInt32(txt_Crm.Text);
                Conexao = new MySqlConnection(data_source);
                Conexao.Open();
                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = Conexao;

                cmd.CommandText = "SELECT * FROM tb_medico WHERE tb_medico_crm = @crm";

                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@crm", Crm);

                MySqlDataReader read = cmd.ExecuteReader();
                if (read.Read())
                {
                    this.Hide();
                    var newForm_VisMed = new visualizacao_med();
                    newForm_VisMed.FormClosed += (s, args) => this.Close();
                    newForm_VisMed.Show();
                }
                else
                {
                    MessageBox.Show("CRM Inválido");
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

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            TelaInicial FrmTInicial = new TelaInicial();
            FrmTInicial.FormClosed += (s, args) => this.Close();
            FrmTInicial.ShowDialog();
           
        }
    }
}
