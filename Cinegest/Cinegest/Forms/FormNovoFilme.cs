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
    public partial class FormNovoFilme : Form
    {
        CineGestEntities5 cinegest;
        public FormNovoFilme()
        {
            cinegest = new CineGestEntities5();
            InitializeComponent();
        }

        private void FormNovoFilme_Load(object sender, EventArgs e)
        {
            var categorias = cinegest.Categorias.ToList();

            categoriaFilmescb.DataSource = categorias;
            categoriaFilmescb.DisplayMember = "Nome";

        }

        private void adicionarbtn_Click(object sender, EventArgs e)
        {
            string nomeFilme = nomeFilmetb.Text;
            string duracaoFilme = duracaoFilmetb.Text;
            string Activo = activoFilmetb.Text;
            string categoria_nome = categoriaFilmescb.Text.ToString();

            Categoria categoria = cinegest.Categorias.ToList().FirstOrDefault(c => c.Nome == categoria_nome);
            Filme novoFilme = new Filme(nomeFilme, duracaoFilme, Activo, categoria);
            cinegest.Filmes.Add(novoFilme);
            cinegest.SaveChanges();


        }
    }
}
