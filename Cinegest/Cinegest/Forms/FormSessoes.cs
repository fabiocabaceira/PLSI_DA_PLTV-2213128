using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
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
            dateTimePicker1.CustomFormat = "HH:mm:ss tt";
            var salas = cinegest.Salas.ToList();
            var filmes = cinegest.Filmes.ToList();

            salascb.DataSource = salas;
            salascb.DisplayMember = "Nome";

            filmescb.DataSource = filmes;
            filmescb.DisplayMember = "Nome";
        }
        private int verificarSeExisteSessaoMarcada(Sala sala, DateTime dataHora)
        {
            var sessoes = cinegest.Sessaos
              .Where(s => s.SalaId == sala.Id && DbFunctions.TruncateTime(s.Datahora) == dataHora.Date && s.Datahora.Hour == dataHora.Hour && s.Datahora.Minute == dataHora.Minute)
              .ToList();

            return sessoes.Count;

        }

        private int  verificarSeOFilmeTemEstadoActivo (Filme filme)
        {
            if (filme.Activo == "Activo")
            {
                return 1;
            }
            else
            {
                return 0;
            }
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
            verificarSeOFilmeTemEstadoActivo(filme);
            if (verificarSeOFilmeTemEstadoActivo(filme) == 0)
            {
                MessageBox.Show("O filme não está activo, não pode ser agendado");
            }
            else
            {

                int filmeId = filme.Id;
                if (verificarSeExisteSessaoMarcada(sala, Datahora) == 0)
                {
                    Sessao novaSessao = new Sessao(salaId, Datahora, preco, filmeId);
                    cinegest.Sessaos.Add(novaSessao);
                    cinegest.SaveChanges();
                }
                else
                {
                    MessageBox.Show("A sala já está ocupada a esta hora, escolha uma hora/sala diferente");
                }
            }
        }

        private void agendamentoAutomaticobtn_Click(object sender, EventArgs e)
        {
            FormAgendamentoAutomatico formAgendamentoAutomatico = new FormAgendamentoAutomatico();
            formAgendamentoAutomatico.ShowDialog();
        }
    }
}