namespace Cinegest.Forms
{
    partial class FormAtendimento
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
            this.bilhetesBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.data1 = new Cinegest.data();
            this.bilhetesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cineGestDataSet = new Cinegest.CineGestDataSet();
            this.sessãoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sessãoTableAdapter = new Cinegest.CineGestDataSetTableAdapters.SessãoTableAdapter();
            this.bilhetesTableAdapter = new Cinegest.CineGestDataSetTableAdapters.BilhetesTableAdapter();
            this.cliente_Nometb = new System.Windows.Forms.TextBox();
            this.cliente_Moradatb = new System.Windows.Forms.TextBox();
            this.cliente_Numfiscaltb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.funcionariolbl = new System.Windows.Forms.Label();
            this.novoClientelbl = new System.Windows.Forms.Label();
            this.selecionarClientelbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.clientesdgv = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pessoasClienteBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.pessoasClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.data = new Cinegest.data();
            this.bilhetesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bilhetesTableAdapter1 = new Cinegest.dataTableAdapters.BilhetesTableAdapter();
            this.bilhetesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.pessoas_ClienteTableAdapter = new Cinegest.dataTableAdapters.Pessoas_ClienteTableAdapter();
            this.pessoasClienteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Selecionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lugar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataHoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilhetesBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilhetesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cineGestDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessãoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesdgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasClienteBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilhetesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilhetesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasClienteBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selecionar,
            this.dataGridViewTextBoxColumn1,
            this.Lugar,
            this.Estado,
            this.dataHoraDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bilhetesBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(280, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(768, 701);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // bilhetesBindingSource3
            // 
            this.bilhetesBindingSource3.DataMember = "Bilhetes";
            this.bilhetesBindingSource3.DataSource = this.data1;
            // 
            // data1
            // 
            this.data1.DataSetName = "data";
            this.data1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bilhetesBindingSource
            // 
            this.bilhetesBindingSource.DataMember = "Bilhetes";
            this.bilhetesBindingSource.DataSource = this.cineGestDataSet;
            // 
            // cineGestDataSet
            // 
            this.cineGestDataSet.DataSetName = "CineGestDataSet";
            this.cineGestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sessãoBindingSource
            // 
            this.sessãoBindingSource.DataMember = "Sessão";
            this.sessãoBindingSource.DataSource = this.cineGestDataSet;
            // 
            // sessãoTableAdapter
            // 
            this.sessãoTableAdapter.ClearBeforeFill = true;
            // 
            // bilhetesTableAdapter
            // 
            this.bilhetesTableAdapter.ClearBeforeFill = true;
            // 
            // cliente_Nometb
            // 
            this.cliente_Nometb.Location = new System.Drawing.Point(127, 83);
            this.cliente_Nometb.Name = "cliente_Nometb";
            this.cliente_Nometb.Size = new System.Drawing.Size(147, 20);
            this.cliente_Nometb.TabIndex = 1;
            // 
            // cliente_Moradatb
            // 
            this.cliente_Moradatb.Location = new System.Drawing.Point(127, 103);
            this.cliente_Moradatb.Name = "cliente_Moradatb";
            this.cliente_Moradatb.Size = new System.Drawing.Size(147, 20);
            this.cliente_Moradatb.TabIndex = 2;
            // 
            // cliente_Numfiscaltb
            // 
            this.cliente_Numfiscaltb.Location = new System.Drawing.Point(127, 120);
            this.cliente_Numfiscaltb.Name = "cliente_Numfiscaltb";
            this.cliente_Numfiscaltb.Size = new System.Drawing.Size(147, 20);
            this.cliente_Numfiscaltb.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(9, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Morada";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(9, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "NumFiscal";
            // 
            // funcionariolbl
            // 
            this.funcionariolbl.Location = new System.Drawing.Point(9, 12);
            this.funcionariolbl.Name = "funcionariolbl";
            this.funcionariolbl.Size = new System.Drawing.Size(262, 23);
            this.funcionariolbl.TabIndex = 7;
            this.funcionariolbl.Text = "Funcionário atual: ";
            // 
            // novoClientelbl
            // 
            this.novoClientelbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.novoClientelbl.Location = new System.Drawing.Point(9, 50);
            this.novoClientelbl.Name = "novoClientelbl";
            this.novoClientelbl.Size = new System.Drawing.Size(259, 17);
            this.novoClientelbl.TabIndex = 9;
            this.novoClientelbl.Text = "Novo Cliente";
            // 
            // selecionarClientelbl
            // 
            this.selecionarClientelbl.Location = new System.Drawing.Point(1055, 12);
            this.selecionarClientelbl.Name = "selecionarClientelbl";
            this.selecionarClientelbl.Size = new System.Drawing.Size(265, 23);
            this.selecionarClientelbl.TabIndex = 10;
            this.selecionarClientelbl.Text = "Selecionar Cliente Existente";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Location = new System.Drawing.Point(6, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(262, 567);
            this.button1.TabIndex = 11;
            this.button1.Text = "Emitir Bilhete/ Bilhetes";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // clientesdgv
            // 
            this.clientesdgv.AutoGenerateColumns = false;
            this.clientesdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientesdgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome});
            this.clientesdgv.DataSource = this.pessoasClienteBindingSource2;
            this.clientesdgv.Location = new System.Drawing.Point(1058, 38);
            this.clientesdgv.Name = "clientesdgv";
            this.clientesdgv.Size = new System.Drawing.Size(262, 675);
            this.clientesdgv.TabIndex = 12;
            this.clientesdgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clientesdgv_CellContentClick);
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // pessoasClienteBindingSource2
            // 
            this.pessoasClienteBindingSource2.DataMember = "Pessoas_Cliente";
            this.pessoasClienteBindingSource2.DataSource = this.data1;
            // 
            // pessoasClienteBindingSource
            // 
            this.pessoasClienteBindingSource.DataMember = "Pessoas_Cliente";
            this.pessoasClienteBindingSource.DataSource = this.data1;
            // 
            // data
            // 
            this.data.DataSetName = "data";
            this.data.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bilhetesBindingSource1
            // 
            this.bilhetesBindingSource1.DataMember = "Bilhetes";
            this.bilhetesBindingSource1.DataSource = this.data;
            // 
            // bilhetesTableAdapter1
            // 
            this.bilhetesTableAdapter1.ClearBeforeFill = true;
            // 
            // bilhetesBindingSource2
            // 
            this.bilhetesBindingSource2.DataMember = "Bilhetes";
            this.bilhetesBindingSource2.DataSource = this.data1;
            // 
            // pessoas_ClienteTableAdapter
            // 
            this.pessoas_ClienteTableAdapter.ClearBeforeFill = true;
            // 
            // pessoasClienteBindingSource1
            // 
            this.pessoasClienteBindingSource1.DataMember = "Pessoas_Cliente";
            this.pessoasClienteBindingSource1.DataSource = this.data1;
            // 
            // Selecionar
            // 
            this.Selecionar.HeaderText = "Selecionar";
            this.Selecionar.MinimumWidth = 8;
            this.Selecionar.Name = "Selecionar";
            this.Selecionar.Width = 150;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // Lugar
            // 
            this.Lugar.DataPropertyName = "Lugar";
            this.Lugar.HeaderText = "Lugar";
            this.Lugar.MinimumWidth = 8;
            this.Lugar.Name = "Lugar";
            this.Lugar.Width = 150;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // dataHoraDataGridViewTextBoxColumn
            // 
            this.dataHoraDataGridViewTextBoxColumn.DataPropertyName = "DataHora";
            this.dataHoraDataGridViewTextBoxColumn.HeaderText = "DataHora";
            this.dataHoraDataGridViewTextBoxColumn.Name = "dataHoraDataGridViewTextBoxColumn";
            // 
            // FormAtendimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 726);
            this.Controls.Add(this.clientesdgv);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.selecionarClientelbl);
            this.Controls.Add(this.novoClientelbl);
            this.Controls.Add(this.funcionariolbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cliente_Numfiscaltb);
            this.Controls.Add(this.cliente_Moradatb);
            this.Controls.Add(this.cliente_Nometb);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "FormAtendimento";
            this.Text = "FormAtendimento";
            this.Load += new System.EventHandler(this.FormAtendimento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilhetesBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilhetesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cineGestDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessãoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesdgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasClienteBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilhetesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilhetesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasClienteBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private CineGestDataSet cineGestDataSet;
        private System.Windows.Forms.BindingSource sessãoBindingSource;
        private CineGestDataSetTableAdapters.SessãoTableAdapter sessãoTableAdapter;
        private System.Windows.Forms.BindingSource bilhetesBindingSource;
        private CineGestDataSetTableAdapters.BilhetesTableAdapter bilhetesTableAdapter;
        private data data;
        private System.Windows.Forms.BindingSource bilhetesBindingSource1;
        private dataTableAdapters.BilhetesTableAdapter bilhetesTableAdapter1;
        private data data1;
        private System.Windows.Forms.BindingSource bilhetesBindingSource2;
        private System.Windows.Forms.BindingSource bilhetesBindingSource3;
        private System.Windows.Forms.TextBox cliente_Nometb;
        private System.Windows.Forms.TextBox cliente_Moradatb;
        private System.Windows.Forms.TextBox cliente_Numfiscaltb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label funcionariolbl;
        private System.Windows.Forms.Label novoClientelbl;
        private System.Windows.Forms.Label selecionarClientelbl;
        private System.Windows.Forms.BindingSource pessoasClienteBindingSource;
        private dataTableAdapters.Pessoas_ClienteTableAdapter pessoas_ClienteTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource pessoasClienteBindingSource1;
        private System.Windows.Forms.DataGridView clientesdgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.BindingSource pessoasClienteBindingSource2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selecionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lugar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataHoraDataGridViewTextBoxColumn;
    }
}