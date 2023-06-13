namespace Cinegest.Forms
{
    partial class FormNovaSala
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
            this.filaslbl = new System.Windows.Forms.Label();
            this.colunaslbl = new System.Windows.Forms.Label();
            this.nomelbl = new System.Windows.Forms.Label();
            this.salaFilastb = new System.Windows.Forms.TextBox();
            this.salaNometb = new System.Windows.Forms.TextBox();
            this.salaColunastb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.adicionarSalabtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // filaslbl
            // 
            this.filaslbl.Location = new System.Drawing.Point(20, 107);
            this.filaslbl.Name = "filaslbl";
            this.filaslbl.Size = new System.Drawing.Size(93, 23);
            this.filaslbl.TabIndex = 35;
            this.filaslbl.Text = "Filas Da Sala";
            this.filaslbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // colunaslbl
            // 
            this.colunaslbl.Location = new System.Drawing.Point(23, 84);
            this.colunaslbl.Name = "colunaslbl";
            this.colunaslbl.Size = new System.Drawing.Size(90, 23);
            this.colunaslbl.TabIndex = 34;
            this.colunaslbl.Text = "Colunas Da Sala";
            this.colunaslbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nomelbl
            // 
            this.nomelbl.Location = new System.Drawing.Point(9, 58);
            this.nomelbl.Name = "nomelbl";
            this.nomelbl.Size = new System.Drawing.Size(121, 23);
            this.nomelbl.TabIndex = 33;
            this.nomelbl.Text = "Nome Da Sala";
            this.nomelbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // salaFilastb
            // 
            this.salaFilastb.Location = new System.Drawing.Point(136, 107);
            this.salaFilastb.Name = "salaFilastb";
            this.salaFilastb.Size = new System.Drawing.Size(136, 20);
            this.salaFilastb.TabIndex = 32;
            // 
            // salaNometb
            // 
            this.salaNometb.Location = new System.Drawing.Point(136, 61);
            this.salaNometb.Name = "salaNometb";
            this.salaNometb.Size = new System.Drawing.Size(136, 20);
            this.salaNometb.TabIndex = 31;
            // 
            // salaColunastb
            // 
            this.salaColunastb.Location = new System.Drawing.Point(136, 84);
            this.salaColunastb.Name = "salaColunastb";
            this.salaColunastb.Size = new System.Drawing.Size(136, 20);
            this.salaColunastb.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 23);
            this.label1.TabIndex = 36;
            this.label1.Text = "Nova Sala";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // adicionarSalabtn
            // 
            this.adicionarSalabtn.Location = new System.Drawing.Point(26, 133);
            this.adicionarSalabtn.Name = "adicionarSalabtn";
            this.adicionarSalabtn.Size = new System.Drawing.Size(247, 23);
            this.adicionarSalabtn.TabIndex = 37;
            this.adicionarSalabtn.Text = "Adicionar Sala";
            this.adicionarSalabtn.UseVisualStyleBackColor = true;
            this.adicionarSalabtn.Click += new System.EventHandler(this.adicionarSalabtn_Click);
            // 
            // FormNovaSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 171);
            this.Controls.Add(this.adicionarSalabtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filaslbl);
            this.Controls.Add(this.colunaslbl);
            this.Controls.Add(this.nomelbl);
            this.Controls.Add(this.salaFilastb);
            this.Controls.Add(this.salaNometb);
            this.Controls.Add(this.salaColunastb);
            this.Name = "FormNovaSala";
            this.Text = "FormNovaSala";
            this.Load += new System.EventHandler(this.FormNovaSala_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label filaslbl;
        private System.Windows.Forms.Label colunaslbl;
        private System.Windows.Forms.Label nomelbl;
        private System.Windows.Forms.TextBox salaFilastb;
        private System.Windows.Forms.TextBox salaNometb;
        private System.Windows.Forms.TextBox salaColunastb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button adicionarSalabtn;
    }
}