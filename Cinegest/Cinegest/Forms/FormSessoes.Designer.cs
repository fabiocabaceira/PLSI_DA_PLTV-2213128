namespace Cinegest.Forms
{
    partial class FormSessoes
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
            this.criarSessaobtn = new System.Windows.Forms.Button();
            this.salascb = new System.Windows.Forms.ComboBox();
            this.filmescb = new System.Windows.Forms.ComboBox();
            this.sessaolbl = new System.Windows.Forms.Label();
            this.salalb = new System.Windows.Forms.Label();
            this.filmelbl = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.datahoralbl = new System.Windows.Forms.Label();
            this.precotb = new System.Windows.Forms.TextBox();
            this.precolbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // criarSessaobtn
            // 
            this.criarSessaobtn.Location = new System.Drawing.Point(568, 12);
            this.criarSessaobtn.Name = "criarSessaobtn";
            this.criarSessaobtn.Size = new System.Drawing.Size(119, 470);
            this.criarSessaobtn.TabIndex = 0;
            this.criarSessaobtn.Text = "Criar Sessão";
            this.criarSessaobtn.UseVisualStyleBackColor = true;
            this.criarSessaobtn.Click += new System.EventHandler(this.criarSessaobtn_Click);
            // 
            // salascb
            // 
            this.salascb.FormattingEnabled = true;
            this.salascb.Location = new System.Drawing.Point(16, 60);
            this.salascb.Name = "salascb";
            this.salascb.Size = new System.Drawing.Size(90, 21);
            this.salascb.TabIndex = 1;
            // 
            // filmescb
            // 
            this.filmescb.FormattingEnabled = true;
            this.filmescb.Location = new System.Drawing.Point(112, 60);
            this.filmescb.Name = "filmescb";
            this.filmescb.Size = new System.Drawing.Size(85, 21);
            this.filmescb.TabIndex = 2;
            // 
            // sessaolbl
            // 
            this.sessaolbl.Location = new System.Drawing.Point(13, 12);
            this.sessaolbl.Name = "sessaolbl";
            this.sessaolbl.Size = new System.Drawing.Size(339, 18);
            this.sessaolbl.TabIndex = 3;
            this.sessaolbl.Text = "Criar Nova Sessão";
            this.sessaolbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // salalb
            // 
            this.salalb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.salalb.Location = new System.Drawing.Point(16, 39);
            this.salalb.Name = "salalb";
            this.salalb.Size = new System.Drawing.Size(90, 18);
            this.salalb.TabIndex = 4;
            this.salalb.Text = "Sala";
            this.salalb.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // filmelbl
            // 
            this.filmelbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.filmelbl.Location = new System.Drawing.Point(112, 39);
            this.filmelbl.Name = "filmelbl";
            this.filmelbl.Size = new System.Drawing.Size(85, 18);
            this.filmelbl.TabIndex = 5;
            this.filmelbl.Text = "Filme";
            this.filmelbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(294, 60);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(257, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // datahoralbl
            // 
            this.datahoralbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.datahoralbl.Location = new System.Drawing.Point(294, 40);
            this.datahoralbl.Name = "datahoralbl";
            this.datahoralbl.Size = new System.Drawing.Size(257, 17);
            this.datahoralbl.TabIndex = 7;
            this.datahoralbl.Text = "DataHora";
            this.datahoralbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // precotb
            // 
            this.precotb.Location = new System.Drawing.Point(203, 60);
            this.precotb.Name = "precotb";
            this.precotb.Size = new System.Drawing.Size(85, 20);
            this.precotb.TabIndex = 8;
            // 
            // precolbl
            // 
            this.precolbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.precolbl.Location = new System.Drawing.Point(203, 39);
            this.precolbl.Name = "precolbl";
            this.precolbl.Size = new System.Drawing.Size(85, 18);
            this.precolbl.TabIndex = 9;
            this.precolbl.Text = "Preco";
            this.precolbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormSessoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 494);
            this.Controls.Add(this.precolbl);
            this.Controls.Add(this.precotb);
            this.Controls.Add(this.datahoralbl);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.filmelbl);
            this.Controls.Add(this.salalb);
            this.Controls.Add(this.sessaolbl);
            this.Controls.Add(this.filmescb);
            this.Controls.Add(this.salascb);
            this.Controls.Add(this.criarSessaobtn);
            this.Name = "FormSessoes";
            this.Text = "FormSessoes";
            this.Load += new System.EventHandler(this.FormSessoes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button criarSessaobtn;
        private System.Windows.Forms.ComboBox salascb;
        private System.Windows.Forms.ComboBox filmescb;
        private System.Windows.Forms.Label sessaolbl;
        private System.Windows.Forms.Label salalb;
        private System.Windows.Forms.Label filmelbl;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label datahoralbl;
        private System.Windows.Forms.TextBox precotb;
        private System.Windows.Forms.Label precolbl;
    }
}