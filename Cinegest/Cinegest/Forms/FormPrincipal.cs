using Cinegest.Models;
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

        }

        //Botões

        //Botão Cinema - Abre o FormCinema
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

        //Botão Filmes - Abre o FormFilmes
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

        //Botão Sessões - Abre o FormSessões
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

        //Botão Clientes - Abre o FormClientes
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

        //Botão Funcionarios - Abre o FormFuncionarios
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


        private void listarSessoes()
        {
            try
            {
                if (db.Sessão.Count() > 0)
                {
                    sessãoBindingSource.DataSource = null;
                    sessãoBindingSource.DataSource = db.Sessão.ToList<Sessão>();
                }
                else MessageBox.Show("Não Existe Nenhuma Sessão marcada para hoje");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao listar sessões: {ex.Message}");
            }

        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cineGestDataSet.Sessão' table. You can move, or remove it, as needed.
            this.sessãoTableAdapter.Fill(this.cineGestDataSet.Sessão);

        }

        private void Updatetbn_Click(object sender, EventArgs e)
        {
            listarSessoes();
        }
    }
}
