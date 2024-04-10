namespace Goodlife
{
    partial class Login_Medico
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
			this.txt_Crm = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.linkLabel2 = new System.Windows.Forms.LinkLabel();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btn_Confirm
			// 
			this.btn_Confirm.BackColor = System.Drawing.Color.RoyalBlue;
			this.btn_Confirm.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
			this.btn_Confirm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btn_Confirm.Location = new System.Drawing.Point(239, 187);
			this.btn_Confirm.Name = "btn_Confirm";
			this.btn_Confirm.Size = new System.Drawing.Size(107, 43);
			this.btn_Confirm.TabIndex = 21;
			this.btn_Confirm.Text = "Login";
			this.btn_Confirm.UseVisualStyleBackColor = false;
			this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
			// 
			// txt_Crm
			// 
			this.txt_Crm.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_Crm.Location = new System.Drawing.Point(205, 109);
			this.txt_Crm.MaxLength = 16;
			this.txt_Crm.Multiline = true;
			this.txt_Crm.Name = "txt_Crm";
			this.txt_Crm.PasswordChar = '*';
			this.txt_Crm.Size = new System.Drawing.Size(230, 33);
			this.txt_Crm.TabIndex = 20;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 16F);
			this.label2.Location = new System.Drawing.Point(137, 109);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(61, 28);
			this.label2.TabIndex = 19;
			this.label2.Text = "CRM";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(255, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(87, 34);
			this.label1.TabIndex = 18;
			this.label1.Text = "Login";
			// 
			// linkLabel2
			// 
			this.linkLabel2.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
			this.linkLabel2.AutoSize = true;
			this.linkLabel2.BackColor = System.Drawing.Color.Transparent;
			this.linkLabel2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.linkLabel2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.linkLabel2.Location = new System.Drawing.Point(9, 338);
			this.linkLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.linkLabel2.Name = "linkLabel2";
			this.linkLabel2.Size = new System.Drawing.Size(37, 20);
			this.linkLabel2.TabIndex = 27;
			this.linkLabel2.TabStop = true;
			this.linkLabel2.Text = "Sair";
			this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label4.Location = new System.Drawing.Point(162, 223);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(0, 17);
			this.label4.TabIndex = 28;
			// 
			// Login_Medico
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Goodlife.Properties.Resources._7_baskhs;
			this.ClientSize = new System.Drawing.Size(600, 366);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.linkLabel2);
			this.Controls.Add(this.btn_Confirm);
			this.Controls.Add(this.txt_Crm);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "Login_Medico";
			this.Text = "Login_Medico";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Confirm;
        private System.Windows.Forms.TextBox txt_Crm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label4;
    }
}