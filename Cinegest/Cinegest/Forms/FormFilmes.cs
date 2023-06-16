using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Cinegest.Forms
{
    public partial class FormFilmes : Form
    {
        // Variáveis de instância
        CineGestEntities5 cinegest;
        string filmeNome;

        /// <summary>
        /// Construtor da classe FormFilmes
        /// </summary>
        public FormFilmes()
        {
            InitializeComponent();
            cinegest = new CineGestEntities5();
        }

        /// <summary>
        /// Método que carrega os dados do filme para o formulário
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormFilmes_Load(object sender, EventArgs e)
        {
            try
            {
                filmesBindingSource1.DataSource = cinegest.Filmes.ToList();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Método que formata os dados do filme para serem apresentados no formulário
        /// </summary>
        private void Formatar_Dados_Form()
        {
            try
            {
                // Obter o filme
                var filme = cinegest.Filmes.OfType<Filme>().FirstOrDefault(f => f.Nome == filmeNome);

                if (filme != null)
                {
                    // Dados do filme
                    nomeFilmetb.Text = filme.Nome;
                    duracaoFilmetb.Text = filme.Duracao;
                    filmecb.Text = filme.Activo;

                    // Obter as categorias
                    List<Categoria> categorias = cinegest.Categorias.ToList();

                    // Formatar os dados da combobox da categoria
                    categoriaFilmecb.DataSource = categorias;
                    categoriaFilmecb.DisplayMember = "Nome";
                    categoriaFilmecb.Text = filme.Categoria.Nome;

                    // Formatar os dados da combobox do estado do Filme
                    if (filmecb.Items.Count <= 0)
                    {
                        filmecb.Items.Add("Activo");
                        filmecb.Items.Add("Desactivado");

                    }
                    filmecb.DropDownStyle = ComboBoxStyle.DropDownList;
                    if (filme.Activo == "Activo")
                    {
                        filmecb.SelectedIndex = 0;
                    }
                    else
                    {
                        filmecb.SelectedIndex = 1;
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Método que edita os dados do filme
        /// </summary>
        private void Editar_Filme()
        {
            try
            {
                //Dados do filme
                string nomeFilme = nomeFilmetb.Text;
                string duracaoFilme = duracaoFilmetb.Text;
                string Activo = filmecb.Text;
                string categoria_nome = categoriaFilmecb.Text;

                //Obter a categoria do filme
                Categoria categoria = cinegest.Categorias.ToList().FirstOrDefault(c => c.Nome == categoria_nome);

                //Obter o filme
                Filme filme = cinegest.Filmes.FirstOrDefault(f => f.Nome == filmeNome);

                // Editar os dados do filme
                filme.Nome = nomeFilme;
                filme.Duracao = duracaoFilme;
                filme.Activo = Activo;
                filme.Categoria = categoria;

                // Guardar as alterações
                cinegest.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Método que apaga o filme
        /// </summary>
        private void Apagar_Filme()
        {
            try
            {
                // Obter o filme
                Filme filme = cinegest.Filmes.FirstOrDefault(f => f.Nome == filmeNome);

                // Remover o filme
                cinegest.Filmes.Remove(filme);

                // Guardar as alterações
                cinegest.SaveChanges();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Método que cria um novo filme
        /// </summary>
        private void Criar_Filme()
        {
            try
            {
                // Abrir o formulário para criar um novo filme
                FormNovoFilme fmFilme = new FormNovoFilme();
                fmFilme.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Evento que chama o método que formata os dados do filme, este método é chamado quando o botão é clicado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void alterarFilmebtn_Click(object sender, EventArgs e)
        {
            Editar_Filme();
            FormFilmes_Load(sender, e);
        }

        /// <summary>
        /// Evento que chama o método que cria um novo filme, este método é chamado quando o botão é clicado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void novoFilmebtn_Click(object sender, EventArgs e)
        {
            Criar_Filme();
            FormFilmes_Load(sender, e);
        }

        /// <summary>
        /// Evento que chama o método que apaga o filme selecionado, este método é chamado quando o botão é clicado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void apagarFilmebtn_Click(object sender, EventArgs e)
        {
            Apagar_Filme();
            FormFilmes_Load(sender, e);
        }

        /// <summary>
        /// Evento que chama o método que formata os dados do filme selecionado, este método é chamado quando uma célula do datagridview é clicada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void filmesdgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Obter o nome do filme selecionado através da célula selecionada
            filmeNome = filmesdgv.Rows[e.RowIndex].Cells["Nome"].Value.ToString();
            Formatar_Dados_Form();
        }

    }
}