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
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void btn_LoginFunc_Click(object sender, EventArgs e)
        {

            this.Hide();
            var FrmFunc = new Login_Funcionario();
            FrmFunc.FormClosed += (s, args) => this.Close();
            FrmFunc.ShowDialog();

        }

        private void btn_LoginMed_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Medico FrmMed = new Login_Medico();
            FrmMed.FormClosed += (s, args) => this.Close();
            FrmMed.ShowDialog();
        }
    }
}
