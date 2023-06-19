namespace Cinegest.Forms
{
    partial class FormNovoFilme
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
            this.categorialbl = new System.Windows.Forms.Label();
            this.adicionarbtn = new System.Windows.Forms.Button();
            this.duracaolbl = new System.Windows.Forms.Label();
            this.nomelbl = new System.Windows.Forms.Label();
            this.duracaoFilmetb = new System.Windows.Forms.TextBox();
            this.nomeFilmetb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.categoriaFilmescb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // categorialbl
            // 
            this.categorialbl.Location = new System.Drawing.Point(9, 107);
            this.categorialbl.Name = "categorialbl";
            this.categorialbl.Size = new System.Drawing.Size(86, 20);
            this.categorialbl.TabIndex = 27;
            this.categorialbl.Text = "Categoria";
            // 
            // adicionarbtn
            // 
            this.adicionarbtn.Location = new System.Drawing.Point(233, 10);
            this.adicionarbtn.Name = "adicionarbtn";
            this.adicionarbtn.Size = new System.Drawing.Size(63, 118);
            this.adicionarbtn.TabIndex = 25;
            this.adicionarbtn.Text = "Adicionar";
            this.adicionarbtn.UseVisualStyleBackColor = true;
            this.adicionarbtn.Click += new System.EventHandler(this.adicionarbtn_Click);
            // 
            // duracaolbl
            // 
            this.duracaolbl.Location = new System.Drawing.Point(9, 81);
            this.duracaolbl.Name = "duracaolbl";
            this.duracaolbl.Size = new System.Drawing.Size(86, 20);
            this.duracaolbl.TabIndex = 23;
            this.duracaolbl.Text = "Duração";
            // 
            // nomelbl
            // 
            this.nomelbl.Location = new System.Drawing.Point(9, 55);
            this.nomelbl.Name = "nomelbl";
            this.nomelbl.Size = new System.Drawing.Size(86, 20);
            this.nomelbl.TabIndex = 22;
            this.nomelbl.Text = "Nome";
            // 
            // duracaoFilmetb
            // 
            this.duracaoFilmetb.Location = new System.Drawing.Point(101, 81);
            this.duracaoFilmetb.Name = "duracaoFilmetb";
            this.duracaoFilmetb.Size = new System.Drawing.Size(100, 20);
            this.duracaoFilmetb.TabIndex = 21;
            // 
            // nomeFilmetb
            // 
            this.nomeFilmetb.Location = new System.Drawing.Point(101, 55);
            this.nomeFilmetb.Name = "nomeFilmetb";
            this.nomeFilmetb.Size = new System.Drawing.Size(100, 20);
            this.nomeFilmetb.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Novo Filme";
            // 
            // categoriaFilmescb
            // 
            this.categoriaFilmescb.FormattingEnabled = true;
            this.categoriaFilmescb.Location = new System.Drawing.Point(101, 107);
            this.categoriaFilmescb.Name = "categoriaFilmescb";
            this.categoriaFilmescb.Size = new System.Drawing.Size(100, 21);
            this.categoriaFilmescb.TabIndex = 28;
            // 
            // FormNovoFilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 408);
            this.Controls.Add(this.categoriaFilmescb);
            this.Controls.Add(this.categorialbl);
            this.Controls.Add(this.adicionarbtn);
            this.Controls.Add(this.duracaolbl);
            this.Controls.Add(this.nomelbl);
            this.Controls.Add(this.duracaoFilmetb);
            this.Controls.Add(this.nomeFilmetb);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(318, 447);
            this.Name = "FormNovoFilme";
            this.Text = "FormNovoFilme";
            this.Load += new System.EventHandler(this.FormNovoFilme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label categorialbl;
        private System.Windows.Forms.Button adicionarbtn;
        private System.Windows.Forms.Label duracaolbl;
        private System.Windows.Forms.Label nomelbl;
        private System.Windows.Forms.TextBox duracaoFilmetb;
        private System.Windows.Forms.TextBox nomeFilmetb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox categoriaFilmescb;
    }
}