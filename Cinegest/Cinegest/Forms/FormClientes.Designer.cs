namespace Cinegest.Forms
{
    partial class FormClientes
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BilhetesVendidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumFiscal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pessoasClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cineGestDataSet = new Cinegest.CineGestDataSet();
            this.alterarClientebtn = new System.Windows.Forms.Button();
            this.apagarClientebtn = new System.Windows.Forms.Button();
            this.novoClientebtn = new System.Windows.Forms.Button();
            this.alterarNomelbl = new System.Windows.Forms.TextBox();
            this.alterarMoradalbl = new System.Windows.Forms.TextBox();
            this.alterarNumFiscallbl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pessoas_ClienteTableAdapter = new Cinegest.CineGestDataSetTableAdapters.Pessoas_ClienteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cineGestDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.BilhetesVendidos,
            this.ValorTotal,
            this.NumFiscal,
            this.moradaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pessoasClienteBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(590, 473);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // BilhetesVendidos
            // 
            this.BilhetesVendidos.HeaderText = "BilhetesVendidos";
            this.BilhetesVendidos.Name = "BilhetesVendidos";
            // 
            // ValorTotal
            // 
            this.ValorTotal.HeaderText = "ValorTotal";
            this.ValorTotal.Name = "ValorTotal";
            // 
            // NumFiscal
            // 
            this.NumFiscal.DataPropertyName = "NumFiscal";
            this.NumFiscal.HeaderText = "NumFiscal";
            this.NumFiscal.Name = "NumFiscal";
            // 
            // moradaDataGridViewTextBoxColumn
            // 
            this.moradaDataGridViewTextBoxColumn.DataPropertyName = "Morada";
            this.moradaDataGridViewTextBoxColumn.HeaderText = "Morada";
            this.moradaDataGridViewTextBoxColumn.Name = "moradaDataGridViewTextBoxColumn";
            // 
            // pessoasClienteBindingSource
            // 
            this.pessoasClienteBindingSource.DataMember = "Pessoas_Cliente";
            this.pessoasClienteBindingSource.DataSource = this.cineGestDataSet;
            // 
            // cineGestDataSet
            // 
            this.cineGestDataSet.DataSetName = "CineGestDataSet";
            this.cineGestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alterarClientebtn
            // 
            this.alterarClientebtn.Location = new System.Drawing.Point(974, 12);
            this.alterarClientebtn.Name = "alterarClientebtn";
            this.alterarClientebtn.Size = new System.Drawing.Size(75, 196);
            this.alterarClientebtn.TabIndex = 1;
            this.alterarClientebtn.Text = "Guardar Alterações";
            this.alterarClientebtn.UseVisualStyleBackColor = true;
            this.alterarClientebtn.Click += new System.EventHandler(this.alterarClientebtn_Click);
            // 
            // apagarClientebtn
            // 
            this.apagarClientebtn.Location = new System.Drawing.Point(616, 415);
            this.apagarClientebtn.Name = "apagarClientebtn";
            this.apagarClientebtn.Size = new System.Drawing.Size(433, 70);
            this.apagarClientebtn.TabIndex = 2;
            this.apagarClientebtn.Text = "Apagar ";
            this.apagarClientebtn.UseVisualStyleBackColor = true;
            this.apagarClientebtn.Click += new System.EventHandler(this.apagarClientebtn_Click);
            // 
            // novoClientebtn
            // 
            this.novoClientebtn.Location = new System.Drawing.Point(619, 301);
            this.novoClientebtn.Name = "novoClientebtn";
            this.novoClientebtn.Size = new System.Drawing.Size(430, 70);
            this.novoClientebtn.TabIndex = 3;
            this.novoClientebtn.Text = "Criar Cliente";
            this.novoClientebtn.UseVisualStyleBackColor = true;
            this.novoClientebtn.Click += new System.EventHandler(this.novoClientebtn_Click);
            // 
            // alterarNomelbl
            // 
            this.alterarNomelbl.Location = new System.Drawing.Point(622, 86);
            this.alterarNomelbl.Name = "alterarNomelbl";
            this.alterarNomelbl.Size = new System.Drawing.Size(344, 20);
            this.alterarNomelbl.TabIndex = 4;
            // 
            // alterarMoradalbl
            // 
            this.alterarMoradalbl.Location = new System.Drawing.Point(622, 135);
            this.alterarMoradalbl.Name = "alterarMoradalbl";
            this.alterarMoradalbl.Size = new System.Drawing.Size(345, 20);
            this.alterarMoradalbl.TabIndex = 5;
            // 
            // alterarNumFiscallbl
            // 
            this.alterarNumFiscallbl.Location = new System.Drawing.Point(622, 188);
            this.alterarNumFiscallbl.Name = "alterarNumFiscallbl";
            this.alterarNumFiscallbl.Size = new System.Drawing.Size(345, 20);
            this.alterarNumFiscallbl.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(625, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Alterar Cliente Selecionado";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(622, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(346, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nome";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(619, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(349, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Morada";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(622, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(345, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "NumFiscal";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(619, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(430, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Criar Um Novo Cliente";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(616, 389);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(427, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Apagar Um Cliente";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pessoas_ClienteTableAdapter
            // 
            this.pessoas_ClienteTableAdapter.ClearBeforeFill = true;
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 498);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.alterarNumFiscallbl);
            this.Controls.Add(this.alterarMoradalbl);
            this.Controls.Add(this.alterarNomelbl);
            this.Controls.Add(this.novoClientebtn);
            this.Controls.Add(this.apagarClientebtn);
            this.Controls.Add(this.alterarClientebtn);
            this.Controls.Add(this.dataGridView1);
            this.MinimumSize = new System.Drawing.Size(1074, 537);
            this.Name = "FormClientes";
            this.Text = "FormClientes";
            this.Load += new System.EventHandler(this.FormClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cineGestDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button alterarClientebtn;
        private CineGestDataSet cineGestDataSet;
        private System.Windows.Forms.BindingSource pessoasClienteBindingSource;
        private CineGestDataSetTableAdapters.Pessoas_ClienteTableAdapter pessoas_ClienteTableAdapter;
        private System.Windows.Forms.Button apagarClientebtn;
        private System.Windows.Forms.Button novoClientebtn;
        private System.Windows.Forms.TextBox alterarNomelbl;
        private System.Windows.Forms.TextBox alterarMoradalbl;
        private System.Windows.Forms.TextBox alterarNumFiscallbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn BilhetesVendidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumFiscal;
        private System.Windows.Forms.DataGridViewTextBoxColumn moradaDataGridViewTextBoxColumn;
    }
}