﻿using System;
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
        int nrSessoes;
        DateTime tempoInicial;
        DateTime tempoFinal;

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
       

        private void definirTempobtn_Click(object sender, EventArgs e)
        {
            tempoInicial = agenAutoIniciodtp.Value.Date;
            tempoFinal = agenAutoFimdtp.Value.Date;
        }

        private void CriarSessoesDiarias(DateTime tempoInicial, DateTime tempoFinal)
        {

            for (var data = tempoInicial.Date; data <= tempoFinal.Date; data = data.AddDays(1))
            {
                for (var hora = new DateTime(data.Year, data.Month, data.Day, 10, 0, 0); hora <= new DateTime(data.Year, data.Month, data.Day, 22, 0, 0);)
                {
                    //NomeSala
                    string nomeSala = salacb.Text.ToString();
                    var salaSelecionadas = cinegest.Salas.ToList().Where(s => s.Nome == nomeSala);
                    foreach (var salaSelecionada in salaSelecionadas)
                    {
                        //Sala Id
                        int SalaId = salaSelecionada.Id;
                    }

                    //NomeFilme
                    string nomeFilme = filmescb.Text.ToString();
                    var filmeSelecionados = cinegest.Filmes.ToList().Where(f => f.Nome == nomeFilme);
                    foreach (var filmeSelecionado in filmeSelecionados)
                    {
                        //Filme 
                        int FilmeId = filmeSelecionado.Id;

                    }

                    //Preço
                    int Preco = int.Parse(filmePrecotb.Text.ToString()); 

                    //Datahora
                   
                }
            }
        }

    }
}