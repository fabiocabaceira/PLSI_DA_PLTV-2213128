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
    public partial class FormAgendamentoAutomatico : Form
    {
        //Declaração de Variáveis
        CineGestEntities5 cinegest;
        DateTime espacoTempo;
        int nrSessoes;

        //Construtor
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
                preencher_E_FormatarElementos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Método utilizado para preencher e formatar os dados do formulário
        /// </summary>
        private void preencher_E_FormatarElementos()
        {
            try
            {
                //ComboBoxes
                var filmes = cinegest.Filmes.ToList();
                var salas = cinegest.Salas.ToList();
                filmescb.DataSource = filmes;
                salacb.DataSource = salas;
                filmescb.DisplayMember = "Nome";
                salacb.DisplayMember = "Nome";
                //DateTimePicker
                agenAutodtp.Format = DateTimePickerFormat.Custom;
                agenAutodtp.CustomFormat = "HH:mm:ss tt";
                agenAutodtp.MinDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day + 1);
                agenAutodtp.MaxDate = new DateTime(2100, 12, 31);
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
        private void formatar_DateTimePicker(DateTimePicker picker)
        {
            picker.Format = DateTimePickerFormat.Custom;
            picker.CustomFormat = "HH:mm";
            picker.ShowUpDown = true;
        }

        /// <summary>
        /// Método que mostra ou esconde os DatetimePickers de acordo com o número de sessões que foram selecionadas no NumericUpDown
        /// </summary>
        /// <param name="nrdesessoes"></param>
        private void mostrarOuEsconderDateTimePickers(int nrdesessoes)
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
                            formatar_DateTimePicker((DateTimePicker)dateTimePickers[0]);
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
        private void nrSessoesnud_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                mostrarOuEsconderDateTimePickers((int)nrSessoesnud.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        /// <summary>
        /// Evento que é ativado quando o valor do DateTimePicker de tempo é alterado.
        /// </summary>
        /// <param name="sender">O objeto que gerou o evento.</param>
        /// <param name="e">Os argumentos do evento.</param>
        private void agenAutodtp_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                espacoTempo = agenAutodtp.Value;

                if (agenAutodtp.Value.Date == DateTime.Now.Date)
                {
                    MessageBox.Show("Não pode selecionar a data de hoje");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

    }
}