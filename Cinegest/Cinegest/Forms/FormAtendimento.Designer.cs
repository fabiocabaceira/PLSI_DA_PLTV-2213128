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
            this.data = new Cinegest.data();
            this.bilhetesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bilhetesTableAdapter1 = new Cinegest.dataTableAdapters.BilhetesTableAdapter();
            this.bilhetesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.Lugar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataHoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilhetesBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilhetesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cineGestDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessãoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilhetesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilhetesBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Lugar,
            this.Estado,
            this.dataHoraDataGridViewTextBoxColumn,
            this.Nome,
            this.Preco});
            this.dataGridView1.DataSource = this.bilhetesBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(18, 18);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(829, 705);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
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
            this.Estado.MinimumWidth = 8;
            this.Estado.Name = "Estado";
            this.Estado.Width = 150;
            // 
            // dataHoraDataGridViewTextBoxColumn
            // 
            this.dataHoraDataGridViewTextBoxColumn.DataPropertyName = "DataHora";
            this.dataHoraDataGridViewTextBoxColumn.HeaderText = "DataHora";
            this.dataHoraDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dataHoraDataGridViewTextBoxColumn.Name = "dataHoraDataGridViewTextBoxColumn";
            this.dataHoraDataGridViewTextBoxColumn.Width = 150;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.MinimumWidth = 8;
            this.Nome.Name = "Nome";
            this.Nome.Width = 150;
            // 
            // Preco
            // 
            this.Preco.DataPropertyName = "Preco";
            this.Preco.HeaderText = "Preco";
            this.Preco.MinimumWidth = 8;
            this.Preco.Name = "Preco";
            this.Preco.Width = 150;
            // 
            // FormAtendimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 742);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormAtendimento";
            this.Text = "FormAtendimento";
            this.Load += new System.EventHandler(this.FormAtendimento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilhetesBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilhetesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cineGestDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessãoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilhetesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilhetesBindingSource2)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.DataGridViewTextBoxColumn Lugar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataHoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preco;
    }
}