namespace Cinegest.Forms
{
    partial class FormPrincipal
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
            this.Cinemabtn = new System.Windows.Forms.Button();
            this.Funcionariosbtn = new System.Windows.Forms.Button();
            this.Clientesbtn = new System.Windows.Forms.Button();
            this.Sessõesbtn = new System.Windows.Forms.Button();
            this.Filmesbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Cinemabtn
            // 
            this.Cinemabtn.Location = new System.Drawing.Point(22, 12);
            this.Cinemabtn.Name = "Cinemabtn";
            this.Cinemabtn.Size = new System.Drawing.Size(143, 72);
            this.Cinemabtn.TabIndex = 0;
            this.Cinemabtn.Text = "Cinema";
            this.Cinemabtn.UseVisualStyleBackColor = true;
            this.Cinemabtn.Click += new System.EventHandler(this.Cinemabtn_Click);
            // 
            // Funcionariosbtn
            // 
            this.Funcionariosbtn.Location = new System.Drawing.Point(22, 324);
            this.Funcionariosbtn.Name = "Funcionariosbtn";
            this.Funcionariosbtn.Size = new System.Drawing.Size(143, 72);
            this.Funcionariosbtn.TabIndex = 1;
            this.Funcionariosbtn.Text = "Funcionários";
            this.Funcionariosbtn.UseVisualStyleBackColor = true;
            this.Funcionariosbtn.Click += new System.EventHandler(this.Funcionariosbtn_Click);
            // 
            // Clientesbtn
            // 
            this.Clientesbtn.Location = new System.Drawing.Point(22, 246);
            this.Clientesbtn.Name = "Clientesbtn";
            this.Clientesbtn.Size = new System.Drawing.Size(143, 72);
            this.Clientesbtn.TabIndex = 2;
            this.Clientesbtn.Text = "Clientes";
            this.Clientesbtn.UseVisualStyleBackColor = true;
            this.Clientesbtn.Click += new System.EventHandler(this.Clientesbtn_Click);
            // 
            // Sessõesbtn
            // 
            this.Sessõesbtn.Location = new System.Drawing.Point(22, 168);
            this.Sessõesbtn.Name = "Sessõesbtn";
            this.Sessõesbtn.Size = new System.Drawing.Size(143, 72);
            this.Sessõesbtn.TabIndex = 3;
            this.Sessõesbtn.Text = "Sessões";
            this.Sessõesbtn.UseVisualStyleBackColor = true;
            this.Sessõesbtn.Click += new System.EventHandler(this.Sessõesbtn_Click);
            // 
            // Filmesbtn
            // 
            this.Filmesbtn.Location = new System.Drawing.Point(22, 90);
            this.Filmesbtn.Name = "Filmesbtn";
            this.Filmesbtn.Size = new System.Drawing.Size(143, 72);
            this.Filmesbtn.TabIndex = 4;
            this.Filmesbtn.Text = "Filmes";
            this.Filmesbtn.UseVisualStyleBackColor = true;
            this.Filmesbtn.Click += new System.EventHandler(this.Filmesbtn_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Filmesbtn);
            this.Controls.Add(this.Sessõesbtn);
            this.Controls.Add(this.Clientesbtn);
            this.Controls.Add(this.Funcionariosbtn);
            this.Controls.Add(this.Cinemabtn);
            this.Name = "FormPrincipal";
            this.Text = "FormPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Cinemabtn;
        private System.Windows.Forms.Button Funcionariosbtn;
        private System.Windows.Forms.Button Clientesbtn;
        private System.Windows.Forms.Button Sessõesbtn;
        private System.Windows.Forms.Button Filmesbtn;
    }
}