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
            this.emitirbtn = new System.Windows.Forms.Button();
            this.cliente_Moradatb = new System.Windows.Forms.TextBox();
            this.cliente_Nometb = new System.Windows.Forms.TextBox();
            this.cliente_Numfiscaltb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.funcionariolbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Selecionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Lugar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeSala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bilhetesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cineGestDataSet = new Cinegest.CineGestDataSet();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pessoasClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cineGestDataSet1 = new Cinegest.CineGestDataSet();
            this.clientelbl = new System.Windows.Forms.Label();
            this.bilhetesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bilhetesTableAdapter = new Cinegest.CineGestDataSetTableAdapters.BilhetesTableAdapter();
            this.pessoas_ClienteTableAdapter = new Cinegest.CineGestDataSetTableAdapters.Pessoas_ClienteTableAdapter();
            this.sessoeslbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilhetesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cineGestDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cineGestDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilhetesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // emitirbtn
            // 
            this.emitirbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emitirbtn.Location = new System.Drawing.Point(2, 260);
            this.emitirbtn.Name = "emitirbtn";
            this.emitirbtn.Size = new System.Drawing.Size(245, 188);
            this.emitirbtn.TabIndex = 0;
            this.emitirbtn.Text = "Emitir Bilhete";
            this.emitirbtn.UseVisualStyleBackColor = true;
            this.emitirbtn.Click += new System.EventHandler(this.Emitirbtn_Click);
            // 
            // cliente_Moradatb
            // 
            this.cliente_Moradatb.Location = new System.Drawing.Point(2, 188);
            this.cliente_Moradatb.Name = "cliente_Moradatb";
            this.cliente_Moradatb.Size = new System.Drawing.Size(245, 20);
            this.cliente_Moradatb.TabIndex = 1;
            // 
            // cliente_Nometb
            // 
            this.cliente_Nometb.Location = new System.Drawing.Point(2, 142);
            this.cliente_Nometb.Name = "cliente_Nometb";
            this.cliente_Nometb.Size = new System.Drawing.Size(245, 20);
            this.cliente_Nometb.TabIndex = 2;
            // 
            // cliente_Numfiscaltb
            // 
            this.cliente_Numfiscaltb.Location = new System.Drawing.Point(3, 234);
            this.cliente_Numfiscaltb.Name = "cliente_Numfiscaltb";
            this.cliente_Numfiscaltb.Size = new System.Drawing.Size(245, 20);
            this.cliente_Numfiscaltb.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "NumFiscal";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Morada";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-1, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nome";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // funcionariolbl
            // 
            this.funcionariolbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.funcionariolbl.Location = new System.Drawing.Point(0, 4);
            this.funcionariolbl.Name = "funcionariolbl";
            this.funcionariolbl.Size = new System.Drawing.Size(248, 23);
            this.funcionariolbl.TabIndex = 7;
            this.funcionariolbl.Text = "Funcionário Atual:";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(244, 40);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cliente";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selecionar,
            this.Lugar,
            this.Estado,
            this.NomeSala});
            this.dataGridView1.DataSource = this.bilhetesBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(256, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(455, 407);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellValueChanged);
            // 
            // Selecionar
            // 
            this.Selecionar.HeaderText = ":";
            this.Selecionar.Name = "Selecionar";
            // 
            // Lugar
            // 
            this.Lugar.DataPropertyName = "Lugar";
            this.Lugar.HeaderText = "Lugar";
            this.Lugar.Name = "Lugar";
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // NomeSala
            // 
            this.NomeSala.DataPropertyName = "Nome";
            this.NomeSala.HeaderText = "Nome";
            this.NomeSala.Name = "NomeSala";
            // 
            // bilhetesBindingSource1
            // 
            this.bilhetesBindingSource1.DataMember = "Bilhetes";
            this.bilhetesBindingSource1.DataSource = this.cineGestDataSet;
            // 
            // cineGestDataSet
            // 
            this.cineGestDataSet.DataSetName = "CineGestDataSet";
            this.cineGestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome});
            this.dataGridView3.DataSource = this.pessoasClienteBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(721, 37);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(231, 411);
            this.dataGridView3.TabIndex = 11;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView3_CellContentClick);
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // pessoasClienteBindingSource
            // 
            this.pessoasClienteBindingSource.DataMember = "Pessoas_Cliente";
            this.pessoasClienteBindingSource.DataSource = this.cineGestDataSet1;
            // 
            // cineGestDataSet1
            // 
            this.cineGestDataSet1.DataSetName = "CineGestDataSet";
            this.cineGestDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientelbl
            // 
            this.clientelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientelbl.Location = new System.Drawing.Point(717, 1);
            this.clientelbl.Name = "clientelbl";
            this.clientelbl.Size = new System.Drawing.Size(231, 37);
            this.clientelbl.TabIndex = 12;
            this.clientelbl.Text = "Selecionar Cliente:";
            this.clientelbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bilhetesBindingSource
            // 
            this.bilhetesBindingSource.DataMember = "Bilhetes";
            this.bilhetesBindingSource.DataSource = this.cineGestDataSet;
            // 
            // bilhetesTableAdapter
            // 
            this.bilhetesTableAdapter.ClearBeforeFill = true;
            // 
            // pessoas_ClienteTableAdapter
            // 
            this.pessoas_ClienteTableAdapter.ClearBeforeFill = true;
            // 
            // sessoeslbl
            // 
            this.sessoeslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sessoeslbl.Location = new System.Drawing.Point(256, 1);
            this.sessoeslbl.Name = "sessoeslbl";
            this.sessoeslbl.Size = new System.Drawing.Size(455, 37);
            this.sessoeslbl.TabIndex = 13;
            this.sessoeslbl.Text = "Sessões:";
            this.sessoeslbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormAtendimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 465);
            this.Controls.Add(this.sessoeslbl);
            this.Controls.Add(this.clientelbl);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.funcionariolbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cliente_Numfiscaltb);
            this.Controls.Add(this.cliente_Nometb);
            this.Controls.Add(this.cliente_Moradatb);
            this.Controls.Add(this.emitirbtn);
            this.MinimumSize = new System.Drawing.Size(987, 504);
            this.Name = "FormAtendimento";
            this.Text = "FormAtendimento";
            this.Load += new System.EventHandler(this.FormAtendimento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilhetesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cineGestDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cineGestDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilhetesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button emitirbtn;
        private System.Windows.Forms.TextBox cliente_Moradatb;
        private System.Windows.Forms.TextBox cliente_Nometb;
        private System.Windows.Forms.TextBox cliente_Numfiscaltb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label funcionariolbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private CineGestDataSet cineGestDataSet;
        private System.Windows.Forms.BindingSource bilhetesBindingSource;
        private CineGestDataSetTableAdapters.BilhetesTableAdapter bilhetesTableAdapter;
        private System.Windows.Forms.Label clientelbl;
        private CineGestDataSet cineGestDataSet1;
        private System.Windows.Forms.BindingSource pessoasClienteBindingSource;
        private CineGestDataSetTableAdapters.Pessoas_ClienteTableAdapter pessoas_ClienteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.BindingSource bilhetesBindingSource1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selecionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lugar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeSala;
        private System.Windows.Forms.Label sessoeslbl;
    }
}