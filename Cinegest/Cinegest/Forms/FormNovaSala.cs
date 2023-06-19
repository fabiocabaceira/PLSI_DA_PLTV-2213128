using System;
using System.Linq;
using System.Windows.Forms;

namespace Cinegest.Forms
{
    public partial class FormNovaSala : Form
    {
        CineGestEntities5 cinegest;
        int cinemaId = 1;

        /// <summary>
        /// Construtor da classe FormNovaSala
        /// </summary>
        /// <param name="cinemaid"></param>
        public FormNovaSala(int cinemaid)
        {
            this.cinemaId = cinemaid;
            cinegest = new CineGestEntities5();
            InitializeComponent();
        }

        /// <summary>
        /// Método que carrega os dados da sala para o formulário
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormNovaSala_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Método que adiciona uma nova sala à base de dados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AdicionarSalabtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar se os campos estão preenchidos
                if (string.IsNullOrWhiteSpace(salaNometb.Text))
                {
                    MessageBox.Show("Por favor, preencha o nome da sala.");
                    return;
                }
                // Verificar se os campos estão preenchidos
                if (!int.TryParse(salaColunastb.Text, out int colunas) || !int.TryParse(salaFilastb.Text, out int filas))
                {
                    MessageBox.Show("Por favor, preencha as colunas e as filas com números.");
                    return;
                }
                // Procurar o cinema
                Cinema cinema = cinegest.Cinemas.ToList().FirstOrDefault(c => c.Id == cinemaId);
                // Se o cinema existir
                if (cinema != null)
                {
                    // Adicionar a sala
                    Sala novaSala = new Sala(colunas, filas, cinemaId, salaNometb.Text);
                    cinegest.Salas.Add(novaSala);
                    cinegest.SaveChanges();
                    MessageBox.Show("Sala adicionada com sucesso.");
                }
                else
                {
                    MessageBox.Show("Tem de preencher primeiro os dados do Cinema");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}