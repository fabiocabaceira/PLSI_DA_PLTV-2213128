﻿using Cinegest.Models;
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
    public partial class FormPrincipal : Form
    {
        CineGestEntities db;
        public FormPrincipal()
        {
            InitializeComponent();
            db = new CineGestEntities();
            listarSessoes();
            listarFuncionarios();
        }

        // Botões

        // Botão Cinema - Abre o FormCinema
        private void Cinemabtn_Click(object sender, EventArgs e)
        {
            try
            {
                FormCinema FmCinemas = new FormCinema();
                FmCinemas.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar abrir o formulário.");
            }
        }

        // Botão Filmes - Abre o FormFilmes
        private void Filmesbtn_Click(object sender, EventArgs e)
        {
            try
            {
                FormFilmes FmFilmes = new FormFilmes();
                FmFilmes.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar abrir o formulário.");
            }
        }

        // Botão Sessões - Abre o FormSessões
        private void Sessõesbtn_Click(object sender, EventArgs e)
        {
            try
            {
                FormSessoes FmSessoes = new FormSessoes();
                FmSessoes.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar abrir o formulário.");
            }
        }

        // Botão Clientes - Abre o FormClientes
        private void Clientesbtn_Click(object sender, EventArgs e)
        {
            try
            {
                FormClientes FmClientes = new FormClientes();
                FmClientes.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar abrir o formulário.");
            }
        }

        // Botão Funcionarios - Abre o FormFuncionarios
        private void Funcionariosbtn_Click(object sender, EventArgs e)
        {
            try
            {
                FormFuncionarios FmFuncionarios = new FormFuncionarios();
                FmFuncionarios.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar abrir o formulário.");
            }
        }

        // Método para listar as sessões que estam marcadas para o dia atual
        private void listarSessoes()
        {
            try
            {
                this.sessãoTableAdapter.Fillu(this.cineGestDataSet.Sessão);

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        // Método para listar os funcionarios que estam a usar o formulário
        private void listarFuncionarios()
        {
            try
            {
                this.pessoasTableAdapter.fill_Funcionario(this.cineGestDataSet.Pessoas);


            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        // Método que é executado quando o formulário é carregado
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        // Toolstrip Update
        private void filterByCurrentDateToolStripButton_Click(object sender, EventArgs e)
        {
            this.sessãoTableAdapter.Fillu(this.cineGestDataSet.Sessão);
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string idSessao = dataGridView1.Rows[e.RowIndex].Cells["IdSessao"].Value.ToString(); // obtém o nome da sessão da célula selecionada
                FormAtendimento FmAtendimento = new FormAtendimento(idSessao); // instancia o formulário com o nome da sessão como argumento
                FmAtendimento.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar abrir o formulário.");
            }
        }

    }
}
