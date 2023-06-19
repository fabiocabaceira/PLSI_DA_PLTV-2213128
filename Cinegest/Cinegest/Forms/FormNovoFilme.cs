using System;
using System.Linq;
using System.Windows.Forms;

namespace Cinegest.Forms
{
    public partial class FormNovoFilme : Form
    {
        CineGestEntities5 cinegest;

        /// <summary>
        /// Construtor da classe
        /// </summary>
        public FormNovoFilme()
        {
            cinegest = new CineGestEntities5();
            InitializeComponent();
        }

        /// <summary>
        /// Método que carrega as categorias para o formulário
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormNovoFilme_Load(object sender, EventArgs e)
        {
            var categorias = cinegest.Categorias.ToList();

            categoriaFilmescb.DataSource = categorias;
            categoriaFilmescb.DisplayMember = "Nome";

        }

        /// <summary>
        /// Evento que permite adicionar um novo filme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Adicionarbtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Obter os dados do formulário
                string nomeFilme = nomeFilmetb.Text;
                string duracaoFilme = duracaoFilmetb.Text;
                string categoria_nome = categoriaFilmescb.Text.ToString();
                // Validar os dados
                if (string.IsNullOrEmpty(nomeFilme) || string.IsNullOrEmpty(duracaoFilme) || string.IsNullOrEmpty(categoria_nome))
                {
                    MessageBox.Show("Por favor, preencha todos os campos.");
                    return;
                }
                // Validar a duração
                if (!duracaoFilme.All(char.IsDigit))
                {
                    MessageBox.Show("A duração deve ser um número.");
                    return;
                }
                // Validar a categoria
                Categoria categoria = cinegest.Categorias.ToList().FirstOrDefault(c => c.Nome == categoria_nome);
                if (categoria == null)
                {
                    MessageBox.Show("A categoria selecionada não existe.");
                    return;
                }
                // Adicionar o filme
                Filme novoFilme = new Filme(nomeFilme, duracaoFilme, "Desactivado", categoria);
                cinegest.Filmes.Add(novoFilme);
                cinegest.SaveChanges();

                MessageBox.Show("Filme adicionado com sucesso!");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

    }
}