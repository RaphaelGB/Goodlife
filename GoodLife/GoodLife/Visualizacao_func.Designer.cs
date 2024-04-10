namespace Goodlife
{
    partial class Visualizacao_func
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			this.label8 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lbl_dt_consult = new System.Windows.Forms.Label();
			this.lbl_Horario = new System.Windows.Forms.Label();
			this.lbl_Retorno = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lst_agenda = new System.Windows.Forms.ListView();
			this.Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Especializacao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Preco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.label1 = new System.Windows.Forms.Label();
			this.linkLabel2 = new System.Windows.Forms.LinkLabel();
			this.tTp_dicalist = new System.Windows.Forms.ToolTip(this.components);
			this.SuspendLayout();
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.label8.Location = new System.Drawing.Point(551, 219);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(67, 20);
			this.label8.TabIndex = 17;
			this.label8.Text = "Retorno";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.label3.Location = new System.Drawing.Point(520, 67);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(130, 20);
			this.label3.TabIndex = 16;
			this.label3.Text = "Data da consulta";
			// 
			// lbl_dt_consult
			// 
			this.lbl_dt_consult.BackColor = System.Drawing.SystemColors.ControlLight;
			this.lbl_dt_consult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lbl_dt_consult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_dt_consult.Location = new System.Drawing.Point(532, 98);
			this.lbl_dt_consult.Name = "lbl_dt_consult";
			this.lbl_dt_consult.Size = new System.Drawing.Size(100, 26);
			this.lbl_dt_consult.TabIndex = 15;
			this.lbl_dt_consult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbl_Horario
			// 
			this.lbl_Horario.BackColor = System.Drawing.SystemColors.ControlLight;
			this.lbl_Horario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lbl_Horario.Location = new System.Drawing.Point(533, 174);
			this.lbl_Horario.Name = "lbl_Horario";
			this.lbl_Horario.Size = new System.Drawing.Size(99, 26);
			this.lbl_Horario.TabIndex = 14;
			this.lbl_Horario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbl_Retorno
			// 
			this.lbl_Retorno.BackColor = System.Drawing.SystemColors.ControlLight;
			this.lbl_Retorno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lbl_Retorno.Location = new System.Drawing.Point(533, 252);
			this.lbl_Retorno.Name = "lbl_Retorno";
			this.lbl_Retorno.Size = new System.Drawing.Size(99, 25);
			this.lbl_Retorno.TabIndex = 13;
			this.lbl_Retorno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.label2.Location = new System.Drawing.Point(555, 140);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(61, 20);
			this.label2.TabIndex = 12;
			this.label2.Text = "Horário";
			// 
			// lst_agenda
			// 
			this.lst_agenda.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nome,
            this.Especializacao,
            this.Preco});
			this.lst_agenda.FullRowSelect = true;
			this.lst_agenda.HideSelection = false;
			this.lst_agenda.Location = new System.Drawing.Point(10, 67);
			this.lst_agenda.MultiSelect = false;
			this.lst_agenda.Name = "lst_agenda";
			this.lst_agenda.Size = new System.Drawing.Size(414, 271);
			this.lst_agenda.TabIndex = 11;
			this.lst_agenda.UseCompatibleStateImageBehavior = false;
			this.lst_agenda.View = System.Windows.Forms.View.Details;
			this.lst_agenda.SelectedIndexChanged += new System.EventHandler(this.lst_agenda_SelectedIndexChanged);
			this.lst_agenda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lst_agenda_KeyDown);
			// 
			// Nome
			// 
			this.Nome.Text = "Nome";
			this.Nome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.Nome.Width = 150;
			// 
			// Especializacao
			// 
			this.Especializacao.Text = "Especialização";
			this.Especializacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.Especializacao.Width = 147;
			// 
			// Preco
			// 
			this.Preco.Text = "Preço";
			this.Preco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.Preco.Width = 112;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(100, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(268, 31);
			this.label1.TabIndex = 10;
			this.label1.Text = "Agenda de pacientes";
			// 
			// linkLabel2
			// 
			this.linkLabel2.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
			this.linkLabel2.AutoSize = true;
			this.linkLabel2.BackColor = System.Drawing.Color.Transparent;
			this.linkLabel2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.linkLabel2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.linkLabel2.Location = new System.Drawing.Point(6, 422);
			this.linkLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.linkLabel2.Name = "linkLabel2";
			this.linkLabel2.Size = new System.Drawing.Size(51, 20);
			this.linkLabel2.TabIndex = 29;
			this.linkLabel2.TabStop = true;
			this.linkLabel2.Text = "Voltar";
			this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
			// 
			// tTp_dicalist
			// 
			this.tTp_dicalist.AutoPopDelay = 5000;
			this.tTp_dicalist.InitialDelay = 100;
			this.tTp_dicalist.ReshowDelay = 100;
			this.tTp_dicalist.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			// 
			// Visualizacao_func
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Goodlife.Properties.Resources._7_baskhs;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.linkLabel2);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lbl_dt_consult);
			this.Controls.Add(this.lbl_Horario);
			this.Controls.Add(this.lbl_Retorno);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lst_agenda);
			this.Controls.Add(this.label1);
			this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Visualizacao_func";
			this.Text = "Tela do funcionário";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_dt_consult;
        private System.Windows.Forms.Label lbl_Horario;
        private System.Windows.Forms.Label lbl_Retorno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lst_agenda;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader Especializacao;
        private System.Windows.Forms.ColumnHeader Preco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.ToolTip tTp_dicalist;
    }
}

