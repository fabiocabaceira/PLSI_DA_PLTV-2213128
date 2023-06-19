using System;
using System.Windows.Forms;

namespace Cinegest.Forms
{
    public partial class FormNovoFuncionario : Form
    {
        CineGestEntities5 cinegest;

        /// <summary>
        /// construtor da classe
        /// </summary>
        public FormNovoFuncionario()
        {
            cinegest = new CineGestEntities5();
            InitializeComponent();
        }

        /// <summary>
        /// Método que carrega as informações do formulário
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormNovoFuncionario_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Evento que permite adicionar um novo funcionário à base de dados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void adicionarbtn_Click(object sender, EventArgs e)
        {
            // recolher os dados do formulário
            if (nomeFuncionariotb.Text == "" || moradaFuncionariotb.Text == "" || salarioFuncionariotb.Text == "" || !int.TryParse(salarioFuncionariotb.Text, out int salario))
            {
                MessageBox.Show("Por favor, preencha todos os campos e verifique se o salário é um número válido.");
                return;
            }

            try
            {
                // adicionar o funcionário à base de dados
                string nome = nomeFuncionariotb.Text;
                string morada = moradaFuncionariotb.Text;
                string funcao = funcaoFuncionariotb.Text;
                Funcionario novoFuncionario = new Funcionario(nome, morada, funcao, salario);
                cinegest.Pessoas.Add(novoFuncionario);
                cinegest.SaveChanges();
                MessageBox.Show("Funcionário adicionado com sucesso.");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

    }
}