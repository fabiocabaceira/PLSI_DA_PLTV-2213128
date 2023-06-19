namespace Cinegest.Forms
{
    partial class FormNovoCliente
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
            this.nometb = new System.Windows.Forms.TextBox();
            this.numFiscaltb = new System.Windows.Forms.TextBox();
            this.moradatb = new System.Windows.Forms.TextBox();
            this.nomelbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.adicionarbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Novo Cliente";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nometb
            // 
            this.nometb.Location = new System.Drawing.Point(104, 54);
            this.nometb.Name = "nometb";
            this.nometb.Size = new System.Drawing.Size(100, 20);
            this.nometb.TabIndex = 1;
            // 
            // numFiscaltb
            // 
            this.numFiscaltb.Location = new System.Drawing.Point(104, 106);
            this.numFiscaltb.Name = "numFiscaltb";
            this.numFiscaltb.Size = new System.Drawing.Size(100, 20);
            this.numFiscaltb.TabIndex = 2;
            // 
            // moradatb
            // 
            this.moradatb.Location = new System.Drawing.Point(104, 80);
            this.moradatb.Name = "moradatb";
            this.moradatb.Size = new System.Drawing.Size(100, 20);
            this.moradatb.TabIndex = 3;
            // 
            // nomelbl
            // 
            this.nomelbl.Location = new System.Drawing.Point(12, 54);
            this.nomelbl.Name = "nomelbl";
            this.nomelbl.Size = new System.Drawing.Size(86, 20);
            this.nomelbl.TabIndex = 4;
            this.nomelbl.Text = "Nome";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Morada";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "NumFiscal";
            // 
            // adicionarbtn
            // 
            this.adicionarbtn.Location = new System.Drawing.Point(15, 150);
            this.adicionarbtn.Name = "adicionarbtn";
            this.adicionarbtn.Size = new System.Drawing.Size(189, 23);
            this.adicionarbtn.TabIndex = 7;
            this.adicionarbtn.Text = "Adicionar";
            this.adicionarbtn.UseVisualStyleBackColor = true;
            this.adicionarbtn.Click += new System.EventHandler(this.Adicionarbtn_Click);
            // 
            // FormNovoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 186);
            this.Controls.Add(this.adicionarbtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nomelbl);
            this.Controls.Add(this.moradatb);
            this.Controls.Add(this.numFiscaltb);
            this.Controls.Add(this.nometb);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(236, 225);
            this.Name = "FormNovoCliente";
            this.Text = "FormClientes";
            this.Load += new System.EventHandler(this.FormClientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nometb;
        private System.Windows.Forms.TextBox numFiscaltb;
        private System.Windows.Forms.TextBox moradatb;
        private System.Windows.Forms.Label nomelbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button adicionarbtn;
    }
}