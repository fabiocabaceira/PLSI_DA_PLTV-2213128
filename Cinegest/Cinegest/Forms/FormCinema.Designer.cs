namespace Cinegest.Forms
{
    partial class FormCinema
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
            this.headerlbl = new System.Windows.Forms.Label();
            this.cinemaNometb = new System.Windows.Forms.TextBox();
            this.cinemaMoradatb = new System.Windows.Forms.TextBox();
            this.cinemaEmailtb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.criarCinemabtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.salarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pessoasFuncionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cineGestDataSet = new Cinegest.CineGestDataSet();
            this.pessoas_FuncionarioTableAdapter = new Cinegest.CineGestDataSetTableAdapters.Pessoas_FuncionarioTableAdapter();
            this.funcionarioMoradatb = new System.Windows.Forms.TextBox();
            this.funcionarioNometb = new System.Windows.Forms.TextBox();
            this.funcionarioFuncaotb = new System.Windows.Forms.TextBox();
            this.funcionarioSalariotb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.apagarFuncionario = new System.Windows.Forms.Label();
            this.criarNovoFuncionariolbl = new System.Windows.Forms.Label();
            this.novoFuncionariotb = new System.Windows.Forms.Button();
            this.apagarFuncionariobtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasFuncionarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cineGestDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // headerlbl
            // 
            this.headerlbl.Location = new System.Drawing.Point(5, 9);
            this.headerlbl.Name = "headerlbl";
            this.headerlbl.Size = new System.Drawing.Size(457, 23);
            this.headerlbl.TabIndex = 0;
            this.headerlbl.Text = "Configurar Cinema";
            this.headerlbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cinemaNometb
            // 
            this.cinemaNometb.Location = new System.Drawing.Point(8, 91);
            this.cinemaNometb.Name = "cinemaNometb";
            this.cinemaNometb.Size = new System.Drawing.Size(457, 20);
            this.cinemaNometb.TabIndex = 1;
            // 
            // cinemaMoradatb
            // 
            this.cinemaMoradatb.Location = new System.Drawing.Point(5, 140);
            this.cinemaMoradatb.Name = "cinemaMoradatb";
            this.cinemaMoradatb.Size = new System.Drawing.Size(460, 20);
            this.cinemaMoradatb.TabIndex = 2;
            // 
            // cinemaEmailtb
            // 
            this.cinemaEmailtb.Location = new System.Drawing.Point(5, 189);
            this.cinemaEmailtb.Name = "cinemaEmailtb";
            this.cinemaEmailtb.Size = new System.Drawing.Size(460, 20);
            this.cinemaEmailtb.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(454, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(11, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(454, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Morada";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(11, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(454, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // criarCinemabtn
            // 
            this.criarCinemabtn.Location = new System.Drawing.Point(5, 226);
            this.criarCinemabtn.Name = "criarCinemabtn";
            this.criarCinemabtn.Size = new System.Drawing.Size(460, 23);
            this.criarCinemabtn.TabIndex = 7;
            this.criarCinemabtn.Text = "Criar Cinema";
            this.criarCinemabtn.UseVisualStyleBackColor = true;
            this.criarCinemabtn.Click += new System.EventHandler(this.criarCinemabtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.salarioDataGridViewTextBoxColumn,
            this.funcaoDataGridViewTextBoxColumn,
            this.Nome,
            this.moradaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pessoasFuncionarioBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(484, 8);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(430, 241);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // salarioDataGridViewTextBoxColumn
            // 
            this.salarioDataGridViewTextBoxColumn.DataPropertyName = "Salario";
            this.salarioDataGridViewTextBoxColumn.HeaderText = "Salario";
            this.salarioDataGridViewTextBoxColumn.Name = "salarioDataGridViewTextBoxColumn";
            // 
            // funcaoDataGridViewTextBoxColumn
            // 
            this.funcaoDataGridViewTextBoxColumn.DataPropertyName = "Funcao";
            this.funcaoDataGridViewTextBoxColumn.HeaderText = "Funcao";
            this.funcaoDataGridViewTextBoxColumn.Name = "funcaoDataGridViewTextBoxColumn";
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // moradaDataGridViewTextBoxColumn
            // 
            this.moradaDataGridViewTextBoxColumn.DataPropertyName = "Morada";
            this.moradaDataGridViewTextBoxColumn.HeaderText = "Morada";
            this.moradaDataGridViewTextBoxColumn.Name = "moradaDataGridViewTextBoxColumn";
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
            // pessoas_FuncionarioTableAdapter
            // 
            this.pessoas_FuncionarioTableAdapter.ClearBeforeFill = true;
            // 
            // funcionarioMoradatb
            // 
            this.funcionarioMoradatb.Location = new System.Drawing.Point(938, 134);
            this.funcionarioMoradatb.Name = "funcionarioMoradatb";
            this.funcionarioMoradatb.Size = new System.Drawing.Size(260, 20);
            this.funcionarioMoradatb.TabIndex = 9;
            // 
            // funcionarioNometb
            // 
            this.funcionarioNometb.Location = new System.Drawing.Point(938, 85);
            this.funcionarioNometb.Name = "funcionarioNometb";
            this.funcionarioNometb.Size = new System.Drawing.Size(260, 20);
            this.funcionarioNometb.TabIndex = 10;
            // 
            // funcionarioFuncaotb
            // 
            this.funcionarioFuncaotb.Location = new System.Drawing.Point(937, 180);
            this.funcionarioFuncaotb.Name = "funcionarioFuncaotb";
            this.funcionarioFuncaotb.Size = new System.Drawing.Size(260, 20);
            this.funcionarioFuncaotb.TabIndex = 11;
            // 
            // funcionarioSalariotb
            // 
            this.funcionarioSalariotb.Location = new System.Drawing.Point(937, 229);
            this.funcionarioSalariotb.Name = "funcionarioSalariotb";
            this.funcionarioSalariotb.Size = new System.Drawing.Size(260, 20);
            this.funcionarioSalariotb.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(938, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nome";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(938, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(260, 23);
            this.label5.TabIndex = 14;
            this.label5.Text = "Morada";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(937, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(261, 23);
            this.label6.TabIndex = 15;
            this.label6.Text = "Funcao";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(935, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(263, 23);
            this.label7.TabIndex = 16;
            this.label7.Text = "Salario";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(938, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(260, 23);
            this.label8.TabIndex = 17;
            this.label8.Text = "Guardar Informações Do Funcionario";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // apagarFuncionario
            // 
            this.apagarFuncionario.Location = new System.Drawing.Point(484, 369);
            this.apagarFuncionario.Name = "apagarFuncionario";
            this.apagarFuncionario.Size = new System.Drawing.Size(433, 23);
            this.apagarFuncionario.TabIndex = 21;
            this.apagarFuncionario.Text = "Apagar Um Funcionario";
            this.apagarFuncionario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // criarNovoFuncionariolbl
            // 
            this.criarNovoFuncionariolbl.Location = new System.Drawing.Point(484, 270);
            this.criarNovoFuncionariolbl.Name = "criarNovoFuncionariolbl";
            this.criarNovoFuncionariolbl.Size = new System.Drawing.Size(430, 23);
            this.criarNovoFuncionariolbl.TabIndex = 20;
            this.criarNovoFuncionariolbl.Text = "Criar Um Novo Funcionario";
            this.criarNovoFuncionariolbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // novoFuncionariotb
            // 
            this.novoFuncionariotb.Location = new System.Drawing.Point(487, 296);
            this.novoFuncionariotb.Name = "novoFuncionariotb";
            this.novoFuncionariotb.Size = new System.Drawing.Size(430, 70);
            this.novoFuncionariotb.TabIndex = 19;
            this.novoFuncionariotb.Text = "Criar Funcionario";
            this.novoFuncionariotb.UseVisualStyleBackColor = true;
            this.novoFuncionariotb.Click += new System.EventHandler(this.novoFuncionariotb_Click);
            // 
            // apagarFuncionariobtn
            // 
            this.apagarFuncionariobtn.Location = new System.Drawing.Point(484, 395);
            this.apagarFuncionariobtn.Name = "apagarFuncionariobtn";
            this.apagarFuncionariobtn.Size = new System.Drawing.Size(433, 70);
            this.apagarFuncionariobtn.TabIndex = 18;
            this.apagarFuncionariobtn.Text = "Apagar ";
            this.apagarFuncionariobtn.UseVisualStyleBackColor = true;
            this.apagarFuncionariobtn.Click += new System.EventHandler(this.apagarFuncionariobtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1204, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 241);
            this.button1.TabIndex = 22;
            this.button1.Text = "Guardar Alterações";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormCinema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 611);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.apagarFuncionario);
            this.Controls.Add(this.criarNovoFuncionariolbl);
            this.Controls.Add(this.novoFuncionariotb);
            this.Controls.Add(this.apagarFuncionariobtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.funcionarioSalariotb);
            this.Controls.Add(this.funcionarioFuncaotb);
            this.Controls.Add(this.funcionarioNometb);
            this.Controls.Add(this.funcionarioMoradatb);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.criarCinemabtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cinemaEmailtb);
            this.Controls.Add(this.cinemaMoradatb);
            this.Controls.Add(this.cinemaNometb);
            this.Controls.Add(this.headerlbl);
            this.Name = "FormCinema";
            this.Text = "FormCinema";
            this.Load += new System.EventHandler(this.FormCinema_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasFuncionarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cineGestDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerlbl;
        private System.Windows.Forms.TextBox cinemaNometb;
        private System.Windows.Forms.TextBox cinemaMoradatb;
        private System.Windows.Forms.TextBox cinemaEmailtb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button criarCinemabtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CineGestDataSet cineGestDataSet;
        private System.Windows.Forms.BindingSource pessoasFuncionarioBindingSource;
        private CineGestDataSetTableAdapters.Pessoas_FuncionarioTableAdapter pessoas_FuncionarioTableAdapter;
        private System.Windows.Forms.TextBox funcionarioMoradatb;
        private System.Windows.Forms.TextBox funcionarioNometb;
        private System.Windows.Forms.TextBox funcionarioFuncaotb;
        private System.Windows.Forms.TextBox funcionarioSalariotb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label apagarFuncionario;
        private System.Windows.Forms.Label criarNovoFuncionariolbl;
        private System.Windows.Forms.Button novoFuncionariotb;
        private System.Windows.Forms.Button apagarFuncionariobtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn salarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn moradaDataGridViewTextBoxColumn;
    }
}