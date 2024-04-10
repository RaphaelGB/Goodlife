namespace Goodlife
{
    partial class Login_Funcionario
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
			this.btn_Confirm = new System.Windows.Forms.Button();
			this.txt_Senha = new System.Windows.Forms.TextBox();
			this.txt_email = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.linkLabel2 = new System.Windows.Forms.LinkLabel();
			this.SuspendLayout();
			// 
			// btn_Confirm
			// 
			this.btn_Confirm.BackColor = System.Drawing.Color.SteelBlue;
			this.btn_Confirm.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
			this.btn_Confirm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btn_Confirm.Location = new System.Drawing.Point(238, 239);
			this.btn_Confirm.Name = "btn_Confirm";
			this.btn_Confirm.Size = new System.Drawing.Size(107, 43);
			this.btn_Confirm.TabIndex = 21;
			this.btn_Confirm.Text = "Login";
			this.btn_Confirm.UseVisualStyleBackColor = false;
			this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
			// 
			// txt_Senha
			// 
			this.txt_Senha.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_Senha.Location = new System.Drawing.Point(118, 167);
			this.txt_Senha.Multiline = true;
			this.txt_Senha.Name = "txt_Senha";
			this.txt_Senha.Size = new System.Drawing.Size(393, 33);
			this.txt_Senha.TabIndex = 20;
			// 
			// txt_email
			// 
			this.txt_email.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_email.Location = new System.Drawing.Point(118, 105);
			this.txt_email.Multiline = true;
			this.txt_email.Name = "txt_email";
			this.txt_email.Size = new System.Drawing.Size(393, 33);
			this.txt_email.TabIndex = 19;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(256, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(87, 34);
			this.label1.TabIndex = 18;
			this.label1.Text = "Login";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 16F);
			this.label3.Location = new System.Drawing.Point(38, 167);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(81, 28);
			this.label3.TabIndex = 23;
			this.label3.Text = "Senha";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 16F);
			this.label2.Location = new System.Drawing.Point(38, 105);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 28);
			this.label2.TabIndex = 22;
			this.label2.Text = "Email";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label4.Location = new System.Drawing.Point(158, 293);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(221, 17);
			this.label4.TabIndex = 24;
			this.label4.Text = "Deseja cadastrar um funcionário?";
			// 
			// linkLabel1
			// 
			this.linkLabel1.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
			this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.linkLabel1.Location = new System.Drawing.Point(383, 293);
			this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(65, 17);
			this.linkLabel1.TabIndex = 25;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "Cadastro";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			this.linkLabel1.Click += new System.EventHandler(this.linkLabel1_Click);
			// 
			// linkLabel2
			// 
			this.linkLabel2.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
			this.linkLabel2.AutoSize = true;
			this.linkLabel2.BackColor = System.Drawing.Color.Transparent;
			this.linkLabel2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.linkLabel2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.linkLabel2.Location = new System.Drawing.Point(9, 356);
			this.linkLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.linkLabel2.Name = "linkLabel2";
			this.linkLabel2.Size = new System.Drawing.Size(37, 20);
			this.linkLabel2.TabIndex = 26;
			this.linkLabel2.TabStop = true;
			this.linkLabel2.Text = "Sair";
			this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
			// 
			// Login_Funcionario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Goodlife.Properties.Resources._7_baskhs;
			this.ClientSize = new System.Drawing.Size(595, 384);
			this.Controls.Add(this.linkLabel2);
			this.Controls.Add(this.linkLabel1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btn_Confirm);
			this.Controls.Add(this.txt_Senha);
			this.Controls.Add(this.txt_email);
			this.Controls.Add(this.label1);
			this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "Login_Funcionario";
			this.Text = "Login_Funcionario";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Confirm;
        private System.Windows.Forms.TextBox txt_Senha;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}