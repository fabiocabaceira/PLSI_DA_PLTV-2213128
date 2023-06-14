namespace Cinegest.Forms
{
    partial class FormFilmes
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
            this.filmesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cineGestDataSet = new Cinegest.CineGestDataSet();
            this.filmesTableAdapter = new Cinegest.CineGestDataSetTableAdapters.FilmesTableAdapter();
            this.filmesdgv = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duracaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.activolbl = new System.Windows.Forms.Label();
            this.duracaoFilmelbl = new System.Windows.Forms.Label();
            this.nomeFilmelbl = new System.Windows.Forms.Label();
            this.filmelbl = new System.Windows.Forms.Label();
            this.activoFilmetb = new System.Windows.Forms.TextBox();
            this.duracaoFilmetb = new System.Windows.Forms.TextBox();
            this.nomeFilmetb = new System.Windows.Forms.TextBox();
            this.novoFilmebtn = new System.Windows.Forms.Button();
            this.apagarFilmebtn = new System.Windows.Forms.Button();
            this.alterarFilmebtn = new System.Windows.Forms.Button();
            this.categorialbl = new System.Windows.Forms.Label();
            this.categoriaFilmecb = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.filmesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cineGestDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmesdgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // filmesBindingSource
            // 
            this.filmesBindingSource.DataMember = "Filmes";
            this.filmesBindingSource.DataSource = this.cineGestDataSet;
            // 
            // cineGestDataSet
            // 
            this.cineGestDataSet.DataSetName = "CineGestDataSet";
            this.cineGestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // filmesTableAdapter
            // 
            this.filmesTableAdapter.ClearBeforeFill = true;
            // 
            // filmesdgv
            // 
            this.filmesdgv.AutoGenerateColumns = false;
            this.filmesdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.filmesdgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.Nome,
            this.duracaoDataGridViewTextBoxColumn,
            this.activoDataGridViewTextBoxColumn,
            this.categoriaIdDataGridViewTextBoxColumn});
            this.filmesdgv.DataSource = this.filmesBindingSource1;
            this.filmesdgv.Location = new System.Drawing.Point(12, 12);
            this.filmesdgv.Name = "filmesdgv";
            this.filmesdgv.Size = new System.Drawing.Size(600, 474);
            this.filmesdgv.TabIndex = 0;
            this.filmesdgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.filmesdgv_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // duracaoDataGridViewTextBoxColumn
            // 
            this.duracaoDataGridViewTextBoxColumn.DataPropertyName = "Duracao";
            this.duracaoDataGridViewTextBoxColumn.HeaderText = "Duracao";
            this.duracaoDataGridViewTextBoxColumn.Name = "duracaoDataGridViewTextBoxColumn";
            // 
            // activoDataGridViewTextBoxColumn
            // 
            this.activoDataGridViewTextBoxColumn.DataPropertyName = "Activo";
            this.activoDataGridViewTextBoxColumn.HeaderText = "Activo";
            this.activoDataGridViewTextBoxColumn.Name = "activoDataGridViewTextBoxColumn";
            // 
            // categoriaIdDataGridViewTextBoxColumn
            // 
            this.categoriaIdDataGridViewTextBoxColumn.DataPropertyName = "Categoria_Id";
            this.categoriaIdDataGridViewTextBoxColumn.HeaderText = "Categoria_Id";
            this.categoriaIdDataGridViewTextBoxColumn.Name = "categoriaIdDataGridViewTextBoxColumn";
            // 
            // filmesBindingSource1
            // 
            this.filmesBindingSource1.DataMember = "Filmes";
            this.filmesBindingSource1.DataSource = this.cineGestDataSet;
            // 
            // activolbl
            // 
            this.activolbl.Location = new System.Drawing.Point(621, 158);
            this.activolbl.Name = "activolbl";
            this.activolbl.Size = new System.Drawing.Size(345, 23);
            this.activolbl.TabIndex = 22;
            this.activolbl.Text = "Activo";
            this.activolbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // duracaoFilmelbl
            // 
            this.duracaoFilmelbl.Location = new System.Drawing.Point(618, 109);
            this.duracaoFilmelbl.Name = "duracaoFilmelbl";
            this.duracaoFilmelbl.Size = new System.Drawing.Size(349, 23);
            this.duracaoFilmelbl.TabIndex = 21;
            this.duracaoFilmelbl.Text = "Duração";
            this.duracaoFilmelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nomeFilmelbl
            // 
            this.nomeFilmelbl.Location = new System.Drawing.Point(621, 60);
            this.nomeFilmelbl.Name = "nomeFilmelbl";
            this.nomeFilmelbl.Size = new System.Drawing.Size(346, 23);
            this.nomeFilmelbl.TabIndex = 20;
            this.nomeFilmelbl.Text = "Nome";
            this.nomeFilmelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // filmelbl
            // 
            this.filmelbl.Location = new System.Drawing.Point(624, 12);
            this.filmelbl.Name = "filmelbl";
            this.filmelbl.Size = new System.Drawing.Size(342, 23);
            this.filmelbl.TabIndex = 19;
            this.filmelbl.Text = "Alterar Filme Selecionado";
            this.filmelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // activoFilmetb
            // 
            this.activoFilmetb.Location = new System.Drawing.Point(621, 188);
            this.activoFilmetb.Name = "activoFilmetb";
            this.activoFilmetb.Size = new System.Drawing.Size(345, 20);
            this.activoFilmetb.TabIndex = 18;
            // 
            // duracaoFilmetb
            // 
            this.duracaoFilmetb.Location = new System.Drawing.Point(621, 135);
            this.duracaoFilmetb.Name = "duracaoFilmetb";
            this.duracaoFilmetb.Size = new System.Drawing.Size(345, 20);
            this.duracaoFilmetb.TabIndex = 17;
            // 
            // nomeFilmetb
            // 
            this.nomeFilmetb.Location = new System.Drawing.Point(621, 86);
            this.nomeFilmetb.Name = "nomeFilmetb";
            this.nomeFilmetb.Size = new System.Drawing.Size(344, 20);
            this.nomeFilmetb.TabIndex = 16;
            // 
            // novoFilmebtn
            // 
            this.novoFilmebtn.Location = new System.Drawing.Point(1054, 12);
            this.novoFilmebtn.Name = "novoFilmebtn";
            this.novoFilmebtn.Size = new System.Drawing.Size(75, 195);
            this.novoFilmebtn.TabIndex = 15;
            this.novoFilmebtn.Text = "Criar Filme";
            this.novoFilmebtn.UseVisualStyleBackColor = true;
            this.novoFilmebtn.Click += new System.EventHandler(this.novoFilmebtn_Click);
            // 
            // apagarFilmebtn
            // 
            this.apagarFilmebtn.Location = new System.Drawing.Point(1135, 12);
            this.apagarFilmebtn.Name = "apagarFilmebtn";
            this.apagarFilmebtn.Size = new System.Drawing.Size(75, 196);
            this.apagarFilmebtn.TabIndex = 14;
            this.apagarFilmebtn.Text = "Apagar ";
            this.apagarFilmebtn.UseVisualStyleBackColor = true;
            this.apagarFilmebtn.Click += new System.EventHandler(this.apagarFilmebtn_Click);
            // 
            // alterarFilmebtn
            // 
            this.alterarFilmebtn.Location = new System.Drawing.Point(973, 12);
            this.alterarFilmebtn.Name = "alterarFilmebtn";
            this.alterarFilmebtn.Size = new System.Drawing.Size(75, 196);
            this.alterarFilmebtn.TabIndex = 13;
            this.alterarFilmebtn.Text = "Guardar Alterações";
            this.alterarFilmebtn.UseVisualStyleBackColor = true;
            this.alterarFilmebtn.Click += new System.EventHandler(this.alterarFilmebtn_Click);
            // 
            // categorialbl
            // 
            this.categorialbl.Location = new System.Drawing.Point(621, 211);
            this.categorialbl.Name = "categorialbl";
            this.categorialbl.Size = new System.Drawing.Size(345, 23);
            this.categorialbl.TabIndex = 26;
            this.categorialbl.Text = "Categoria";
            this.categorialbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // categoriaFilmecb
            // 
            this.categoriaFilmecb.FormattingEnabled = true;
            this.categoriaFilmecb.Location = new System.Drawing.Point(624, 237);
            this.categoriaFilmecb.Name = "categoriaFilmecb";
            this.categoriaFilmecb.Size = new System.Drawing.Size(341, 21);
            this.categoriaFilmecb.TabIndex = 27;
            // 
            // FormFilmes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 643);
            this.Controls.Add(this.categoriaFilmecb);
            this.Controls.Add(this.categorialbl);
            this.Controls.Add(this.activolbl);
            this.Controls.Add(this.duracaoFilmelbl);
            this.Controls.Add(this.nomeFilmelbl);
            this.Controls.Add(this.filmelbl);
            this.Controls.Add(this.activoFilmetb);
            this.Controls.Add(this.duracaoFilmetb);
            this.Controls.Add(this.nomeFilmetb);
            this.Controls.Add(this.novoFilmebtn);
            this.Controls.Add(this.apagarFilmebtn);
            this.Controls.Add(this.alterarFilmebtn);
            this.Controls.Add(this.filmesdgv);
            this.Name = "FormFilmes";
            this.Text = "FormFilmes";
            this.Load += new System.EventHandler(this.FormFilmes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.filmesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cineGestDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmesdgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmesBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CineGestDataSet cineGestDataSet;
        private System.Windows.Forms.BindingSource filmesBindingSource;
        private CineGestDataSetTableAdapters.FilmesTableAdapter filmesTableAdapter;
        private System.Windows.Forms.DataGridView filmesdgv;
        private System.Windows.Forms.BindingSource filmesBindingSource1;
        private System.Windows.Forms.Label activolbl;
        private System.Windows.Forms.Label duracaoFilmelbl;
        private System.Windows.Forms.Label nomeFilmelbl;
        private System.Windows.Forms.Label filmelbl;
        private System.Windows.Forms.TextBox activoFilmetb;
        private System.Windows.Forms.TextBox duracaoFilmetb;
        private System.Windows.Forms.TextBox nomeFilmetb;
        private System.Windows.Forms.Button novoFilmebtn;
        private System.Windows.Forms.Button apagarFilmebtn;
        private System.Windows.Forms.Button alterarFilmebtn;
        private System.Windows.Forms.Label categorialbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn duracaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn activoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox categoriaFilmecb;
    }
}