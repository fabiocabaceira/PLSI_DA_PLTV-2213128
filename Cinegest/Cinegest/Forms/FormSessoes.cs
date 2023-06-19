using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace Cinegest.Forms
{
    public partial class FormSessoes : Form
    {
        CineGestEntities5 cinegest;

        /// <summary>
        /// construtor da classe
        /// </summary>
        public FormSessoes()
        {
            cinegest = new CineGestEntities5();
            InitializeComponent();
        }

        /// <summary>
        /// Evento que carrega a tabela com os dados da base de dados   
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormSessoes_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "HH:mm:ss tt";
            var salas = cinegest.Salas.ToList();
            var filmes = cinegest.Filmes.ToList();

            salascb.DataSource = salas;
            salascb.DisplayMember = "Nome";

            filmescb.DataSource = filmes;
            filmescb.DisplayMember = "Nome";
        }

        private bool VerificarSeExisteSessaoMarcada(Sala sala, DateTime dataHora, Filme filme)
        {
            if (!int.TryParse(filme.Duracao, out
                var duracao))
                return false; //Erro

            //Calcular hora de começo/fim do filme alvo
            //Estas sao as horas em que não pode haver outro filme
            DateTime novoFilmeHoraComeco = dataHora;
            DateTime novoFilmeHoraFim = dataHora;

            //Os filmes desse filme
            var sessoesNoDiaAlvo = cinegest.Sessaos.Where(s => s.SalaId == sala.Id && DbFunctions.TruncateTime(s.Datahora) == dataHora.Date).ToList();
            if (sessoesNoDiaAlvo.Count() == 0)
                return true;

            int collisoes = 0;
            foreach (var sessaoFilme in sessoesNoDiaAlvo)
            {
                if (!int.TryParse(sessaoFilme.Filme.Duracao, out
                    var sessaoFilmeDuracao))
                {
                    collisoes++; //Erro
                    continue;
                }

                DateTime sessaoFilmeHoraComeco = sessaoFilme.Datahora;
                DateTime sessaoFilmeHoraFim = sessaoFilme.Datahora.AddMinutes(sessaoFilmeDuracao);

                //casos possiveis
                //-- sessaoFilmeHoraComeco<---novoFilmeHoraComeco--->sessaoFilmeHoraFim
                //-- sessaoFilmeHoraComeco<---novoFilmeHoraFim--->sessaoFilmeHoraFim
                //-- novoFilmeHoraComeco<=== [sessaoFilmeHoraComeco<------>sessaoFilmeHoraFim] ===>novoFilmeHoraFim
                //OR:
                //-- novoFilmeHoraComeco<=== [sessaoFilmeHoraComeco<---] ===>novoFilmeHoraFim
                //-- novoFilmeHoraComeco<=== [--->sessaoFilmeHoraFim] ===>novoFilmeHoraFim
                //returna falso em qualquer das opções acima

                if (sessaoFilmeHoraComeco <= novoFilmeHoraComeco && novoFilmeHoraComeco <= sessaoFilmeHoraFim)
                    collisoes++;
                else if (sessaoFilmeHoraComeco <= novoFilmeHoraFim && novoFilmeHoraFim <= sessaoFilmeHoraFim)
                    collisoes++;
                else if (novoFilmeHoraComeco <= sessaoFilmeHoraComeco && sessaoFilmeHoraComeco <= novoFilmeHoraFim)
                    collisoes++;
                else if (novoFilmeHoraComeco <= sessaoFilmeHoraFim && sessaoFilmeHoraFim <= novoFilmeHoraFim)
                    collisoes++;

            }
            if (collisoes != 0)
                return false;
            return true;
        }

        /// <summary>
        /// Função que permite verificar se O filme está activo
        /// </summary>
        /// <param name="filme"></param>
        /// <returns></returns>
        private int VerificarSeOFilmeTemEstadoActivo(Filme filme)
        {
            return filme.Activo == "Activo" ? 1 : 0;
        }

        /// <summary>
        /// Evento que é ativado quando o botão de criar sessão é clicado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CriarSessaobtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar se os campos obrigatórios estão preenchidos
                if (string.IsNullOrWhiteSpace(precotb.Text) ||
                  string.IsNullOrWhiteSpace(filmescb.Text) ||
                  string.IsNullOrWhiteSpace(salascb.Text))
                {
                    MessageBox.Show("Por favor, preencha todos os campos obrigatórios.");
                }
                else if (!int.TryParse(precotb.Text, out int preco))
                {
                    MessageBox.Show("Por favor, insira um valor numérico válido para o preço.");
                }
                else
                {
                    // Obter os dados dos campos
                    string nomeFilme = filmescb.Text.ToString();
                    string nomeSala = salascb.Text.ToString();
                    System.DateTime Datahora = DateTime.Parse(dateTimePicker1.Value.ToString());
                    Sala sala = cinegest.Salas.ToList().FirstOrDefault(c => c.Nome == nomeSala);
                    int salaId = sala.Id;
                    Filme filme = cinegest.Filmes.ToList().FirstOrDefault(c => c.Nome == nomeFilme);

                    // Verificar se o filme está activo
                    if (VerificarSeOFilmeTemEstadoActivo(filme) == 0)
                    {
                        MessageBox.Show("O filme não está activo, não pode ser agendado");
                    }
                    // Verificar se a sala está ocupada a esta hora
                    else if (VerificarSeExisteSessaoMarcada(sala, Datahora, filme))
                    {
                        // Criar a sessão
                        int filmeId = filme.Id;
                        Sessao novaSessao = new Sessao(salaId, Datahora, preco, filmeId);
                        cinegest.Sessaos.Add(novaSessao);
                        cinegest.SaveChanges();
                        MessageBox.Show("A sessão foi adicionada com sucesso");
                    }
                    else
                    {
                        MessageBox.Show("A sala já está ocupada a esta hora, escolha uma hora/sala diferente");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Evento que abre o formulário de agendamento automático
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AgendamentoAutomaticobtn_Click(object sender, EventArgs e)
        {
            FormAgendamentoAutomatico formAgendamentoAutomatico = new FormAgendamentoAutomatico();
            formAgendamentoAutomatico.ShowDialog();
        }
    }
}