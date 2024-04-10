using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace Goodlife
{
    public partial class visualizacao_med : Form
    {
        //Variáveis
        //Banco de dados
        private MySqlConnection Conexao;
        private string data_source = "datasource=localhost; username=root;password=root;database=bd_goodlife";

        //Dados do agendamento
        private string dt_consulta, horario, retorno, especializacao, nome_cliente, nome_func;
        private double preco;


        private int id_agend, id_func, crm_med;

        public visualizacao_med()
        {
            InitializeComponent();
            carregar_contatos();
        }
        private void carregar_contatos()
        {
            try
            {   //Refatoração de código

                Conexao = new MySqlConnection(data_source);

                Conexao.Open();

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = Conexao;

                String sql = @"SELECT a.TB_AGENDAMENTO_ID,
                     a.TB_AGENDAMENTO_DT_CONSULTA,
                    a.TB_AGENDAMENTO_HORARIO, 
                    m.TB_MEDICO_PRECO,
                     a.TB_AGENDAMENTO_RETORNO, 
                    a.TB_AGENDAMENTO_ESP,
                     a.TB_FUNCIONARIO_ID,
                     c.TB_CLIENTE_LOGIN, 
                    a.TB_MEDICO_CRM FROM tb_agendamento AS a
                     INNER JOIN TB_CLIENTE AS c
                     on c.TB_CLIENTE_ID = a.TB_CLIENTE_ID
                    INNER JOIN TB_MEDICO AS m 
                    ON m.TB_MEDICO_CRM = a.TB_MEDICO_CRM";

                cmd.CommandText = sql;
                cmd.Parameters.Clear();

                //Guarda em uma variável tudo o que for lido ao executar o comando
                MySqlDataReader reader = cmd.ExecuteReader();

                //Vai limpar os itens do listView
                lst_agenda.Items.Clear();

                //Passar os dados para a listagem usando while
                while (reader.Read()) //O Reader() - vai ler linha a linha do reader e quando acabar retorna false para o while
                {

                    //Retorna as informações do banco de dados
                    nome_cliente = reader.GetString(7);
                    especializacao = reader.GetString(5);
                    preco = Convert.ToDouble(reader.GetString(3));

                    //Arrumando as linhas do listView
                    string[] row =
                    {
                        nome_cliente,
                        especializacao,
                        preco.ToString(),
                    };

                    //Adiciona no ListView
                    lst_agenda.Items.Add(new ListViewItem(row));
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


        private void lst_agenda_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lst_agenda.SelectedItems.Count > 0)
            {
                ListView.SelectedListViewItemCollection itens_selecionados = lst_agenda.SelectedItems;

                foreach (ListViewItem item in itens_selecionados)
                {
                    nome_cliente = item.SubItems[0].Text;
                    especializacao = item.SubItems[1].Text;
                    preco = Convert.ToDouble(item.SubItems[2].Text);
                }


                Conexao = new MySqlConnection(data_source);

                Conexao.Open();

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = Conexao;

                String sql = @"SELECT a.TB_AGENDAMENTO_ID,
                     a.TB_AGENDAMENTO_DT_CONSULTA, 
                    a.TB_AGENDAMENTO_HORARIO, 
                    m.TB_MEDICO_PRECO,
                     a.TB_AGENDAMENTO_RETORNO, 
                    a.TB_AGENDAMENTO_ESP, 
                    a.TB_FUNCIONARIO_ID, 
                    c.TB_CLIENTE_LOGIN,
                     a.TB_MEDICO_CRM
                     FROM tb_agendamento AS a INNER JOIN TB_CLIENTE AS c
                     ON c.TB_CLIENTE_ID = a.TB_CLIENTE_ID
                        INNER JOIN TB_MEDICO AS m
                    ON m.TB_MEDICO_CRM = a.TB_MEDICO_CRM
                     where c.TB_CLIENTE_LOGIN = @name 
                    AND a.TB_AGENDAMENTO_ESP = @esp;";

                cmd.CommandText = sql;
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@name", nome_cliente);
                cmd.Parameters.AddWithValue("@esp", especializacao);

                //Guarda em uma variável tudo o que for lido ao executar o comando
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read()) //O Reader() - vai ler linha a linha do reader e quando acabar retorna false para o while
                {
                    id_agend = Convert.ToInt32(reader.GetString(0));
                    dt_consulta = reader.GetString(1);
                    horario = reader.GetString(2);
                    preco = Convert.ToDouble(reader.GetString(3));
                    retorno = reader.GetString(4);
                    especializacao = reader.GetString(5);
                    id_func = Convert.ToInt32(reader.GetString(6));
                    nome_cliente = reader.GetString(7);
                    crm_med = Convert.ToInt32(reader.GetString(8));


                }
                string result = (retorno == "true" || retorno == "True") ? retorno = "sim" : retorno = "não";
                lbl_dt_consult.Text = dt_consulta.ToString();
                lbl_Horario.Text = horario.ToString();
                lbl_Retorno.Text = retorno.ToString();
                //carregar_contatos();

            }
        }


        private void lst_agenda_KeyDown_1(object sender, KeyEventArgs e)
        {

            string tecla = e.KeyCode.ToString();
            if (tecla == "Return")
            {
                this.Hide();
                Prontuario_Med FrmProntM = new Prontuario_Med(especializacao, nome_cliente, dt_consulta, horario, retorno, id_agend);
                FrmProntM.FormClosed += (s, args) => this.Close();
                FrmProntM.ShowDialog();

            }
        }
    }
}
