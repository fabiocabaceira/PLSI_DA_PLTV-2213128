using Cinegest.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinegest.Forms
{
    public partial class FormAtendimento : Form
    {
        public string idSessao;
        CineGestEntities db;

        public FormAtendimento(string idSessao)
        {
            this.idSessao = idSessao;

            db = new CineGestEntities();
            InitializeComponent();

        }

        private void FormAtendimento_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cineGestDataSet.Bilhetes' table. You can move, or remove it, as needed.
            this.bilhetesTableAdapter.Fill(this.cineGestDataSet.Bilhetes);

            Console.WriteLine(idSessao);
            int s1 = int.Parse(idSessao);
            var bilhetes = db.Bilhetes.Where(b => b.SessãoIdSessao == s1).ToList();

            bilhetesBindingSource.DataSource = bilhetes;

            dataGridView1.DataSource = bilhetesBindingSource;
        }
    }
}
