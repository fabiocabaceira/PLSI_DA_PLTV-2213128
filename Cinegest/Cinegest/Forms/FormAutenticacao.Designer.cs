﻿namespace Cinegest.Forms
{
    partial class FormAutenticacao
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
            this.funcionarioNometb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.entrarbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // funcionarioNometb
            // 
            this.funcionarioNometb.Location = new System.Drawing.Point(12, 63);
            this.funcionarioNometb.Name = "funcionarioNometb";
            this.funcionarioNometb.Size = new System.Drawing.Size(221, 20);
            this.funcionarioNometb.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Insira o seu nome para se autenticar";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // entrarbtn
            // 
            this.entrarbtn.Location = new System.Drawing.Point(12, 89);
            this.entrarbtn.Name = "entrarbtn";
            this.entrarbtn.Size = new System.Drawing.Size(221, 23);
            this.entrarbtn.TabIndex = 2;
            this.entrarbtn.Text = "Entrar";
            this.entrarbtn.UseVisualStyleBackColor = true;
            this.entrarbtn.Click += new System.EventHandler(this.entrarbtn_Click);
            // 
            // FormAutenticacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 143);
            this.Controls.Add(this.entrarbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.funcionarioNometb);
            this.MinimumSize = new System.Drawing.Size(265, 182);
            this.Name = "FormAutenticacao";
            this.Text = "FormAutenticacao";
            this.Load += new System.EventHandler(this.FormAutenticacao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox funcionarioNometb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button entrarbtn;
    }
}