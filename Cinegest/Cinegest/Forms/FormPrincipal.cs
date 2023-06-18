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
        CineGestEntities5 db;
        public FormPrincipal()
        {
            InitializeComponent(); // Inicializa os componentes do FormPrincipal
            db = new CineGestEntities5();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            // Carrega os dados da tabela Sessaos no cineGestDataSet1
            this.sessaosTableAdapter.Fill(this.cineGestDataSet1.Sessaos);
            // Carrega os dados da tabela Pessoas_Funcionario no cineGestDataSet
            this.pessoas_FuncionarioTableAdapter.Fill(this.cineGestDataSet.Pessoas_Funcionario);

        }

        private void cinemabtn_Click(object sender, EventArgs e)
        {
           
                FormCinema FmCinemas = new FormCinema(); // Instancia o formulário FormCinema
                FmCinemas.ShowDialog(); // Abre o formulário FormCinema
            
            

        }

        private void filmesbtn_Click(object sender, EventArgs e)
        {
            
                FormFilmes FmFilmes = new FormFilmes(); // Instancia o formulário FormFilmes
                FmFilmes.ShowDialog(); // Abre o formulário FormFilmes
            
           

        }

        private void sessaobtn_Click(object sender, EventArgs e)
        {
            
                FormSessoes FmSessoes = new FormSessoes(); // Instancia o formulário FormSessoes
                FmSessoes.ShowDialog(); // Abre o formulário FormSessoes
           
            

        }

        private void clientesbtn_Click(object sender, EventArgs e)
        {

            FormClientes FmClientes = new FormClientes(); // Instancia o formulário FormClientes
            FmClientes.ShowDialog(); // Abre o formulário FormClientes

        }

       
        

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

        }

        private void funcionariosbtn_Click(object sender, EventArgs e)
        {
            FormCinema fmcinema2 = new FormCinema();
            fmcinema2.ShowDialog();
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
           FormPrincipal_Load(sender, e);
        }
    }
}