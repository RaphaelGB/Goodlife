using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Goodlife
{
    public partial class Prontuario : Form
    {
        private static string nome_func, especializacao, nome_paciente, dt_consulta, horario, retorno;
        private static int id_agend;
        private MySqlConnection Conexao;
        private string data_source = "datasource=localhost; username=root;password=root;database=bd_goodlife";


        public Prontuario(String nome, String esp, String paciente, String dtconsulta, String hora, String ret, int id_agendamento)
        {
            InitializeComponent();
            nome_func = nome;
            especializacao = esp;
            nome_paciente = paciente;
            dt_consulta = dtconsulta;
            horario = hora;
            retorno = ret;
            id_agend = id_agendamento;

        }

        //Update do agendamento
        private void btn_Confirm_Click(object sender, EventArgs e)
        {

            string newdate, newhorario, newretorno;
            newdate = txt_dt_consult.Text;
            newhorario = txt_horario.Text;
            newretorno = txt_retorno.Text;

            DateTime startDate;
            string[] formats = { "dd/MM/yyyy", "dd/M/yyyy", "d/M/yyyy", "d/MM/yyyy",
                                "dd/MM/yy", "dd/M/yy", "d/M/yy", "d/MM/yy", "MM/dd/yyyy"};

            DateTime.TryParseExact(newdate, formats,
            System.Globalization.CultureInfo.InvariantCulture,
            System.Globalization.DateTimeStyles.None, out startDate);

            newdate = startDate.ToString("yyyy-MM-dd");


            if (newretorno != "" && newhorario != "" && newdate != "")
            {
                DialogResult confirm = MessageBox.Show(this, 
                    "Você deseja mesmo fazer o update?", 
                    "Confirmar alteração", 
                    MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        Conexao = new MySqlConnection(data_source);
                        Conexao.Open();

                        MySqlCommand cmd = new MySqlCommand();

                        cmd.Connection = Conexao;

                        cmd.CommandText = @"
                    Update TB_AGENDAMENTO as a 
                    set a.TB_AGENDAMENTO_DT_CONSULTA = @date, 
                    a.TB_AGENDAMENTO_HORARIO = @horario, 
                    a.TB_AGENDAMENTO_RETORNO = @retorno
                    where a.TB_AGENDAMENTO_ID = @id;";

                        cmd.Parameters.Clear();

                        cmd.Parameters.AddWithValue("@date", newdate);
                        cmd.Parameters.AddWithValue("@horario", newhorario);
                        cmd.Parameters.AddWithValue("@retorno", newretorno);
                        cmd.Parameters.AddWithValue("@id", id_agend);


                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Alteração feita com sucesso!",
                            "Update feito com sucesso",
                            MessageBoxButtons.OK, 
                            MessageBoxIcon.Information);
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
            } else
            {
                MessageBox.Show("Você deve preencher todos os campos!");
                resetCampos();
            }

        }

     
        private void resetCampos()
        {
            txt_dt_consult.Text = dt_consulta;
            txt_horario.Text = horario;
            txt_retorno.Text = retorno;
        }


        private void Prontuario_Load(object sender, EventArgs e)
        {
            txt_nome.Text = nome_paciente;
            txt_esp.Text = especializacao;
            txt_dt_consult.Text = dt_consulta;
            txt_horario.Text = horario;
            txt_retorno.Text = retorno;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Visualizacao_func FrmVFunc = new Visualizacao_func(nome_func);
            FrmVFunc.FormClosed += (s, args) => this.Close();
            FrmVFunc.ShowDialog();
        }

    }
}
