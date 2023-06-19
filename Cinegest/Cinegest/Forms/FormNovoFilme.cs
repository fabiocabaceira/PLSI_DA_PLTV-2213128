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
            try
            {
                string nomeFilme = nomeFilmetb.Text;
                string duracaoFilme = duracaoFilmetb.Text;
                string categoria_nome = categoriaFilmescb.Text.ToString();

                if (string.IsNullOrEmpty(nomeFilme) || string.IsNullOrEmpty(duracaoFilme) || string.IsNullOrEmpty(categoria_nome))
                {
                    MessageBox.Show("Por favor, preencha todos os campos.");
                    return;
                }

                if (!duracaoFilme.All(char.IsDigit))
                {
                    MessageBox.Show("A duração deve ser um número.");
                    return;
                }

                Categoria categoria = cinegest.Categorias.ToList().FirstOrDefault(c => c.Nome == categoria_nome);
                if (categoria == null)
                {
                    MessageBox.Show("A categoria selecionada não existe.");
                    return;
                }

                Filme novoFilme = new Filme(nomeFilme, duracaoFilme, "Desactivado", categoria);
                cinegest.Filmes.Add(novoFilme);
                cinegest.SaveChanges();

                MessageBox.Show("Filme adicionado com sucesso!");
            }

            catch (Exception ex )
            {

                MessageBox.Show(ex.Message);
            }
        }

        


    }
}
