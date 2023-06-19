using System;
using System.Linq;
using System.Windows.Forms;

namespace Cinegest.Forms
{
    public partial class FormCinema : Form
    {
        // Variáveis de instância
        CineGestEntities5 cinegest;
        string nomeFuncionario = "";
        string nomeSala = "";
        int cinemaId = 1;

        /// <summary>
        /// construtor da classe
        /// </summary>
        public FormCinema()
        {
            cinegest = new CineGestEntities5();
            InitializeComponent();
        }

        /// <summary>
        /// Evento que carrega os dados do cinema
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCinema_Load(object sender, EventArgs e)
        {
            try
            {
                salasBindingSource.DataSource = cinegest.Salas.ToList();
                pessoasFuncionarioBindingSource.DataSource = cinegest.Funcionarios.ToList();
                ListarCinema();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        /// <summary>
        /// lista os dados do cinema
        /// </summary>
        public void ListarCinema()
        {
            // Listar dados do cinema
            var cinemas = cinegest.Cinemas.ToList<Cinema>();
            Cinema cinema = cinegest.Cinemas.OfType<Cinema>().FirstOrDefault(f => f.Id == cinemaId);

            // Se existir um cinema na base de dados
            if (cinemas.Count > 0)
            {
                // Mostrar os dados do cinema
                cinemaNometb.Text = cinema.Nome;
                cinemaMoradatb.Text = cinema.Morada;
                cinemaEmailtb.Text = cinema.Email;
                cinemaId = cinema.Id;
                cinegest.SaveChanges();
            }
        }

        /// <summary>
        /// Evento que permite a criação de um cinema
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void criarCinemabtn_Click(object sender, EventArgs e)
        {
            // Listar cinemas
            var cinemas = cinegest.Cinemas.ToList<Cinema>();

            // Se não existir nenhum cinema na base de dados
            if (cinemas.Count <= 0)
            {
                // dados do cinema
                String Nome = cinemaNometb.Text;
                String Morada = cinemaMoradatb.Text;
                String Email = cinemaEmailtb.Text;

                // Se os campos estiverem preenchidos
                if (Nome != "" && Morada != "" && Email.Contains("@"))
                {
                    // Criar cinema
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

        /// <summary>
        /// Evento que permite a edição de um cinema
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Obter o nome do funcionário
            nomeFuncionario = dataGridView1.Rows[e.RowIndex].Cells["nomefunc"].Value.ToString();
            // Obter o funcionário
            var funcionario = cinegest.Pessoas.OfType<Funcionario>().FirstOrDefault(f => f.Nome == nomeFuncionario);
            // Se o funcionário existir
            if (funcionario != null)
            {
                // Mostrar os dados do funcionário
                funcionarioNometb.Text = funcionario.Nome.ToString();
                funcionarioFuncaotb.Text = funcionario.Funcao.ToString();
                funcionarioMoradatb.Text = funcionario.Morada.ToString();
                funcionarioSalariotb.Text = funcionario.Salario.ToString();
            }

        }

        /// <summary>
        /// Apaga um funcionário
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ApagarFuncionariobtn_Click(object sender, EventArgs e)
        {
            // Obter o funcionário
            Funcionario funcionario = cinegest.Funcionarios.OfType<Funcionario>().FirstOrDefault(f => f.Nome == nomeFuncionario);
            // Se o funcionário existir
            if (funcionario != null)
            {
                // Apagar o funcionário
                cinegest.Funcionarios.Remove(funcionario);
                cinegest.SaveChanges();
                FormCinema_Load(sender, e);

            }
        }

        /// <summary>
        /// Evento que permite a criação de um novo funcionário
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NovoFuncionariotb_Click(object sender, EventArgs e)
        {

            FormNovoFuncionario fmNovoFuncionario = new FormNovoFuncionario();
            fmNovoFuncionario.ShowDialog();
            FormCinema_Load(sender, e);

        }

        /// <summary>
        /// Evento que permite a edição de um funcionário
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            // Obter o funcionário
            Funcionario funcionario = cinegest.Funcionarios.OfType<Funcionario>().FirstOrDefault(f => f.Nome == nomeFuncionario);
            // definir os novos dados do funcionário
            if (funcionario != null)
            {
                funcionario.Nome = funcionarioNometb.Text.ToString();
                funcionario.Funcao = funcionarioFuncaotb.Text.ToString();
                funcionario.Morada = funcionarioMoradatb.Text.ToString();
                funcionario.Salario = int.Parse(funcionarioSalariotb.Text);
                cinegest.SaveChanges();
                FormCinema_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Por favor, selecione um funcionário");
            }
            
        }

        /// <summary>
        /// Evento que permite a criação de uma nova sala
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            FormNovaSala fmNovaSala = new FormNovaSala(cinemaId);
            fmNovaSala.ShowDialog();
            FormCinema_Load(sender, e);

        }

        /// <summary>
        /// Evento que permite a remoção de uma sala
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ApagarSalabtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Obter a sala
                Sala sala = cinegest.Salas.OfType<Sala>().FirstOrDefault(f => f.Nome == nomeSala);
                // Se a sala existir
                if (sala != null)
                {
                    // Apagar a sala
                    cinegest.Salas.Remove(sala);
                    cinegest.SaveChanges();
                    FormCinema_Load(sender, e);

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Nenhuma sala selecionada");
            }

        }

        /// <summary>
        /// Evento que permite a edição de uma sala
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Obter o nome da sala
            nomeSala = dataGridView2.Rows[e.RowIndex].Cells["salanome"].Value.ToString();
            // Obter a sala
            var sala = cinegest.Salas.OfType<Sala>().FirstOrDefault(v => v.Nome == (nomeSala));
            // Se a sala existir
            if (sala != null)
            {
                // Mostrar os dados da sala
                salaNometb.Text = sala.Nome.ToString();
                salaColunastb.Text = sala.Colunas.ToString();
                salaFilastb.Text = sala.Filas.ToString();
            }
        }

        /// <summary>
        /// Evento que permite guardar as alterações feitas a uma sala
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GuardarSalabtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Obter a sala
                Sala sala = cinegest.Salas.OfType<Sala>().FirstOrDefault(f => f.Nome == nomeSala);
                // Se a sala existir
                if (sala != null)
                {
                    // Guardar as alterações feitas à sala
                    sala.Nome = salaNometb.Text.ToString();
                    sala.Colunas = int.Parse(salaColunastb.Text);
                    sala.Filas = int.Parse(salaFilastb.Text);
                    cinegest.SaveChanges();
                    FormCinema_Load(sender, e);

                }
                else
                {
                    MessageBox.Show("Não pode guardar alterações numa sala antes de o criar");

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        /// <summary>
        /// Evento que permite guardar os dados do cinema
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GuardarCinemabtn_Click(object sender, EventArgs e)
        {
            try
            {
                Cinema cinema = cinegest.Cinemas.OfType<Cinema>().FirstOrDefault(f => f.Id == cinemaId);
                if (cinema != null)
                {
                    cinema.Nome = cinemaNometb.Text;
                    cinema.Morada = cinemaMoradatb.Text;
                    cinema.Email = cinemaEmailtb.Text;
                    cinegest.SaveChanges();
                    FormCinema_Load(sender, e);

                }
                else
                {
                    MessageBox.Show("Não pode guardar alterações num cinema antes de o criar");

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

    }
}