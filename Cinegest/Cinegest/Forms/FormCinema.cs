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
        int cinemaId = 1;
        public FormCinema()
        {
            cinegest = new CineGestEntities5();
            InitializeComponent();
        }

        private void FormCinema_Load(object sender, EventArgs e)
        {
            try
            {
                salasBindingSource.DataSource = cinegest.Salas.ToList();
                pessoasFuncionarioBindingSource.DataSource = cinegest.Funcionarios.ToList();
                listarCinema();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        public void listarCinema()
        {
            var cinemas = cinegest.Cinemas.ToList<Cinema>();
            Cinema cinema = cinegest.Cinemas.OfType<Cinema>().FirstOrDefault(f => f.Id == cinemaId);

            if (cinemas.Count > 0)
            {
                cinemaNometb.Text = cinema.Nome;
                cinemaMoradatb.Text = cinema.Morada;
                cinemaEmailtb.Text = cinema.Email;
                cinemaId = cinema.Id;
                cinegest.SaveChanges();
            }
        }

        private void criarCinemabtn_Click(object sender, EventArgs e)
        {
            var cinemas = cinegest.Cinemas.ToList<Cinema>();

            if (cinemas.Count <= 0)
            {
                String Nome = cinemaNometb.Text;
                String Morada = cinemaMoradatb.Text;
                String Email = cinemaEmailtb.Text;

                if (Nome != "" && Morada != "" && Email.Contains("@"))
                {
                    Cinema novoCinema = new Cinema(Nome, Email, Morada);
                    cinegest.Cinemas.Add(novoCinema);
                    cinegest.SaveChanges();
                    MessageBox.Show("Cinema criado com sucesso");
                }
                else
                {
                    MessageBox.Show("Por favor, preencha todos os campos e insira um email válido.");
                }
            }
            else
            {
                MessageBox.Show("Só pode haver um cinema na base de dados");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            nomeFuncionario = dataGridView1.Rows[e.RowIndex].Cells["nomefunc"].Value.ToString();

            var funcionario = cinegest.Pessoas.OfType<Funcionario>().FirstOrDefault(f => f.Nome == nomeFuncionario);
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
                FormCinema_Load(sender, e);

            }
        }

        private void novoFuncionariotb_Click(object sender, EventArgs e)
        {

            FormNovoFuncionario fmNovoFuncionario = new FormNovoFuncionario();
            fmNovoFuncionario.ShowDialog();
            FormCinema_Load(sender, e);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = cinegest.Funcionarios.OfType<Funcionario>().FirstOrDefault(f => f.Nome == nomeFuncionario);

            funcionario.Nome = funcionarioNometb.Text.ToString();
            funcionario.Funcao = funcionarioFuncaotb.Text.ToString();
            funcionario.Morada = funcionarioMoradatb.Text.ToString();
            funcionario.Salario = int.Parse(funcionarioSalariotb.Text);
            cinegest.SaveChanges();
            FormCinema_Load(sender, e);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormNovaSala fmNovaSala = new FormNovaSala(cinemaId);
            fmNovaSala.ShowDialog();
            FormCinema_Load(sender, e);

        }

        private void apagarSalabtn_Click(object sender, EventArgs e)
        {
            Sala sala = cinegest.Salas.OfType<Sala>().FirstOrDefault(f => f.Nome == nomeSala);
            if (sala != null)
            {
                cinegest.Salas.Remove(sala);
                cinegest.SaveChanges();
                FormCinema_Load(sender, e);

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

        private void guardarSalabtn_Click(object sender, EventArgs e)
        {
            Sala sala = cinegest.Salas.OfType<Sala>().FirstOrDefault(f => f.Nome == nomeSala);

            sala.Nome = salaNometb.Text.ToString();
            sala.Colunas = int.Parse(salaColunastb.Text);
            sala.Filas = int.Parse(salaFilastb.Text);
            cinegest.SaveChanges();
            FormCinema_Load(sender, e);


        }

        private void guardarCinemabtn_Click(object sender, EventArgs e)
        {
            Cinema cinema = cinegest.Cinemas.OfType<Cinema>().FirstOrDefault(f => f.Id == cinemaId);
            cinema.Nome = cinemaNometb.Text;
            cinema.Morada = cinemaMoradatb.Text;
            cinema.Email = cinemaEmailtb.Text;
            cinegest.SaveChanges();
            FormCinema_Load(sender, e);


        }

        
    }
}