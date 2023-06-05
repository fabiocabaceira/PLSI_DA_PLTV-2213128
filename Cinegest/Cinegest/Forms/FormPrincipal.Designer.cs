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
            this.idSessaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataHoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaIdSalaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmeIdFilmeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sessãoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cineGestDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cineGestDataSet = new Cinegest.CineGestDataSet();
            this.cinemasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sessãoTableAdapter = new Cinegest.CineGestDataSetTableAdapters.SessãoTableAdapter();
            this.cinemasTableAdapter = new Cinegest.CineGestDataSetTableAdapters.CinemasTableAdapter();
            this.filterByCurrentDateToolStrip = new System.Windows.Forms.ToolStrip();
            this.filterByCurrentDateToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessãoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cineGestDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cineGestDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemasBindingSource)).BeginInit();
            this.filterByCurrentDateToolStrip.SuspendLayout();
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
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idSessaoDataGridViewTextBoxColumn,
            this.dataHoraDataGridViewTextBoxColumn,
            this.precoDataGridViewTextBoxColumn,
            this.salaIdSalaDataGridViewTextBoxColumn,
            this.filmeIdFilmeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sessãoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(189, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(607, 342);
            this.dataGridView1.TabIndex = 5;
            // 
            // idSessaoDataGridViewTextBoxColumn
            // 
            this.idSessaoDataGridViewTextBoxColumn.DataPropertyName = "IdSessao";
            this.idSessaoDataGridViewTextBoxColumn.HeaderText = "IdSessao";
            this.idSessaoDataGridViewTextBoxColumn.Name = "idSessaoDataGridViewTextBoxColumn";
            this.idSessaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataHoraDataGridViewTextBoxColumn
            // 
            this.dataHoraDataGridViewTextBoxColumn.DataPropertyName = "DataHora";
            this.dataHoraDataGridViewTextBoxColumn.HeaderText = "DataHora";
            this.dataHoraDataGridViewTextBoxColumn.Name = "dataHoraDataGridViewTextBoxColumn";
            // 
            // precoDataGridViewTextBoxColumn
            // 
            this.precoDataGridViewTextBoxColumn.DataPropertyName = "Preco";
            this.precoDataGridViewTextBoxColumn.HeaderText = "Preco";
            this.precoDataGridViewTextBoxColumn.Name = "precoDataGridViewTextBoxColumn";
            // 
            // salaIdSalaDataGridViewTextBoxColumn
            // 
            this.salaIdSalaDataGridViewTextBoxColumn.DataPropertyName = "SalaIdSala";
            this.salaIdSalaDataGridViewTextBoxColumn.HeaderText = "SalaIdSala";
            this.salaIdSalaDataGridViewTextBoxColumn.Name = "salaIdSalaDataGridViewTextBoxColumn";
            // 
            // filmeIdFilmeDataGridViewTextBoxColumn
            // 
            this.filmeIdFilmeDataGridViewTextBoxColumn.DataPropertyName = "Filme_IdFilme";
            this.filmeIdFilmeDataGridViewTextBoxColumn.HeaderText = "Filme_IdFilme";
            this.filmeIdFilmeDataGridViewTextBoxColumn.Name = "filmeIdFilmeDataGridViewTextBoxColumn";
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
            // filterByCurrentDateToolStrip
            // 
            this.filterByCurrentDateToolStrip.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.filterByCurrentDateToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.filterByCurrentDateToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filterByCurrentDateToolStripButton});
            this.filterByCurrentDateToolStrip.Location = new System.Drawing.Point(446, 26);
            this.filterByCurrentDateToolStrip.Name = "filterByCurrentDateToolStrip";
            this.filterByCurrentDateToolStrip.ShowItemToolTips = false;
            this.filterByCurrentDateToolStrip.Size = new System.Drawing.Size(61, 25);
            this.filterByCurrentDateToolStrip.TabIndex = 7;
            this.filterByCurrentDateToolStrip.Text = "filterByCurrentDateToolStrip";
            // 
            // filterByCurrentDateToolStripButton
            // 
            this.filterByCurrentDateToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.filterByCurrentDateToolStripButton.Name = "filterByCurrentDateToolStripButton";
            this.filterByCurrentDateToolStripButton.Size = new System.Drawing.Size(49, 22);
            this.filterByCurrentDateToolStripButton.Text = "Update";
            this.filterByCurrentDateToolStripButton.Click += new System.EventHandler(this.filterByCurrentDateToolStripButton_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 450);
            this.Controls.Add(this.filterByCurrentDateToolStrip);
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
            ((System.ComponentModel.ISupportInitialize)(this.sessãoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cineGestDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cineGestDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemasBindingSource)).EndInit();
            this.filterByCurrentDateToolStrip.ResumeLayout(false);
            this.filterByCurrentDateToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.DataGridViewTextBoxColumn idSessaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataHoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaIdSalaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmeIdFilmeDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip filterByCurrentDateToolStrip;
        private System.Windows.Forms.ToolStripButton filterByCurrentDateToolStripButton;
    }
}