namespace Goodlife
{
    partial class confirmCad
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
			this.label1 = new System.Windows.Forms.Label();
			this.btn_verifCad = new System.Windows.Forms.Button();
			this.txt_verifCad = new System.Windows.Forms.TextBox();
			this.lnk_return = new System.Windows.Forms.LinkLabel();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label1.Location = new System.Drawing.Point(26, 7);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(126, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Qual a senha da clínica?";
			// 
			// btn_verifCad
			// 
			this.btn_verifCad.BackColor = System.Drawing.Color.SteelBlue;
			this.btn_verifCad.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.btn_verifCad.Location = new System.Drawing.Point(55, 69);
			this.btn_verifCad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btn_verifCad.Name = "btn_verifCad";
			this.btn_verifCad.Size = new System.Drawing.Size(56, 25);
			this.btn_verifCad.TabIndex = 2;
			this.btn_verifCad.Text = "Verificar";
			this.btn_verifCad.UseVisualStyleBackColor = false;
			this.btn_verifCad.Click += new System.EventHandler(this.btn_verifCad_Click);
			// 
			// txt_verifCad
			// 
			this.txt_verifCad.Location = new System.Drawing.Point(9, 38);
			this.txt_verifCad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txt_verifCad.Name = "txt_verifCad";
			this.txt_verifCad.Size = new System.Drawing.Size(149, 20);
			this.txt_verifCad.TabIndex = 1;
			// 
			// lnk_return
			// 
			this.lnk_return.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
			this.lnk_return.AutoSize = true;
			this.lnk_return.BackColor = System.Drawing.Color.Transparent;
			this.lnk_return.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lnk_return.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.lnk_return.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.lnk_return.Location = new System.Drawing.Point(7, 90);
			this.lnk_return.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lnk_return.Name = "lnk_return";
			this.lnk_return.Size = new System.Drawing.Size(34, 13);
			this.lnk_return.TabIndex = 29;
			this.lnk_return.TabStop = true;
			this.lnk_return.Text = "Voltar";
			this.lnk_return.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_return_LinkClicked);
			// 
			// confirmCad
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Goodlife.Properties.Resources._7_baskhs;
			this.ClientSize = new System.Drawing.Size(173, 111);
			this.Controls.Add(this.lnk_return);
			this.Controls.Add(this.btn_verifCad);
			this.Controls.Add(this.txt_verifCad);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "confirmCad";
			this.Text = "confirmCad";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_verifCad;
        private System.Windows.Forms.TextBox txt_verifCad;
        private System.Windows.Forms.LinkLabel lnk_return;
    }
}