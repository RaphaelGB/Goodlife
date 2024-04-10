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
    public partial class TelaFuncionario : Form
    {
        private static String nome_funcionario;
        public TelaFuncionario(String nome)
        {
            InitializeComponent();
            nome_funcionario = nome;
            lbl_boasvindas.Text = "Olá "+nome+", seja bem-vindo";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            var newForm = new TelaInicial();
            newForm.FormClosed += (s, args) => this.Close();
            newForm.ShowDialog();
        }

        private void btn_addMed_Click(object sender, EventArgs e)
        {
            var newForm_Med = new Cadastro_Medico(nome_funcionario);
            newForm_Med.ShowDialog();
        }

        private void btn_VerAgenda_Click(object sender, EventArgs e)
        {

            this.Close();
            var newForm_Vis = new Visualizacao_func(nome_funcionario);
            newForm_Vis.FormClosed += (s, args) => this.Close();
            newForm_Vis.ShowDialog();
        }
    }
}
