using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;
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
    
    public partial class Cadastro_Funcionario : Form
    {
        private MySqlConnection Conexao;
        private string data_source = "datasource=localhost; username=root;password=root;database=bd_goodlife";




        public Cadastro_Funcionario()
        {
            InitializeComponent();
        }

        private void LimparCampos()
        {
            txt_Nome.Text = string.Empty;
            txt_Email.Text = string.Empty;
            txt_Senha.Text = string.Empty;
            txt_ConfirmSenha.Text = string.Empty;

        }
        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            if (txt_Senha.Text == txt_ConfirmSenha.Text)
            {
                string nome = txt_Nome.Text;
                string email = txt_Email.Text;
                int senha = Convert.ToInt32(txt_Senha.Text);

                this.Hide();
                var FrmConfirm = new confirmCad(nome, email, senha);
                FrmConfirm.FormClosed += (s, args) => this.Close();
                FrmConfirm.ShowDialog();


            }
            else
            {
                MessageBox.Show("A senha está incorreta!");
                LimparCampos();
            } 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login_Funcionario frmLogin =  new Login_Funcionario();
            frmLogin.FormClosed += (s, args) => this.Close();
            frmLogin.ShowDialog();
        }

    }
}
