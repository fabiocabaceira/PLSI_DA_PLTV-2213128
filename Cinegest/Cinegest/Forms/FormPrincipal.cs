using System;
using System.Windows.Forms;

namespace Cinegest.Forms
{
    public partial class FormPrincipal : Form
    {
        CineGestEntities5 db;

        /// <summary>
        /// Construtor da classe
        /// </summary>
        public FormPrincipal()
        {
            InitializeComponent(); // Inicializa os componentes do FormPrincipal
            db = new CineGestEntities5();
        }

        /// <summary>
        /// Evento que carrega os dados das tabelas Sessaos e Pessoas_Funcionario no FormPrincipal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            // Carrega os dados da tabela Sessaos no cineGestDataSet1
            this.sessaosTableAdapter.Fill(this.cineGestDataSet1.Sessaos);
            // Carrega os dados da tabela Pessoas_Funcionario no cineGestDataSet
            this.pessoas_FuncionarioTableAdapter.Fill(this.cineGestDataSet.Pessoas_Funcionario);

        }

        /// <summary>
        /// Evento que permite abrir o formulário FormCinema
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cinemabtn_Click(object sender, EventArgs e)
        {
           
                FormCinema FmCinemas = new FormCinema(); // Instancia o formulário FormCinema
                FmCinemas.ShowDialog(); // Abre o formulário FormCinema
                FormPrincipal_Load(sender, e); // Atualiza os dados do FormPrincipal
        }

        /// <summary>
        /// Evento que permite abrir o formulário FormFilmes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Filmesbtn_Click(object sender, EventArgs e)
        {
            FormFilmes FmFilmes = new FormFilmes(); // Instancia o formulário FormFilmes
            FmFilmes.ShowDialog(); // Abre o formulário FormFilmes
            FormPrincipal_Load(sender, e); // Atualiza os dados do FormPrincipal
        }

        /// <summary>
        /// Evento que permite abrir o formulário FormSessoes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Sessaobtn_Click(object sender, EventArgs e)
        {
            FormSessoes FmSessoes = new FormSessoes(); // Instancia o formulário FormSessoes
            FmSessoes.ShowDialog(); // Abre o formulário FormSessoes
            FormPrincipal_Load(sender, e); // Atualiza os dados do FormPrincipal
        }

        /// <summary>
        /// Evento que permite abrir o formulário FormClientes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Clientesbtn_Click(object sender, EventArgs e)
        {
            FormClientes FmClientes = new FormClientes(); // Instancia o formulário FormClientes
            FmClientes.ShowDialog(); // Abre o formulário FormClientes
            FormPrincipal_Load(sender, e); // Atualiza os dados do FormPrincipal
        }

        /// <summary>
        /// evento que permite selecionar uma sessão e abrir o formulário FormAtendimento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sessoesdgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Obtém o Nome do Funcionario da célula selecionada da combobox
            string funcionario_Nome = funcionariocb.Text;
            // Obtém o id da sessão da célula selecionada
            string idSessao = sessoesdgv.Rows[e.RowIndex].Cells["Id"].Value.ToString();
            // Obtém o nome do filme da célula selecionada
            string NomeFilme = sessoesdgv.Rows[e.RowIndex].Cells["FilmeNome"].Value.ToString();
            // Obtém a data e hora da célula selecionada
            DateTime hora = DateTime.Parse(sessoesdgv.Rows[e.RowIndex].Cells["Datahora"].Value.ToString());
            // Instancia o formulário com o id da sessão como argumento
            FormAtendimento FmAtendimento = new FormAtendimento(idSessao, funcionario_Nome, NomeFilme, hora);
            // Abre o formulário FormAtendimento
            FmAtendimento.ShowDialog();
            FormPrincipal_Load(sender, e); // Atualiza os dados do FormPrincipal
        }

        /// <summary>
        /// Abre o formulário FormCinema
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Funcionariosbtn_Click(object sender, EventArgs e)
        {
            FormCinema fmcinema2 = new FormCinema();
            fmcinema2.ShowDialog();
            FormPrincipal_Load(sender, e); // Atualiza os dados do FormPrincipal
        }
       
    }
}