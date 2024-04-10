namespace Goodlife
{
    partial class TelaInicial
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
			this.label2 = new System.Windows.Forms.Label();
			this.btn_LoginFunc = new System.Windows.Forms.Button();
			this.btn_LoginMed = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
			this.label1.Location = new System.Drawing.Point(124, 7);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(405, 31);
			this.label1.TabIndex = 0;
			this.label1.Text = "Bem-vindo ao Goodlife\'s System";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label2.Location = new System.Drawing.Point(186, 74);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(246, 26);
			this.label2.TabIndex = 1;
			this.label2.Text = "Como você quer entrar?";
			// 
			// btn_LoginFunc
			// 
			this.btn_LoginFunc.BackColor = System.Drawing.Color.RoyalBlue;
			this.btn_LoginFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_LoginFunc.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btn_LoginFunc.Location = new System.Drawing.Point(108, 162);
			this.btn_LoginFunc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btn_LoginFunc.Name = "btn_LoginFunc";
			this.btn_LoginFunc.Size = new System.Drawing.Size(153, 50);
			this.btn_LoginFunc.TabIndex = 2;
			this.btn_LoginFunc.Text = "Funcionário";
			this.btn_LoginFunc.UseVisualStyleBackColor = false;
			this.btn_LoginFunc.Click += new System.EventHandler(this.btn_LoginFunc_Click);
			// 
			// btn_LoginMed
			// 
			this.btn_LoginMed.BackColor = System.Drawing.Color.RoyalBlue;
			this.btn_LoginMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_LoginMed.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btn_LoginMed.Location = new System.Drawing.Point(362, 162);
			this.btn_LoginMed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btn_LoginMed.Name = "btn_LoginMed";
			this.btn_LoginMed.Size = new System.Drawing.Size(132, 50);
			this.btn_LoginMed.TabIndex = 3;
			this.btn_LoginMed.Text = "Médico";
			this.btn_LoginMed.UseVisualStyleBackColor = false;
			this.btn_LoginMed.Click += new System.EventHandler(this.btn_LoginMed_Click);
			// 
			// TelaInicial
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Goodlife.Properties.Resources._7_baskhs;
			this.ClientSize = new System.Drawing.Size(600, 366);
			this.Controls.Add(this.btn_LoginMed);
			this.Controls.Add(this.btn_LoginFunc);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "TelaInicial";
			this.Text = "TelaInicial";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_LoginFunc;
        private System.Windows.Forms.Button btn_LoginMed;
    }
}