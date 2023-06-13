namespace Cinegest.Forms
{
    partial class FormNovoFuncionario
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
            this.adicionarbtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nomelbl = new System.Windows.Forms.Label();
            this.moradaFuncionariotb = new System.Windows.Forms.TextBox();
            this.salarioFuncionariotb = new System.Windows.Forms.TextBox();
            this.nomeFuncionariotb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.funcaoFuncionariotb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // adicionarbtn
            // 
            this.adicionarbtn.Location = new System.Drawing.Point(12, 178);
            this.adicionarbtn.Name = "adicionarbtn";
            this.adicionarbtn.Size = new System.Drawing.Size(191, 23);
            this.adicionarbtn.TabIndex = 15;
            this.adicionarbtn.Text = "Adicionar";
            this.adicionarbtn.UseVisualStyleBackColor = true;
            this.adicionarbtn.Click += new System.EventHandler(this.adicionarbtn_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(9, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Salario";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(9, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Morada";
            // 
            // nomelbl
            // 
            this.nomelbl.Location = new System.Drawing.Point(9, 60);
            this.nomelbl.Name = "nomelbl";
            this.nomelbl.Size = new System.Drawing.Size(86, 20);
            this.nomelbl.TabIndex = 12;
            this.nomelbl.Text = "Nome";
            // 
            // moradaFuncionariotb
            // 
            this.moradaFuncionariotb.Location = new System.Drawing.Point(101, 86);
            this.moradaFuncionariotb.Name = "moradaFuncionariotb";
            this.moradaFuncionariotb.Size = new System.Drawing.Size(100, 20);
            this.moradaFuncionariotb.TabIndex = 11;
            // 
            // salarioFuncionariotb
            // 
            this.salarioFuncionariotb.Location = new System.Drawing.Point(101, 112);
            this.salarioFuncionariotb.Name = "salarioFuncionariotb";
            this.salarioFuncionariotb.Size = new System.Drawing.Size(100, 20);
            this.salarioFuncionariotb.TabIndex = 10;
            // 
            // nomeFuncionariotb
            // 
            this.nomeFuncionariotb.Location = new System.Drawing.Point(101, 60);
            this.nomeFuncionariotb.Name = "nomeFuncionariotb";
            this.nomeFuncionariotb.Size = new System.Drawing.Size(100, 20);
            this.nomeFuncionariotb.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Novo Funcionario";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(11, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Funcao";
            // 
            // funcaoFuncionariotb
            // 
            this.funcaoFuncionariotb.Location = new System.Drawing.Point(103, 140);
            this.funcaoFuncionariotb.Name = "funcaoFuncionariotb";
            this.funcaoFuncionariotb.Size = new System.Drawing.Size(100, 20);
            this.funcaoFuncionariotb.TabIndex = 16;
            // 
            // FormNovoFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 232);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.funcaoFuncionariotb);
            this.Controls.Add(this.adicionarbtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nomelbl);
            this.Controls.Add(this.moradaFuncionariotb);
            this.Controls.Add(this.salarioFuncionariotb);
            this.Controls.Add(this.nomeFuncionariotb);
            this.Controls.Add(this.label1);
            this.Name = "FormNovoFuncionario";
            this.Text = "FormNovoFuncionario";
            this.Load += new System.EventHandler(this.FormNovoFuncionario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button adicionarbtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label nomelbl;
        private System.Windows.Forms.TextBox moradaFuncionariotb;
        private System.Windows.Forms.TextBox salarioFuncionariotb;
        private System.Windows.Forms.TextBox nomeFuncionariotb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox funcaoFuncionariotb;
    }
}