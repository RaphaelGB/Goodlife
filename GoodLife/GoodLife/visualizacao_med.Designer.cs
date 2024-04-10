namespace Goodlife
{
    partial class visualizacao_med
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
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
			this.SuspendLayout();
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.label8.Location = new System.Drawing.Point(586, 224);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(67, 20);
			this.label8.TabIndex = 25;
			this.label8.Text = "Retorno";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.label3.Location = new System.Drawing.Point(556, 73);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(130, 20);
			this.label3.TabIndex = 24;
			this.label3.Text = "Data da consulta";
			// 
			// lbl_dt_consult
			// 
			this.lbl_dt_consult.BackColor = System.Drawing.SystemColors.ControlLight;
			this.lbl_dt_consult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lbl_dt_consult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_dt_consult.Location = new System.Drawing.Point(568, 104);
			this.lbl_dt_consult.Name = "lbl_dt_consult";
			this.lbl_dt_consult.Size = new System.Drawing.Size(100, 26);
			this.lbl_dt_consult.TabIndex = 23;
			this.lbl_dt_consult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbl_Horario
			// 
			this.lbl_Horario.BackColor = System.Drawing.SystemColors.ControlLight;
			this.lbl_Horario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lbl_Horario.Location = new System.Drawing.Point(568, 180);
			this.lbl_Horario.Name = "lbl_Horario";
			this.lbl_Horario.Size = new System.Drawing.Size(99, 26);
			this.lbl_Horario.TabIndex = 22;
			this.lbl_Horario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbl_Retorno
			// 
			this.lbl_Retorno.BackColor = System.Drawing.SystemColors.ControlLight;
			this.lbl_Retorno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lbl_Retorno.Location = new System.Drawing.Point(568, 258);
			this.lbl_Retorno.Name = "lbl_Retorno";
			this.lbl_Retorno.Size = new System.Drawing.Size(99, 25);
			this.lbl_Retorno.TabIndex = 21;
			this.lbl_Retorno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.label2.Location = new System.Drawing.Point(590, 145);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(61, 20);
			this.label2.TabIndex = 20;
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
			this.lst_agenda.Location = new System.Drawing.Point(45, 73);
			this.lst_agenda.MultiSelect = false;
			this.lst_agenda.Name = "lst_agenda";
			this.lst_agenda.Size = new System.Drawing.Size(414, 271);
			this.lst_agenda.TabIndex = 19;
			this.lst_agenda.UseCompatibleStateImageBehavior = false;
			this.lst_agenda.View = System.Windows.Forms.View.Details;
			this.lst_agenda.SelectedIndexChanged += new System.EventHandler(this.lst_agenda_SelectedIndexChanged);
			this.lst_agenda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lst_agenda_KeyDown_1);
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
			this.label1.Location = new System.Drawing.Point(136, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(268, 31);
			this.label1.TabIndex = 18;
			this.label1.Text = "Agenda de pacientes";
			// 
			// visualizacao_med
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Goodlife.Properties.Resources._7_baskhs;
			this.ClientSize = new System.Drawing.Size(749, 394);
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
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "visualizacao_med";
			this.Text = "visualizacao_med";
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
    }
}