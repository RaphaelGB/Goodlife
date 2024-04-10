namespace Goodlife
{
    partial class TelaFuncionario
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
			this.lbl_boasvindas = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.btn_addMed = new System.Windows.Forms.Button();
			this.btn_VerAgenda = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lbl_boasvindas
			// 
			this.lbl_boasvindas.AutoSize = true;
			this.lbl_boasvindas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lbl_boasvindas.Location = new System.Drawing.Point(56, 17);
			this.lbl_boasvindas.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.lbl_boasvindas.Name = "lbl_boasvindas";
			this.lbl_boasvindas.Size = new System.Drawing.Size(0, 20);
			this.lbl_boasvindas.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(232, 46);
			this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(460, 34);
			this.label1.TabIndex = 1;
			this.label1.Text = "Escolha uma das funcionalidades";
			// 
			// linkLabel1
			// 
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
			this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.linkLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.linkLabel1.Location = new System.Drawing.Point(427, 417);
			this.linkLabel1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(62, 31);
			this.linkLabel1.TabIndex = 2;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "Sair";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// btn_addMed
			// 
			this.btn_addMed.BackColor = System.Drawing.Color.RoyalBlue;
			this.btn_addMed.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btn_addMed.Location = new System.Drawing.Point(192, 195);
			this.btn_addMed.Margin = new System.Windows.Forms.Padding(6);
			this.btn_addMed.Name = "btn_addMed";
			this.btn_addMed.Size = new System.Drawing.Size(222, 108);
			this.btn_addMed.TabIndex = 3;
			this.btn_addMed.Text = "Adicionar médico";
			this.btn_addMed.UseVisualStyleBackColor = false;
			this.btn_addMed.Click += new System.EventHandler(this.btn_addMed_Click);
			// 
			// btn_VerAgenda
			// 
			this.btn_VerAgenda.BackColor = System.Drawing.Color.RoyalBlue;
			this.btn_VerAgenda.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btn_VerAgenda.Location = new System.Drawing.Point(484, 195);
			this.btn_VerAgenda.Margin = new System.Windows.Forms.Padding(6);
			this.btn_VerAgenda.Name = "btn_VerAgenda";
			this.btn_VerAgenda.Size = new System.Drawing.Size(222, 107);
			this.btn_VerAgenda.TabIndex = 4;
			this.btn_VerAgenda.Text = "Ver agendamento";
			this.btn_VerAgenda.UseVisualStyleBackColor = false;
			this.btn_VerAgenda.Click += new System.EventHandler(this.btn_VerAgenda_Click);
			// 
			// TelaFuncionario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Goodlife.Properties.Resources._7_baskhs;
			this.ClientSize = new System.Drawing.Size(914, 505);
			this.Controls.Add(this.btn_VerAgenda);
			this.Controls.Add(this.btn_addMed);
			this.Controls.Add(this.linkLabel1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lbl_boasvindas);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(6);
			this.Name = "TelaFuncionario";
			this.Text = "TelaFuncionario";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_boasvindas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btn_addMed;
        private System.Windows.Forms.Button btn_VerAgenda;
    }
}