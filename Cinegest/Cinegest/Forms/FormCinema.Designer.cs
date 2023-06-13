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
            this.pessoasFuncionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cineGestDataSet = new Cinegest.CineGestDataSet();
            this.funcionarioMoradatb = new System.Windows.Forms.TextBox();
            this.funcionarioNometb = new System.Windows.Forms.TextBox();
            this.funcionarioFuncaotb = new System.Windows.Forms.TextBox();
            this.funcionarioSalariotb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.novoFuncionariotb = new System.Windows.Forms.Button();
            this.apagarFuncionariobtn = new System.Windows.Forms.Button();
            this.guardarAlteracoesFuncionariobtn = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.salanome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colunas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Filas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pessoas_FuncionarioTableAdapter = new Cinegest.CineGestDataSetTableAdapters.Pessoas_FuncionarioTableAdapter();
            this.salasTableAdapter = new Cinegest.CineGestDataSetTableAdapters.SalasTableAdapter();
            this.filaslbl = new System.Windows.Forms.Label();
            this.colunaslbl = new System.Windows.Forms.Label();
            this.nomelbl = new System.Windows.Forms.Label();
            this.salaFilastb = new System.Windows.Forms.TextBox();
            this.salaNometb = new System.Windows.Forms.TextBox();
            this.salaColunastb = new System.Windows.Forms.TextBox();
            this.criarSalabtn = new System.Windows.Forms.Button();
            this.apagarSalabtn = new System.Windows.Forms.Button();
            this.salarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nomefunc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guardarSalabtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasFuncionarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cineGestDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salasBindingSource)).BeginInit();
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
            this.criarCinemabtn.Size = new System.Drawing.Size(460, 227);
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
            this.Nomefunc,
            this.moradaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pessoasFuncionarioBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(484, 8);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(430, 241);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // funcionarioMoradatb
            // 
            this.funcionarioMoradatb.Location = new System.Drawing.Point(938, 134);
            this.funcionarioMoradatb.Name = "funcionarioMoradatb";
            this.funcionarioMoradatb.Size = new System.Drawing.Size(260, 20);
            this.funcionarioMoradatb.TabIndex = 9;
            // 
            // funcionarioNometb
            // 
            this.funcionarioNometb.Location = new System.Drawing.Point(937, 85);
            this.funcionarioNometb.Name = "funcionarioNometb";
            this.funcionarioNometb.Size = new System.Drawing.Size(261, 20);
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
            this.label1.Text = "Nome Do Funcionario";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(938, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(260, 23);
            this.label5.TabIndex = 14;
            this.label5.Text = "Morada  Do Funcionario";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(937, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(261, 23);
            this.label6.TabIndex = 15;
            this.label6.Text = "Funcao  Do Funcionario";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(935, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(263, 23);
            this.label7.TabIndex = 16;
            this.label7.Text = "Salario  Do Funcionario";
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
            // novoFuncionariotb
            // 
            this.novoFuncionariotb.Location = new System.Drawing.Point(1205, 114);
            this.novoFuncionariotb.Name = "novoFuncionariotb";
            this.novoFuncionariotb.Size = new System.Drawing.Size(104, 66);
            this.novoFuncionariotb.TabIndex = 19;
            this.novoFuncionariotb.Text = "Criar Funcionario";
            this.novoFuncionariotb.UseVisualStyleBackColor = true;
            this.novoFuncionariotb.Click += new System.EventHandler(this.novoFuncionariotb_Click);
            // 
            // apagarFuncionariobtn
            // 
            this.apagarFuncionariobtn.Location = new System.Drawing.Point(1205, 183);
            this.apagarFuncionariobtn.Name = "apagarFuncionariobtn";
            this.apagarFuncionariobtn.Size = new System.Drawing.Size(104, 66);
            this.apagarFuncionariobtn.TabIndex = 18;
            this.apagarFuncionariobtn.Text = "Apagar Funcionario";
            this.apagarFuncionariobtn.UseVisualStyleBackColor = true;
            this.apagarFuncionariobtn.Click += new System.EventHandler(this.apagarFuncionariobtn_Click);
            // 
            // guardarAlteracoesFuncionariobtn
            // 
            this.guardarAlteracoesFuncionariobtn.Location = new System.Drawing.Point(1204, 45);
            this.guardarAlteracoesFuncionariobtn.Name = "guardarAlteracoesFuncionariobtn";
            this.guardarAlteracoesFuncionariobtn.Size = new System.Drawing.Size(104, 66);
            this.guardarAlteracoesFuncionariobtn.TabIndex = 22;
            this.guardarAlteracoesFuncionariobtn.Text = "Guardar Alterações No Funcionario";
            this.guardarAlteracoesFuncionariobtn.UseVisualStyleBackColor = true;
            this.guardarAlteracoesFuncionariobtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.salanome,
            this.Colunas,
            this.Filas});
            this.dataGridView2.DataSource = this.salasBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(484, 260);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(430, 193);
            this.dataGridView2.TabIndex = 23;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // salanome
            // 
            this.salanome.DataPropertyName = "Nome";
            this.salanome.HeaderText = "Nome";
            this.salanome.Name = "salanome";
            // 
            // Colunas
            // 
            this.Colunas.DataPropertyName = "Colunas";
            this.Colunas.HeaderText = "Colunas";
            this.Colunas.Name = "Colunas";
            // 
            // Filas
            // 
            this.Filas.DataPropertyName = "Filas";
            this.Filas.HeaderText = "Filas";
            this.Filas.Name = "Filas";
            // 
            // salasBindingSource
            // 
            this.salasBindingSource.DataMember = "Salas";
            this.salasBindingSource.DataSource = this.cineGestDataSet;
            // 
            // pessoas_FuncionarioTableAdapter
            // 
            this.pessoas_FuncionarioTableAdapter.ClearBeforeFill = true;
            // 
            // salasTableAdapter
            // 
            this.salasTableAdapter.ClearBeforeFill = true;
            // 
            // filaslbl
            // 
            this.filaslbl.Location = new System.Drawing.Point(937, 358);
            this.filaslbl.Name = "filaslbl";
            this.filaslbl.Size = new System.Drawing.Size(261, 23);
            this.filaslbl.TabIndex = 29;
            this.filaslbl.Text = "Filas Da Sala";
            this.filaslbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // colunaslbl
            // 
            this.colunaslbl.Location = new System.Drawing.Point(938, 309);
            this.colunaslbl.Name = "colunaslbl";
            this.colunaslbl.Size = new System.Drawing.Size(260, 23);
            this.colunaslbl.TabIndex = 28;
            this.colunaslbl.Text = "Colunas Da Sala";
            this.colunaslbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nomelbl
            // 
            this.nomelbl.Location = new System.Drawing.Point(938, 260);
            this.nomelbl.Name = "nomelbl";
            this.nomelbl.Size = new System.Drawing.Size(260, 23);
            this.nomelbl.TabIndex = 27;
            this.nomelbl.Text = "Nome Da Sala";
            this.nomelbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // salaFilastb
            // 
            this.salaFilastb.Location = new System.Drawing.Point(937, 381);
            this.salaFilastb.Name = "salaFilastb";
            this.salaFilastb.Size = new System.Drawing.Size(260, 20);
            this.salaFilastb.TabIndex = 26;
            // 
            // salaNometb
            // 
            this.salaNometb.Location = new System.Drawing.Point(937, 286);
            this.salaNometb.Name = "salaNometb";
            this.salaNometb.Size = new System.Drawing.Size(261, 20);
            this.salaNometb.TabIndex = 25;
            // 
            // salaColunastb
            // 
            this.salaColunastb.Location = new System.Drawing.Point(938, 335);
            this.salaColunastb.Name = "salaColunastb";
            this.salaColunastb.Size = new System.Drawing.Size(260, 20);
            this.salaColunastb.TabIndex = 24;
            // 
            // criarSalabtn
            // 
            this.criarSalabtn.Location = new System.Drawing.Point(1204, 262);
            this.criarSalabtn.Name = "criarSalabtn";
            this.criarSalabtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.criarSalabtn.Size = new System.Drawing.Size(104, 70);
            this.criarSalabtn.TabIndex = 30;
            this.criarSalabtn.Text = "Criar Sala";
            this.criarSalabtn.UseVisualStyleBackColor = true;
            this.criarSalabtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // apagarSalabtn
            // 
            this.apagarSalabtn.Location = new System.Drawing.Point(1205, 340);
            this.apagarSalabtn.Name = "apagarSalabtn";
            this.apagarSalabtn.Size = new System.Drawing.Size(103, 70);
            this.apagarSalabtn.TabIndex = 31;
            this.apagarSalabtn.Text = "Apagar Sala";
            this.apagarSalabtn.UseVisualStyleBackColor = true;
            this.apagarSalabtn.Click += new System.EventHandler(this.apagarSalabtn_Click);
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
            // Nomefunc
            // 
            this.Nomefunc.DataPropertyName = "Nome";
            this.Nomefunc.HeaderText = "Nome";
            this.Nomefunc.Name = "Nomefunc";
            // 
            // moradaDataGridViewTextBoxColumn
            // 
            this.moradaDataGridViewTextBoxColumn.DataPropertyName = "Morada";
            this.moradaDataGridViewTextBoxColumn.HeaderText = "Morada";
            this.moradaDataGridViewTextBoxColumn.Name = "moradaDataGridViewTextBoxColumn";
            // 
            // guardarSalabtn
            // 
            this.guardarSalabtn.Location = new System.Drawing.Point(937, 416);
            this.guardarSalabtn.Name = "guardarSalabtn";
            this.guardarSalabtn.Size = new System.Drawing.Size(371, 37);
            this.guardarSalabtn.TabIndex = 32;
            this.guardarSalabtn.Text = "Guardar Alterações Na Sala";
            this.guardarSalabtn.UseVisualStyleBackColor = true;
            this.guardarSalabtn.Click += new System.EventHandler(this.guardarSalabtn_Click);
            // 
            // FormCinema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 494);
            this.Controls.Add(this.guardarSalabtn);
            this.Controls.Add(this.apagarSalabtn);
            this.Controls.Add(this.criarSalabtn);
            this.Controls.Add(this.filaslbl);
            this.Controls.Add(this.colunaslbl);
            this.Controls.Add(this.nomelbl);
            this.Controls.Add(this.salaFilastb);
            this.Controls.Add(this.salaNometb);
            this.Controls.Add(this.salaColunastb);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.guardarAlteracoesFuncionariobtn);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salasBindingSource)).EndInit();
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
        private System.Windows.Forms.Button novoFuncionariotb;
        private System.Windows.Forms.Button apagarFuncionariobtn;
        private System.Windows.Forms.Button guardarAlteracoesFuncionariobtn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource salasBindingSource;
        private CineGestDataSetTableAdapters.SalasTableAdapter salasTableAdapter;
        private System.Windows.Forms.Label filaslbl;
        private System.Windows.Forms.Label colunaslbl;
        private System.Windows.Forms.Label nomelbl;
        private System.Windows.Forms.TextBox salaFilastb;
        private System.Windows.Forms.TextBox salaNometb;
        private System.Windows.Forms.TextBox salaColunastb;
        private System.Windows.Forms.Button criarSalabtn;
        private System.Windows.Forms.Button apagarSalabtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salanome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colunas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Filas;
        private System.Windows.Forms.DataGridViewTextBoxColumn salarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nomefunc;
        private System.Windows.Forms.DataGridViewTextBoxColumn moradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button guardarSalabtn;
    }
}