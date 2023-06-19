namespace Cinegest.Forms
{
    partial class FormAgendamentoAutomatico
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
            this.salacb = new System.Windows.Forms.ComboBox();
            this.agenAutoIniciodtp = new System.Windows.Forms.DateTimePicker();
            this.cineGestDataSet = new Cinegest.CineGestDataSet();
            this.filmesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filmesTableAdapter = new Cinegest.CineGestDataSetTableAdapters.FilmesTableAdapter();
            this.filmescb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nomeDaSalalbl = new System.Windows.Forms.Label();
            this.espacoDeTempolbl = new System.Windows.Forms.Label();
            this.nrSessoesnud = new System.Windows.Forms.NumericUpDown();
            this.sessao1dtp = new System.Windows.Forms.DateTimePicker();
            this.sessao1lbl = new System.Windows.Forms.Label();
            this.sessao2lbl = new System.Windows.Forms.Label();
            this.sessao2dtp = new System.Windows.Forms.DateTimePicker();
            this.sessao3lbl = new System.Windows.Forms.Label();
            this.sessao3dtp = new System.Windows.Forms.DateTimePicker();
            this.sessao4lbl = new System.Windows.Forms.Label();
            this.sessao4dtp = new System.Windows.Forms.DateTimePicker();
            this.sessoeslbl = new System.Windows.Forms.Label();
            this.sessao5lbl = new System.Windows.Forms.Label();
            this.sessao5dtp = new System.Windows.Forms.DateTimePicker();
            this.agenAutoFimdtp = new System.Windows.Forms.DateTimePicker();
            this.dataIniciolbl = new System.Windows.Forms.Label();
            this.dataFimlbl = new System.Windows.Forms.Label();
            this.definirTempobtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.filmePrecotb = new System.Windows.Forms.TextBox();
            this.agendarbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cineGestDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrSessoesnud)).BeginInit();
            this.SuspendLayout();
            // 
            // salacb
            // 
            this.salacb.FormattingEnabled = true;
            this.salacb.Location = new System.Drawing.Point(167, 85);
            this.salacb.Name = "salacb";
            this.salacb.Size = new System.Drawing.Size(121, 21);
            this.salacb.TabIndex = 1;
            // 
            // agenAutoIniciodtp
            // 
            this.agenAutoIniciodtp.Location = new System.Drawing.Point(323, 86);
            this.agenAutoIniciodtp.Name = "agenAutoIniciodtp";
            this.agenAutoIniciodtp.Size = new System.Drawing.Size(128, 20);
            this.agenAutoIniciodtp.TabIndex = 2;
            // 
            // cineGestDataSet
            // 
            this.cineGestDataSet.DataSetName = "CineGestDataSet";
            this.cineGestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // filmesBindingSource
            // 
            this.filmesBindingSource.DataMember = "Filmes";
            this.filmesBindingSource.DataSource = this.cineGestDataSet;
            // 
            // filmesTableAdapter
            // 
            this.filmesTableAdapter.ClearBeforeFill = true;
            // 
            // filmescb
            // 
            this.filmescb.FormattingEnabled = true;
            this.filmescb.Location = new System.Drawing.Point(19, 86);
            this.filmescb.Name = "filmescb";
            this.filmescb.Size = new System.Drawing.Size(121, 21);
            this.filmescb.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome Do Filme";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nomeDaSalalbl
            // 
            this.nomeDaSalalbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeDaSalalbl.Location = new System.Drawing.Point(164, 38);
            this.nomeDaSalalbl.Name = "nomeDaSalalbl";
            this.nomeDaSalalbl.Size = new System.Drawing.Size(124, 23);
            this.nomeDaSalalbl.TabIndex = 5;
            this.nomeDaSalalbl.Text = "Nome Da Sala";
            this.nomeDaSalalbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // espacoDeTempolbl
            // 
            this.espacoDeTempolbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.espacoDeTempolbl.Location = new System.Drawing.Point(319, 32);
            this.espacoDeTempolbl.Name = "espacoDeTempolbl";
            this.espacoDeTempolbl.Size = new System.Drawing.Size(265, 23);
            this.espacoDeTempolbl.TabIndex = 6;
            this.espacoDeTempolbl.Text = " Espaço De Tempo";
            this.espacoDeTempolbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nrSessoesnud
            // 
            this.nrSessoesnud.Location = new System.Drawing.Point(729, 85);
            this.nrSessoesnud.Name = "nrSessoesnud";
            this.nrSessoesnud.Size = new System.Drawing.Size(120, 20);
            this.nrSessoesnud.TabIndex = 7;
            this.nrSessoesnud.ValueChanged += new System.EventHandler(this.NrSessoesnud_ValueChanged);
            // 
            // sessao1dtp
            // 
            this.sessao1dtp.Location = new System.Drawing.Point(18, 228);
            this.sessao1dtp.Name = "sessao1dtp";
            this.sessao1dtp.Size = new System.Drawing.Size(121, 20);
            this.sessao1dtp.TabIndex = 8;
            // 
            // sessao1lbl
            // 
            this.sessao1lbl.Location = new System.Drawing.Point(19, 202);
            this.sessao1lbl.Name = "sessao1lbl";
            this.sessao1lbl.Size = new System.Drawing.Size(121, 23);
            this.sessao1lbl.TabIndex = 9;
            this.sessao1lbl.Text = "1";
            this.sessao1lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // sessao2lbl
            // 
            this.sessao2lbl.Location = new System.Drawing.Point(161, 202);
            this.sessao2lbl.Name = "sessao2lbl";
            this.sessao2lbl.Size = new System.Drawing.Size(121, 23);
            this.sessao2lbl.TabIndex = 11;
            this.sessao2lbl.Text = "2";
            this.sessao2lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // sessao2dtp
            // 
            this.sessao2dtp.Location = new System.Drawing.Point(161, 228);
            this.sessao2dtp.Name = "sessao2dtp";
            this.sessao2dtp.Size = new System.Drawing.Size(121, 20);
            this.sessao2dtp.TabIndex = 10;
            // 
            // sessao3lbl
            // 
            this.sessao3lbl.Location = new System.Drawing.Point(288, 202);
            this.sessao3lbl.Name = "sessao3lbl";
            this.sessao3lbl.Size = new System.Drawing.Size(121, 23);
            this.sessao3lbl.TabIndex = 13;
            this.sessao3lbl.Text = "3";
            this.sessao3lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // sessao3dtp
            // 
            this.sessao3dtp.Location = new System.Drawing.Point(288, 228);
            this.sessao3dtp.Name = "sessao3dtp";
            this.sessao3dtp.Size = new System.Drawing.Size(121, 20);
            this.sessao3dtp.TabIndex = 12;
            // 
            // sessao4lbl
            // 
            this.sessao4lbl.Location = new System.Drawing.Point(415, 202);
            this.sessao4lbl.Name = "sessao4lbl";
            this.sessao4lbl.Size = new System.Drawing.Size(121, 23);
            this.sessao4lbl.TabIndex = 15;
            this.sessao4lbl.Text = "4";
            this.sessao4lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // sessao4dtp
            // 
            this.sessao4dtp.Location = new System.Drawing.Point(415, 228);
            this.sessao4dtp.Name = "sessao4dtp";
            this.sessao4dtp.Size = new System.Drawing.Size(121, 20);
            this.sessao4dtp.TabIndex = 14;
            // 
            // sessoeslbl
            // 
            this.sessoeslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sessoeslbl.Location = new System.Drawing.Point(18, 150);
            this.sessoeslbl.Name = "sessoeslbl";
            this.sessoeslbl.Size = new System.Drawing.Size(649, 23);
            this.sessoeslbl.TabIndex = 16;
            this.sessoeslbl.Text = "Sessões";
            this.sessoeslbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // sessao5lbl
            // 
            this.sessao5lbl.Location = new System.Drawing.Point(547, 202);
            this.sessao5lbl.Name = "sessao5lbl";
            this.sessao5lbl.Size = new System.Drawing.Size(121, 23);
            this.sessao5lbl.TabIndex = 18;
            this.sessao5lbl.Text = "5";
            this.sessao5lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // sessao5dtp
            // 
            this.sessao5dtp.Location = new System.Drawing.Point(547, 228);
            this.sessao5dtp.Name = "sessao5dtp";
            this.sessao5dtp.Size = new System.Drawing.Size(121, 20);
            this.sessao5dtp.TabIndex = 17;
            // 
            // agenAutoFimdtp
            // 
            this.agenAutoFimdtp.Location = new System.Drawing.Point(457, 86);
            this.agenAutoFimdtp.Name = "agenAutoFimdtp";
            this.agenAutoFimdtp.Size = new System.Drawing.Size(128, 20);
            this.agenAutoFimdtp.TabIndex = 19;
            // 
            // dataIniciolbl
            // 
            this.dataIniciolbl.Location = new System.Drawing.Point(323, 60);
            this.dataIniciolbl.Name = "dataIniciolbl";
            this.dataIniciolbl.Size = new System.Drawing.Size(128, 23);
            this.dataIniciolbl.TabIndex = 20;
            this.dataIniciolbl.Text = "Data Inicio";
            this.dataIniciolbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataFimlbl
            // 
            this.dataFimlbl.Location = new System.Drawing.Point(457, 60);
            this.dataFimlbl.Name = "dataFimlbl";
            this.dataFimlbl.Size = new System.Drawing.Size(128, 23);
            this.dataFimlbl.TabIndex = 21;
            this.dataFimlbl.Text = "Data Fim";
            this.dataFimlbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // definirTempobtn
            // 
            this.definirTempobtn.Location = new System.Drawing.Point(323, 113);
            this.definirTempobtn.Name = "definirTempobtn";
            this.definirTempobtn.Size = new System.Drawing.Size(262, 23);
            this.definirTempobtn.TabIndex = 22;
            this.definirTempobtn.Text = "Definir Espaço Tempo";
            this.definirTempobtn.UseVisualStyleBackColor = true;
            this.definirTempobtn.Click += new System.EventHandler(this.DefinirTempobtn_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(726, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 23);
            this.label2.TabIndex = 23;
            this.label2.Text = "Sessões";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(599, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 23);
            this.label3.TabIndex = 25;
            this.label3.Text = "Preço";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // filmePrecotb
            // 
            this.filmePrecotb.Location = new System.Drawing.Point(602, 84);
            this.filmePrecotb.Name = "filmePrecotb";
            this.filmePrecotb.Size = new System.Drawing.Size(121, 20);
            this.filmePrecotb.TabIndex = 26;
            // 
            // agendarbtn
            // 
            this.agendarbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agendarbtn.Location = new System.Drawing.Point(880, 12);
            this.agendarbtn.Name = "agendarbtn";
            this.agendarbtn.Size = new System.Drawing.Size(75, 426);
            this.agendarbtn.TabIndex = 28;
            this.agendarbtn.Text = "Agendar";
            this.agendarbtn.UseVisualStyleBackColor = true;
            this.agendarbtn.Click += new System.EventHandler(this.Agendarbtn_Click);
            // 
            // FormAgendamentoAutomatico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 450);
            this.Controls.Add(this.agendarbtn);
            this.Controls.Add(this.filmePrecotb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.definirTempobtn);
            this.Controls.Add(this.dataFimlbl);
            this.Controls.Add(this.dataIniciolbl);
            this.Controls.Add(this.agenAutoFimdtp);
            this.Controls.Add(this.sessao5lbl);
            this.Controls.Add(this.sessao5dtp);
            this.Controls.Add(this.sessoeslbl);
            this.Controls.Add(this.sessao4lbl);
            this.Controls.Add(this.sessao4dtp);
            this.Controls.Add(this.sessao3lbl);
            this.Controls.Add(this.sessao3dtp);
            this.Controls.Add(this.sessao2lbl);
            this.Controls.Add(this.sessao2dtp);
            this.Controls.Add(this.sessao1lbl);
            this.Controls.Add(this.sessao1dtp);
            this.Controls.Add(this.nrSessoesnud);
            this.Controls.Add(this.espacoDeTempolbl);
            this.Controls.Add(this.nomeDaSalalbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filmescb);
            this.Controls.Add(this.agenAutoIniciodtp);
            this.Controls.Add(this.salacb);
            this.MinimumSize = new System.Drawing.Size(996, 489);
            this.Name = "FormAgendamentoAutomatico";
            this.Text = "FormAgendamentoAutomatico";
            this.Load += new System.EventHandler(this.FormAgendamentoAutomatico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cineGestDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrSessoesnud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox salacb;
        private System.Windows.Forms.DateTimePicker agenAutoIniciodtp;
        private CineGestDataSet cineGestDataSet;
        private System.Windows.Forms.BindingSource filmesBindingSource;
        private CineGestDataSetTableAdapters.FilmesTableAdapter filmesTableAdapter;
        private System.Windows.Forms.ComboBox filmescb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nomeDaSalalbl;
        private System.Windows.Forms.Label espacoDeTempolbl;
        private System.Windows.Forms.NumericUpDown nrSessoesnud;
        private System.Windows.Forms.DateTimePicker sessao1dtp;
        private System.Windows.Forms.Label sessao1lbl;
        private System.Windows.Forms.Label sessao2lbl;
        private System.Windows.Forms.DateTimePicker sessao2dtp;
        private System.Windows.Forms.Label sessao3lbl;
        private System.Windows.Forms.DateTimePicker sessao3dtp;
        private System.Windows.Forms.Label sessao4lbl;
        private System.Windows.Forms.DateTimePicker sessao4dtp;
        private System.Windows.Forms.Label sessoeslbl;
        private System.Windows.Forms.Label sessao5lbl;
        private System.Windows.Forms.DateTimePicker sessao5dtp;
        private System.Windows.Forms.DateTimePicker agenAutoFimdtp;
        private System.Windows.Forms.Label dataIniciolbl;
        private System.Windows.Forms.Label dataFimlbl;
        private System.Windows.Forms.Button definirTempobtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox filmePrecotb;
        private System.Windows.Forms.Button agendarbtn;
    }
}