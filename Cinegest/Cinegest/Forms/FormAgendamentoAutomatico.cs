using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Cinegest.Forms
{
    public partial class FormAgendamentoAutomatico : Form
    {
        // Variáveis de instância
        CineGestEntities5 cinegest;
        DateTime tempoInicial;
        DateTime tempoFinal;

        /// <summary>
        /// Construtor do FormAgendamentoAutomatico
        /// </summary>
        public FormAgendamentoAutomatico()
        {
            InitializeComponent();
            cinegest = new CineGestEntities5();
        }

        /// <summary>
        /// Método que é utilizado quando o formulário é carregado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormAgendamentoAutomatico_Load(object sender, EventArgs e)
        {
            try
            {
                Preencher_E_FormatarElementos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Método utilizado para preencher e formatar os dados do formulário
        /// </summary>
        private void Preencher_E_FormatarElementos()
        {
            try
            {
                //ComboBoxes
                List<Filme> filmes = cinegest.Filmes.ToList();
                List<Sala> salas = cinegest.Salas.ToList();
                filmescb.DataSource = filmes;
                salacb.DataSource = salas;
                filmescb.DisplayMember = "Nome";
                salacb.DisplayMember = "Nome";

                //DateTimePicker
                agenAutoIniciodtp.Format = DateTimePickerFormat.Custom;
                agenAutoIniciodtp.CustomFormat = "dd/MM/yyyy";
                agenAutoFimdtp.Format = DateTimePickerFormat.Custom;
                agenAutoFimdtp.CustomFormat = "dd/MM/yyyy";
                agenAutoIniciodtp.MinDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day + 1);
                agenAutoIniciodtp.MaxDate = new DateTime(2100, 12, 31);
                agenAutoFimdtp.MinDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day + 1);
                agenAutoFimdtp.MaxDate = new DateTime(2100, 12, 31);
                Controls.Add(agenAutoIniciodtp);
                Controls.Add(agenAutoFimdtp);

                //NumericUpDown
                nrSessoesnud.Value = 0;
                nrSessoesnud.Minimum = 0;
                nrSessoesnud.Maximum = 5;

                //Visibilidade das Labels e DateTimePickers
                for (int i = 0; i <= 5; i++)
                {
                    var dateTimePickers = Controls.Find("sessao" + i + "dtp", true);
                    var labels = Controls.Find("sessao" + i + "lbl", true);

                    if (dateTimePickers.Length > 0)
                    {
                        DateTimePicker dateTimePicker = dateTimePickers[0] as DateTimePicker;
                        dateTimePicker.Visible = false;
                        dateTimePicker.Format = DateTimePickerFormat.Custom;
                        dateTimePicker.CustomFormat = "HH:mm:ss tt";
                    }

                    if (labels.Length > 0)
                    {
                        Label label = labels[0] as Label;
                        label.Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Método utilizado para formatar os DateTimePickers criados
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        private void Formatar_DateTimePicker(DateTimePicker picker)
        {
            picker.Format = DateTimePickerFormat.Custom;
            picker.CustomFormat = "HH:mm";
            picker.ShowUpDown = true;
        }

        /// <summary>
        /// Método que mostra ou esconde os DatetimePickers de acordo com o número de sessões que foram selecionadas no NumericUpDown
        /// </summary>
        /// <param name="nrdesessoes"></param>
        private void MostrarOuEsconderDateTimePickers(int nrdesessoes)
        {
            try
            {
                for (int i = 0; i <= 5; i++)
                {
                    Control[] dateTimePickers = Controls.Find("sessao" + i + "dtp", true);
                    Control[] labels = Controls.Find("sessao" + i + "lbl", true);
                    if (dateTimePickers.Length > 0 && labels.Length > 0)
                    {
                        bool visible = i <= nrdesessoes;
                        dateTimePickers[0].Visible = visible;
                        labels[0].Visible = visible;
                        if (visible)
                        {
                            Formatar_DateTimePicker((DateTimePicker)dateTimePickers[0]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Evento que é ativado quando o valor do NumericUpDown é mudado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NrSessoesnud_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                MostrarOuEsconderDateTimePickers((int)nrSessoesnud.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Event that is triggered when the "set time" button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DefinirTempobtn_Click(object sender, EventArgs e)
        {
            try
            {
                tempoInicial = agenAutoIniciodtp.Value.Date;
                tempoFinal = agenAutoFimdtp.Value.Date;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Verifica se há conflito de sessões na sala e data/hora especificadas
        /// </summary>
        /// <param name="dataHora"></param>
        /// <param name="salaId"></param>
        /// <returns></returns>
        private bool VerificarConflitoDeSessoes(DateTime dataHora, int salaId, DateTime dataDia)
        {
            try
            {
                // Seleciona todas as sessões existentes na sala após a data/hora especificadas
                IQueryable<Sessao> sessoesExistente = cinegest.Sessaos.Where(s => s.SalaId == salaId && s.Datahora >= dataHora && s.Datahora >= dataDia);
                // Verifica se há alguma sessão existente na mesma data/hora especificada
                foreach (Sessao sessao in sessoesExistente)
                {
                    if (sessao.Datahora == dataHora)
                    {
                        return true;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            return false;
        }

        /// <summary>
        /// Cria sessões diárias para o período entre duas datas especificadas
        /// </summary>
        /// <param name="tempoInicial"></param>
        /// <param name="tempoFinal"></param>
        /// <param name="dataHora"></param>
        private void CriarSessoesDiarias(DateTime tempoInicial, DateTime tempoFinal, DateTime dataHora)
        {

            // Obtém o nome da sala e do filme selecionados
            try
            {

                string nomeSala = salacb.Text.ToString();
                string nomeFilme = filmescb.Text.ToString();
                // Seleciona a sala e o filme correspondentes
                Sala salaSelecionada = cinegest.Salas.FirstOrDefault(b => b.Nome == nomeSala);
                Filme filmeSelecionado = cinegest.Filmes.FirstOrDefault(f => f.Nome == nomeFilme);
                // Obtém os IDs da sala e do filme
                int SalaId = salaSelecionada.Id;
                int FilmeId = filmeSelecionado.Id;
                // Obtém o preço do filme
                int.TryParse(filmePrecotb.Text.ToString(), out int Preco);
                // Cria sessões para cada dia no intervalo especificado
                for (DateTime data = tempoInicial.Date; data <= tempoFinal.Date; data = data.AddDays(1))
                {
                    // Adiciona um dia à data/hora atual
                    dataHora = dataHora.AddDays(1);
                    DateTime dataHora2 = dataHora.Date;

                    // Verifica se há conflito de sessões na sala e data/hora especificadas
                    if (!VerificarConflitoDeSessoes(dataHora, SalaId, dataHora2))
                    {
                        // Cria uma nova sessão e a adiciona ao contexto do EF
                        Sessao sessao = new Sessao(SalaId, dataHora, Preco, FilmeId);
                        cinegest.Sessaos.Add(sessao);
                        continue;
                    }

                    // Mostra uma mensagem de erro se houver conflito de sessões
                    MessageBox.Show("Já existe uma sessão marcada para essa hora");

                }

                // Salva as alterações no contexto do EF
                cinegest.SaveChanges();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        /// <summary>
        /// Obtém uma data/hora a partir de um DateTimePicker
        /// </summary>
        /// <param name="dtp"></param>
        /// <returns></returns>
        private DateTimePicker GetDateTimeFromPicker(DateTimePicker dtp)
        {

            // Obtém a hora selecionada a partir do DateTimePicker

            string selectedHour = dtp.Value.ToString("HH");
            string selectedMinute = dtp.Value.ToString("mm");

            // Cria um TimeSpan com a hora selecionada
            TimeSpan time = new TimeSpan(int.Parse(selectedHour), int.Parse(selectedMinute), 0);

            // Cria um novo DateTimePicker com a data/hora especificadas
            DateTimePicker result = new DateTimePicker();
            result.Value = dtp.Value.Date.Add(time);
            return result;
        }

        /// <summary>
        /// Evento que é acionado quando o botão "Agendar" é clickado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Agendarbtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtém as datas/horas selecionadas a partir dos DateTimePickers visíveis
                DateTimePicker[] datasHoras = new DateTimePicker[] {
          sessao1dtp,
          sessao2dtp,
          sessao3dtp,
          sessao4dtp,
          sessao5dtp
        }.Where(dtp => dtp.Visible).Select(dtp => GetDateTimeFromPicker(dtp)).ToArray();

                // Cria sessões diárias para cada data/hora selecionada
                foreach (DateTimePicker dataHora in datasHoras)
                {
                    CriarSessoesDiarias(tempoInicial, tempoFinal, dataHora.Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}