namespace Goodlife
{
    partial class Menu
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
			this.btn_cadFunc = new System.Windows.Forms.Button();
			this.btn_cadMed = new System.Windows.Forms.Button();
			this.btn_LogFunc = new System.Windows.Forms.Button();
			this.Log_med = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btn_cadFunc
			// 
			this.btn_cadFunc.BackColor = System.Drawing.Color.RoyalBlue;
			this.btn_cadFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_cadFunc.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btn_cadFunc.Location = new System.Drawing.Point(52, 99);
			this.btn_cadFunc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btn_cadFunc.Name = "btn_cadFunc";
			this.btn_cadFunc.Size = new System.Drawing.Size(131, 63);
			this.btn_cadFunc.TabIndex = 0;
			this.btn_cadFunc.Text = "Cadastro Funcionario";
			this.btn_cadFunc.UseVisualStyleBackColor = false;
			this.btn_cadFunc.Click += new System.EventHandler(this.btn_cadFunc_Click);
			// 
			// btn_cadMed
			// 
			this.btn_cadMed.BackColor = System.Drawing.Color.RoyalBlue;
			this.btn_cadMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_cadMed.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btn_cadMed.Location = new System.Drawing.Point(418, 99);
			this.btn_cadMed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btn_cadMed.Name = "btn_cadMed";
			this.btn_cadMed.Size = new System.Drawing.Size(131, 63);
			this.btn_cadMed.TabIndex = 1;
			this.btn_cadMed.Text = "Cadastro Médico";
			this.btn_cadMed.UseVisualStyleBackColor = false;
			this.btn_cadMed.Click += new System.EventHandler(this.btn_cadMed_Click);
			// 
			// btn_LogFunc
			// 
			this.btn_LogFunc.BackColor = System.Drawing.Color.RoyalBlue;
			this.btn_LogFunc.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_LogFunc.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btn_LogFunc.Location = new System.Drawing.Point(52, 207);
			this.btn_LogFunc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btn_LogFunc.Name = "btn_LogFunc";
			this.btn_LogFunc.Size = new System.Drawing.Size(131, 63);
			this.btn_LogFunc.TabIndex = 2;
			this.btn_LogFunc.Text = "Login Funcionário";
			this.btn_LogFunc.UseVisualStyleBackColor = false;
			this.btn_LogFunc.Click += new System.EventHandler(this.btn_LogFunc_Click);
			// 
			// Log_med
			// 
			this.Log_med.BackColor = System.Drawing.Color.RoyalBlue;
			this.Log_med.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Log_med.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.Log_med.Location = new System.Drawing.Point(235, 99);
			this.Log_med.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Log_med.Name = "Log_med";
			this.Log_med.Size = new System.Drawing.Size(131, 63);
			this.Log_med.TabIndex = 3;
			this.Log_med.Text = "Login Médico";
			this.Log_med.UseVisualStyleBackColor = false;
			this.Log_med.Click += new System.EventHandler(this.Log_med_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(256, 16);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 34);
			this.label1.TabIndex = 4;
			this.label1.Text = "Menu";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.RoyalBlue;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.button1.Location = new System.Drawing.Point(418, 207);
			this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(131, 63);
			this.button1.TabIndex = 5;
			this.button1.Text = "Agendamento funcionário";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Menu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Goodlife.Properties.Resources._7_baskhs;
			this.ClientSize = new System.Drawing.Size(600, 366);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Log_med);
			this.Controls.Add(this.btn_LogFunc);
			this.Controls.Add(this.btn_cadMed);
			this.Controls.Add(this.btn_cadFunc);
			this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "Menu";
			this.Text = "Menu";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cadFunc;
        private System.Windows.Forms.Button btn_cadMed;
        private System.Windows.Forms.Button btn_LogFunc;
        private System.Windows.Forms.Button Log_med;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}