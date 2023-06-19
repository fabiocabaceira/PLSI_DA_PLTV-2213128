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
            this.funcionariocb = new System.Windows.Forms.ComboBox();
            this.pessoasFuncionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cineGestDataSet = new Cinegest.CineGestDataSet();
            this.sessoesdgv = new System.Windows.Forms.DataGridView();
            this.salaIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datahora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FilmeNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sessaosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cineGestDataSet1 = new Cinegest.CineGestDataSet();
            this.pessoas_FuncionarioTableAdapter = new Cinegest.CineGestDataSetTableAdapters.Pessoas_FuncionarioTableAdapter();
            this.sessaosTableAdapter = new Cinegest.CineGestDataSetTableAdapters.SessaosTableAdapter();
            this.cinemabtn = new System.Windows.Forms.Button();
            this.filmesbtn = new System.Windows.Forms.Button();
            this.sessaobtn = new System.Windows.Forms.Button();
            this.clientesbtn = new System.Windows.Forms.Button();
            this.funcionariosbtn = new System.Windows.Forms.Button();
            this.funcionariolbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasFuncionarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cineGestDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessoesdgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessaosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cineGestDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // funcionariocb
            // 
            this.funcionariocb.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.pessoasFuncionarioBindingSource, "Nome", true));
            this.funcionariocb.DataSource = this.pessoasFuncionarioBindingSource;
            this.funcionariocb.DisplayMember = "Nome";
            this.funcionariocb.FormattingEnabled = true;
            this.funcionariocb.Location = new System.Drawing.Point(12, 43);
            this.funcionariocb.Name = "funcionariocb";
            this.funcionariocb.Size = new System.Drawing.Size(121, 21);
            this.funcionariocb.TabIndex = 0;
            this.funcionariocb.ValueMember = "Nome";
            // 
            // pessoasFuncionarioBindingSource
            // 
            this.pessoasFuncionarioBindingSource.DataMember = "Pessoas_Funcionario";
            this.pessoasFuncionarioBindingSource.DataSource = this.cineGestDataSet;
            // 
            // cineGestDataSet
            // 
            this.cineGestDataSet.DataSetName = "CineGestDataSet";
            this.cineGestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sessoesdgv
            // 
            this.sessoesdgv.AutoGenerateColumns = false;
            this.sessoesdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sessoesdgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.salaIdDataGridViewTextBoxColumn,
            this.Datahora,
            this.precoDataGridViewTextBoxColumn,
            this.FilmeNome,
            this.Id});
            this.sessoesdgv.DataSource = this.sessaosBindingSource;
            this.sessoesdgv.Location = new System.Drawing.Point(139, 43);
            this.sessoesdgv.Name = "sessoesdgv";
            this.sessoesdgv.RowHeadersWidth = 62;
            this.sessoesdgv.Size = new System.Drawing.Size(604, 257);
            this.sessoesdgv.TabIndex = 1;
            this.sessoesdgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sessoesdgv_CellContentClick);
            // 
            // salaIdDataGridViewTextBoxColumn
            // 
            this.salaIdDataGridViewTextBoxColumn.DataPropertyName = "SalaId";
            this.salaIdDataGridViewTextBoxColumn.HeaderText = "SalaId";
            this.salaIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.salaIdDataGridViewTextBoxColumn.Name = "salaIdDataGridViewTextBoxColumn";
            this.salaIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // Datahora
            // 
            this.Datahora.DataPropertyName = "Datahora";
            this.Datahora.HeaderText = "Datahora";
            this.Datahora.MinimumWidth = 8;
            this.Datahora.Name = "Datahora";
            this.Datahora.Width = 150;
            // 
            // precoDataGridViewTextBoxColumn
            // 
            this.precoDataGridViewTextBoxColumn.DataPropertyName = "Preco";
            this.precoDataGridViewTextBoxColumn.HeaderText = "Preco";
            this.precoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.precoDataGridViewTextBoxColumn.Name = "precoDataGridViewTextBoxColumn";
            this.precoDataGridViewTextBoxColumn.Width = 150;
            // 
            // FilmeNome
            // 
            this.FilmeNome.DataPropertyName = "Nome";
            this.FilmeNome.HeaderText = "Nome";
            this.FilmeNome.MinimumWidth = 8;
            this.FilmeNome.Name = "FilmeNome";
            this.FilmeNome.Width = 150;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 8;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 150;
            // 
            // sessaosBindingSource
            // 
            this.sessaosBindingSource.DataMember = "Sessaos";
            this.sessaosBindingSource.DataSource = this.cineGestDataSet1;
            // 
            // cineGestDataSet1
            // 
            this.cineGestDataSet1.DataSetName = "CineGestDataSet";
            this.cineGestDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pessoas_FuncionarioTableAdapter
            // 
            this.pessoas_FuncionarioTableAdapter.ClearBeforeFill = true;
            // 
            // sessaosTableAdapter
            // 
            this.sessaosTableAdapter.ClearBeforeFill = true;
            // 
            // cinemabtn
            // 
            this.cinemabtn.Location = new System.Drawing.Point(139, 14);
            this.cinemabtn.Name = "cinemabtn";
            this.cinemabtn.Size = new System.Drawing.Size(116, 23);
            this.cinemabtn.TabIndex = 5;
            this.cinemabtn.Text = "Cinema";
            this.cinemabtn.UseVisualStyleBackColor = true;
            this.cinemabtn.Click += new System.EventHandler(this.cinemabtn_Click);
            // 
            // filmesbtn
            // 
            this.filmesbtn.Location = new System.Drawing.Point(261, 14);
            this.filmesbtn.Name = "filmesbtn";
            this.filmesbtn.Size = new System.Drawing.Size(116, 23);
            this.filmesbtn.TabIndex = 6;
            this.filmesbtn.Text = "Filmes";
            this.filmesbtn.UseVisualStyleBackColor = true;
            this.filmesbtn.Click += new System.EventHandler(this.filmesbtn_Click);
            // 
            // sessaobtn
            // 
            this.sessaobtn.Location = new System.Drawing.Point(383, 14);
            this.sessaobtn.Name = "sessaobtn";
            this.sessaobtn.Size = new System.Drawing.Size(116, 23);
            this.sessaobtn.TabIndex = 7;
            this.sessaobtn.Text = "Sessões";
            this.sessaobtn.UseVisualStyleBackColor = true;
            this.sessaobtn.Click += new System.EventHandler(this.sessaobtn_Click);
            // 
            // clientesbtn
            // 
            this.clientesbtn.Location = new System.Drawing.Point(505, 14);
            this.clientesbtn.Name = "clientesbtn";
            this.clientesbtn.Size = new System.Drawing.Size(116, 23);
            this.clientesbtn.TabIndex = 8;
            this.clientesbtn.Text = "Clientes";
            this.clientesbtn.UseVisualStyleBackColor = true;
            this.clientesbtn.Click += new System.EventHandler(this.clientesbtn_Click);
            // 
            // funcionariosbtn
            // 
            this.funcionariosbtn.Location = new System.Drawing.Point(627, 14);
            this.funcionariosbtn.Name = "funcionariosbtn";
            this.funcionariosbtn.Size = new System.Drawing.Size(116, 23);
            this.funcionariosbtn.TabIndex = 9;
            this.funcionariosbtn.Text = "Funcionarios";
            this.funcionariosbtn.UseVisualStyleBackColor = true;
            this.funcionariosbtn.Click += new System.EventHandler(this.funcionariosbtn_Click);
            // 
            // funcionariolbl
            // 
            this.funcionariolbl.Location = new System.Drawing.Point(12, 23);
            this.funcionariolbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.funcionariolbl.Name = "funcionariolbl";
            this.funcionariolbl.Size = new System.Drawing.Size(122, 16);
            this.funcionariolbl.TabIndex = 11;
            this.funcionariolbl.Text = "Funcionário atual:";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 325);
            this.Controls.Add(this.funcionariolbl);
            this.Controls.Add(this.funcionariosbtn);
            this.Controls.Add(this.clientesbtn);
            this.Controls.Add(this.sessaobtn);
            this.Controls.Add(this.filmesbtn);
            this.Controls.Add(this.cinemabtn);
            this.Controls.Add(this.sessoesdgv);
            this.Controls.Add(this.funcionariocb);
            this.Name = "FormPrincipal";
            this.Text = "FormPrincipal";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pessoasFuncionarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cineGestDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessoesdgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessaosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cineGestDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox funcionariocb;
        private System.Windows.Forms.DataGridView sessoesdgv;
        private CineGestDataSet cineGestDataSet;
        private System.Windows.Forms.BindingSource pessoasFuncionarioBindingSource;
        private CineGestDataSetTableAdapters.Pessoas_FuncionarioTableAdapter pessoas_FuncionarioTableAdapter;
        private CineGestDataSet cineGestDataSet1;
        private System.Windows.Forms.BindingSource sessaosBindingSource;
        private CineGestDataSetTableAdapters.SessaosTableAdapter sessaosTableAdapter;
        private System.Windows.Forms.Button cinemabtn;
        private System.Windows.Forms.Button filmesbtn;
        private System.Windows.Forms.Button sessaobtn;
        private System.Windows.Forms.Button clientesbtn;
        private System.Windows.Forms.Button funcionariosbtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datahora;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilmeNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.Label funcionariolbl;
    }
}