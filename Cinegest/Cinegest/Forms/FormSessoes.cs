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
    public partial class FormSessoes : Form
    {
        CineGestEntities5 cinegest;
        public FormSessoes()
        {
            cinegest = new CineGestEntities5();
            InitializeComponent();
        }

        private void FormSessoes_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            var salas = cinegest.Salas.ToList();
            var filmes = cinegest.Filmes.ToList();

            salascb.DataSource = salas;
            salascb.DisplayMember = "Nome";

            filmescb.DataSource = filmes;
            filmescb.DisplayMember = "Nome";
        }

        private void criarSessaobtn_Click(object sender, EventArgs e)
        {
            string nomeFilme = filmescb.Text.ToString();
            string nomeSala = salascb.Text.ToString();
            System.DateTime Datahora = DateTime.Parse(dateTimePicker1.Value.ToString());
            int preco = int.Parse(precotb.Text);
            Sala sala = cinegest.Salas.ToList().FirstOrDefault(c => c.Nome == nomeSala);
            int salaId = sala.Id;
            Filme filme = cinegest.Filmes.ToList().FirstOrDefault(c => c.Nome == nomeFilme);
            int filmeId = filme.Id;
            Sessao novaSessao = new Sessao(salaId, Datahora, preco, filmeId);
            cinegest.Sessaos.Add(novaSessao);
            cinegest.SaveChanges();

        }
    }
}