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
            this.components = new System.ComponentModel.Container();
            this.Cinemabtn = new System.Windows.Forms.Button();
            this.Funcionariosbtn = new System.Windows.Forms.Button();
            this.Clientesbtn = new System.Windows.Forms.Button();
            this.Sessõesbtn = new System.Windows.Forms.Button();
            this.Filmesbtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sessãoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.data = new Cinegest.data();
            this.sessãoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sessãoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cineGestDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cineGestDataSet = new Cinegest.CineGestDataSet();
            this.cinemasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sessãoTableAdapter = new Cinegest.CineGestDataSetTableAdapters.SessãoTableAdapter();
            this.cinemasTableAdapter = new Cinegest.CineGestDataSetTableAdapters.CinemasTableAdapter();
            this.selecionar_funcionario_cb = new System.Windows.Forms.ComboBox();
            this.pessoasBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.pessoasFuncionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pessoasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pessoasTableAdapter = new Cinegest.CineGestDataSetTableAdapters.PessoasTableAdapter();
            this.funcionario_atual_lbl = new System.Windows.Forms.Label();
            this.sessãoTableAdapter1 = new Cinegest.dataTableAdapters.SessãoTableAdapter();
            this.pessoasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pessoasTableAdapter1 = new Cinegest.dataTableAdapters.PessoasTableAdapter();
            this.pessoas_FuncionarioTableAdapter = new Cinegest.dataTableAdapters.Pessoas_FuncionarioTableAdapter();
            this.filmeNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdSessao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datahora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessãoBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessãoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessãoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cineGestDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cineGestDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasFuncionarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // Cinemabtn
            // 
            this.Cinemabtn.Location = new System.Drawing.Point(858, 54);
            this.Cinemabtn.Name = "Cinemabtn";
            this.Cinemabtn.Size = new System.Drawing.Size(143, 72);
            this.Cinemabtn.TabIndex = 0;
            this.Cinemabtn.Text = "Cinema";
            this.Cinemabtn.UseVisualStyleBackColor = true;
            this.Cinemabtn.Click += new System.EventHandler(this.Cinemabtn_Click);
            // 
            // Funcionariosbtn
            // 
            this.Funcionariosbtn.Location = new System.Drawing.Point(858, 366);
            this.Funcionariosbtn.Name = "Funcionariosbtn";
            this.Funcionariosbtn.Size = new System.Drawing.Size(143, 72);
            this.Funcionariosbtn.TabIndex = 1;
            this.Funcionariosbtn.Text = "Funcionários";
            this.Funcionariosbtn.UseVisualStyleBackColor = true;
            this.Funcionariosbtn.Click += new System.EventHandler(this.Funcionariosbtn_Click);
            // 
            // Clientesbtn
            // 
            this.Clientesbtn.Location = new System.Drawing.Point(858, 288);
            this.Clientesbtn.Name = "Clientesbtn";
            this.Clientesbtn.Size = new System.Drawing.Size(143, 72);
            this.Clientesbtn.TabIndex = 2;
            this.Clientesbtn.Text = "Clientes";
            this.Clientesbtn.UseVisualStyleBackColor = true;
            this.Clientesbtn.Click += new System.EventHandler(this.Clientesbtn_Click);
            // 
            // Sessõesbtn
            // 
            this.Sessõesbtn.Location = new System.Drawing.Point(858, 210);
            this.Sessõesbtn.Name = "Sessõesbtn";
            this.Sessõesbtn.Size = new System.Drawing.Size(143, 72);
            this.Sessõesbtn.TabIndex = 3;
            this.Sessõesbtn.Text = "Sessões";
            this.Sessõesbtn.UseVisualStyleBackColor = true;
            this.Sessõesbtn.Click += new System.EventHandler(this.Sessõesbtn_Click);
            // 
            // Filmesbtn
            // 
            this.Filmesbtn.Location = new System.Drawing.Point(858, 132);
            this.Filmesbtn.Name = "Filmesbtn";
            this.Filmesbtn.Size = new System.Drawing.Size(143, 72);
            this.Filmesbtn.TabIndex = 4;
            this.Filmesbtn.Text = "Filmes";
            this.Filmesbtn.UseVisualStyleBackColor = true;
            this.Filmesbtn.Click += new System.EventHandler(this.Filmesbtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.filmeNome,
            this.IdSessao,
            this.datahora,
            this.precoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sessãoBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(160, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(648, 384);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // sessãoBindingSource2
            // 
            this.sessãoBindingSource2.DataMember = "Sessão";
            this.sessãoBindingSource2.DataSource = this.data;
            // 
            // data
            // 
            this.data.DataSetName = "data";
            this.data.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sessãoBindingSource1
            // 
            this.sessãoBindingSource1.DataMember = "Sessão";
            this.sessãoBindingSource1.DataSource = this.data;
            // 
            // sessãoBindingSource
            // 
            this.sessãoBindingSource.DataMember = "Sessão";
            this.sessãoBindingSource.DataSource = this.cineGestDataSetBindingSource;
            // 
            // cineGestDataSetBindingSource
            // 
            this.cineGestDataSetBindingSource.DataSource = this.cineGestDataSet;
            this.cineGestDataSetBindingSource.Position = 0;
            // 
            // cineGestDataSet
            // 
            this.cineGestDataSet.DataSetName = "CineGestDataSet";
            this.cineGestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cinemasBindingSource
            // 
            this.cinemasBindingSource.DataMember = "Cinemas";
            this.cinemasBindingSource.DataSource = this.cineGestDataSetBindingSource;
            // 
            // sessãoTableAdapter
            // 
            this.sessãoTableAdapter.ClearBeforeFill = true;
            // 
            // cinemasTableAdapter
            // 
            this.cinemasTableAdapter.ClearBeforeFill = true;
            // 
            // selecionar_funcionario_cb
            // 
            this.selecionar_funcionario_cb.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.pessoasBindingSource2, "Nome", true));
            this.selecionar_funcionario_cb.DataSource = this.pessoasFuncionarioBindingSource;
            this.selecionar_funcionario_cb.DisplayMember = "Nome";
            this.selecionar_funcionario_cb.FormattingEnabled = true;
            this.selecionar_funcionario_cb.Location = new System.Drawing.Point(12, 54);
            this.selecionar_funcionario_cb.Name = "selecionar_funcionario_cb";
            this.selecionar_funcionario_cb.Size = new System.Drawing.Size(142, 21);
            this.selecionar_funcionario_cb.TabIndex = 8;
            this.selecionar_funcionario_cb.ValueMember = "Nome";
            // 
            // pessoasBindingSource2
            // 
            this.pessoasBindingSource2.DataMember = "Pessoas";
            this.pessoasBindingSource2.DataSource = this.data;
            // 
            // pessoasFuncionarioBindingSource
            // 
            this.pessoasFuncionarioBindingSource.DataMember = "Pessoas_Funcionario";
            this.pessoasFuncionarioBindingSource.DataSource = this.data;
            // 
            // pessoasBindingSource
            // 
            this.pessoasBindingSource.DataMember = "Pessoas";
            this.pessoasBindingSource.DataSource = this.cineGestDataSetBindingSource;
            // 
            // pessoasTableAdapter
            // 
            this.pessoasTableAdapter.ClearBeforeFill = true;
            // 
            // funcionario_atual_lbl
            // 
            this.funcionario_atual_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.funcionario_atual_lbl.Location = new System.Drawing.Point(12, 32);
            this.funcionario_atual_lbl.Name = "funcionario_atual_lbl";
            this.funcionario_atual_lbl.Size = new System.Drawing.Size(142, 19);
            this.funcionario_atual_lbl.TabIndex = 9;
            this.funcionario_atual_lbl.Text = "Funcionário atual";
            this.funcionario_atual_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // sessãoTableAdapter1
            // 
            this.sessãoTableAdapter1.ClearBeforeFill = true;
            // 
            // pessoasBindingSource1
            // 
            this.pessoasBindingSource1.DataMember = "Pessoas";
            this.pessoasBindingSource1.DataSource = this.data;
            // 
            // pessoasTableAdapter1
            // 
            this.pessoasTableAdapter1.ClearBeforeFill = true;
            // 
            // pessoas_FuncionarioTableAdapter
            // 
            this.pessoas_FuncionarioTableAdapter.ClearBeforeFill = true;
            // 
            // filmeNome
            // 
            this.filmeNome.DataPropertyName = "Nome";
            this.filmeNome.HeaderText = "Nome";
            this.filmeNome.Name = "filmeNome";
            this.filmeNome.ReadOnly = true;
            // 
            // IdSessao
            // 
            this.IdSessao.DataPropertyName = "IdSessao";
            this.IdSessao.HeaderText = "IdSessao";
            this.IdSessao.Name = "IdSessao";
            this.IdSessao.ReadOnly = true;
            // 
            // datahora
            // 
            this.datahora.DataPropertyName = "DataHora";
            this.datahora.HeaderText = "DataHora";
            this.datahora.Name = "datahora";
            this.datahora.ReadOnly = true;
            // 
            // precoDataGridViewTextBoxColumn
            // 
            this.precoDataGridViewTextBoxColumn.DataPropertyName = "Preco";
            this.precoDataGridViewTextBoxColumn.HeaderText = "Preco";
            this.precoDataGridViewTextBoxColumn.Name = "precoDataGridViewTextBoxColumn";
            this.precoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 453);
            this.Controls.Add(this.funcionario_atual_lbl);
            this.Controls.Add(this.selecionar_funcionario_cb);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Filmesbtn);
            this.Controls.Add(this.Sessõesbtn);
            this.Controls.Add(this.Clientesbtn);
            this.Controls.Add(this.Funcionariosbtn);
            this.Controls.Add(this.Cinemabtn);
            this.Name = "FormPrincipal";
            this.Text = "FormPrincipal";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessãoBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessãoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessãoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cineGestDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cineGestDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasFuncionarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Cinemabtn;
        private System.Windows.Forms.Button Funcionariosbtn;
        private System.Windows.Forms.Button Clientesbtn;
        private System.Windows.Forms.Button Sessõesbtn;
        private System.Windows.Forms.Button Filmesbtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource cineGestDataSetBindingSource;
        private CineGestDataSet cineGestDataSet;
        private System.Windows.Forms.BindingSource sessãoBindingSource;
        private CineGestDataSetTableAdapters.SessãoTableAdapter sessãoTableAdapter;
        private System.Windows.Forms.BindingSource cinemasBindingSource;
        private CineGestDataSetTableAdapters.CinemasTableAdapter cinemasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaIdSalaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSessaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmeIdFilmeDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox selecionar_funcionario_cb;
        private System.Windows.Forms.BindingSource pessoasBindingSource;
        private CineGestDataSetTableAdapters.PessoasTableAdapter pessoasTableAdapter;
        private System.Windows.Forms.Label funcionario_atual_lbl;
        private data data;
        private System.Windows.Forms.BindingSource sessãoBindingSource1;
        private dataTableAdapters.SessãoTableAdapter sessãoTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn activoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lugarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sessãoIdSessaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource pessoasBindingSource1;
        private dataTableAdapters.PessoasTableAdapter pessoasTableAdapter1;
        private System.Windows.Forms.BindingSource pessoasFuncionarioBindingSource;
        private dataTableAdapters.Pessoas_FuncionarioTableAdapter pessoas_FuncionarioTableAdapter;
        private System.Windows.Forms.BindingSource pessoasBindingSource2;
        private System.Windows.Forms.BindingSource sessãoBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmeNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSessao;
        private System.Windows.Forms.DataGridViewTextBoxColumn datahora;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoDataGridViewTextBoxColumn;
    }
}