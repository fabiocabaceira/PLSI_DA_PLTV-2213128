using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinegest.Forms
{
    public partial class FormFilmes : Form
    {

        CineGestEntities5 cinegest;
        string filmeNome;
        public FormFilmes()
        {
            InitializeComponent();
            cinegest = new CineGestEntities5();
        }

        private void FormFilmes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cineGestDataSet.Filmes' table. You can move, or remove it, as needed.
            this.filmesTableAdapter.Fill(this.cineGestDataSet.Filmes);

        }

        private void filmesdgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            filmeNome = filmesdgv.Rows[e.RowIndex].Cells["Nome"].Value.ToString();

            var filme = cinegest.Filmes.OfType<Filme>().FirstOrDefault(f => f.Nome == filmeNome);

            if (filme != null)
            {
                nomeFilmetb.Text = filme.Nome;
                duracaoFilmetb.Text = filme.Duracao;
                activoFilmetb.Text = filme.Activo;
                var categorias = cinegest.Categorias.ToList();

                categoriaFilmecb.DataSource = categorias;
                categoriaFilmecb.DisplayMember = "Nome";
                categoriaFilmecb.Text = filme.Categoria.Nome;

            }

        }


        
        private void alterarFilmebtn_Click(object sender, EventArgs e)
        {

            string nomeFilme = nomeFilmetb.Text;
            string duracaoFilme = duracaoFilmetb.Text;
            string Activo = activoFilmetb.Text;
            Filme filme = cinegest.Filmes.FirstOrDefault(f => f.Nome == filmeNome);
            string categoria_nome = categoriaFilmecb.Text;

            Categoria categoria = cinegest.Categorias.ToList().FirstOrDefault(c => c.Nome == categoria_nome);

            filme.Nome = nomeFilme;
            filme.Duracao = duracaoFilme;
            filme.Activo = Activo;
            filme.Categoria = categoria;
            cinegest.SaveChanges();

        }

        private void novoFilmebtn_Click(object sender, EventArgs e)
        {
            FormNovoFilme fmFilme = new FormNovoFilme();
            fmFilme.ShowDialog();
        }

        private void apagarFilmebtn_Click(object sender, EventArgs e)
        {
            Filme filme = cinegest.Filmes.FirstOrDefault(f => f.Nome == filmeNome);
            cinegest.Filmes.Remove(filme);
            cinegest.SaveChanges();

        }
    }
}