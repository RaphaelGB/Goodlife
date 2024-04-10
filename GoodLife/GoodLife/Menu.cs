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
    public partial class Menu : Form
    {
        private static string nome_func;
        public Menu(string nome)
        {
            InitializeComponent();
            nome_func = nome;
        }

        private void btn_cadFunc_Click(object sender, EventArgs e)
        {
            Cadastro_Funcionario cadastro_f = new Cadastro_Funcionario();
            cadastro_f.Show();
        }

        private void btn_cadMed_Click(object sender, EventArgs e)
        {

            Cadastro_Medico cadastro_m = new Cadastro_Medico(nome_func);
            cadastro_m.Show();
        }

        private void btn_LogFunc_Click(object sender, EventArgs e)
        {
            Login_Funcionario Login_f = new Login_Funcionario();
            Login_f.Show();
        }

        private void Log_med_Click(object sender, EventArgs e)
        {

            Login_Medico login_m = new Login_Medico();
            login_m.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Visualizacao_func agendamento = new Visualizacao_func(nome_func);
            agendamento.Show();
        }
    }

       
  
}
