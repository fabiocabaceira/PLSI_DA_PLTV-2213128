using Cinegest.CineGestDataSetTableAdapters;
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
    public partial class FormCinema : Form
    {
        CineGestEntities5 cinegest;
        string nomeFuncionario = "";
        string nomeSala = "";
        int cinemaId = 0;
        public FormCinema()
        {
            cinegest = new CineGestEntities5();
            InitializeComponent();
        }

        private void FormCinema_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cineGestDataSet.Salas' table. You can move, or remove it, as needed.
            this.salasTableAdapter.Fill(this.cineGestDataSet.Salas);
            // TODO: This line of code loads data into the 'cineGestDataSet.Pessoas_Funcionario' table. You can move, or remove it, as needed.
            this.pessoas_FuncionarioTableAdapter.Fill(this.cineGestDataSet.Pessoas_Funcionario);
            listarCinema();
        }

        public void listarCinema()
        {
            var cinemas = cinegest.Cinemas.ToList<Cinema>();

            if (cinemas.Count > 0)
            {
                criarCinemabtn.Text = "Alterar Detalhes";
                Cinema primeiroCinema = cinemas.First();
                cinemaNometb.Text = primeiroCinema.Nome;
                cinemaMoradatb.Text = primeiroCinema.Morada;
                cinemaEmailtb.Text = primeiroCinema.Email;
                cinemaId = primeiroCinema.Id;
                cinegest.SaveChanges();
            }
        }

        private void criarCinemabtn_Click(object sender, EventArgs e)
        {
            var cinemas = cinegest.Cinemas.ToList<Cinema>();

            if (cinemas.Count < 0)
            {
                criarCinemabtn.Text = "Criar Cinema";
                Cinema cinema = new Cinema();
                cinema.Nome = cinemaNometb.Text;
                cinema.Morada = cinemaMoradatb.Text;
                cinema.Email = cinemaEmailtb.Text;
                cinegest.SaveChanges();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            nomeFuncionario = dataGridView1.Rows[e.RowIndex].Cells["Nome"].Value.ToString();

            var funcionario = cinegest.Pessoas.OfType<Funcionario>().FirstOrDefault(f => f.Nome.Contains(nomeFuncionario));
            if (funcionario != null)
            {
                funcionarioNometb.Text = funcionario.Nome.ToString();
                funcionarioFuncaotb.Text = funcionario.Funcao.ToString();
                funcionarioMoradatb.Text = funcionario.Morada.ToString();
                funcionarioSalariotb.Text = funcionario.Salario.ToString();
            }

        }

        private void apagarFuncionariobtn_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = cinegest.Funcionarios.OfType<Funcionario>().FirstOrDefault(f => f.Nome == nomeFuncionario);
            if (funcionario != null)
            {
                cinegest.Funcionarios.Remove(funcionario);
                cinegest.SaveChanges();
            }
        }

        private void novoFuncionariotb_Click(object sender, EventArgs e)
        {

            FormNovoFuncionario fmNovoFuncionario = new FormNovoFuncionario();
            fmNovoFuncionario.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = cinegest.Funcionarios.OfType<Funcionario>().FirstOrDefault(f => f.Nome == nomeFuncionario);

            funcionario.Nome = funcionarioNometb.Text.ToString();
            funcionario.Funcao = funcionarioFuncaotb.Text.ToString();
            funcionario.Morada = funcionarioMoradatb.Text.ToString();
            funcionario.Salario = int.Parse(funcionarioSalariotb.Text);
            cinegest.SaveChanges();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormNovaSala fmNovaSala = new FormNovaSala(cinemaId);
            fmNovaSala.ShowDialog();
        }

        private void apagarSalabtn_Click(object sender, EventArgs e)
        {
            Sala sala = cinegest.Salas.OfType<Sala>().FirstOrDefault(f => f.Nome == nomeSala);
            if (sala != null)
            {
                cinegest.Salas.Remove(sala);
                cinegest.SaveChanges();
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            nomeSala = dataGridView2.Rows[e.RowIndex].Cells["salanome"].Value.ToString();

            var sala = cinegest.Salas.OfType<Sala>().FirstOrDefault(v => v.Nome == (nomeSala));
            if (sala != null)
            {
                salaNometb.Text = sala.Nome.ToString();
                salaColunastb.Text = sala.Colunas.ToString();
                salaFilastb.Text = sala.Filas.ToString();
            }
        }
    }
}