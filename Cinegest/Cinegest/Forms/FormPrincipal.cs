// Importação de bibliotecas
using Cinegest;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cinegest.Forms
{
    public partial class FormPrincipal : Form
    {
        // Classe do formulário principal
        public FormPrincipal()
        {
            InitializeComponent(); // Inicializa os componentes do formulário
        }

        // Métodos acionados pelos botões da interface gráfica

        // Botão Cinema - Abre o FormCinema
        private void Cinemabtn_Click(object sender, EventArgs e)
        {
            try
            {
                FormCinema FmCinemas = new FormCinema();
                FmCinemas.ShowDialog(); // Abre o formulário FormCinema
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
                FmFilmes.ShowDialog(); // Abre o formulário FormFilmes
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
                FmSessoes.ShowDialog(); // Abre o formulário FormSessoes
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar abrir o formulário.");
            }
        }

        // Botão Clientes - Abre o FormClientes
        private void Clientesbtn_Click(object sender, EventArgs e)
        {
            
                FormClientes FmClientes = new FormClientes();
                FmClientes.ShowDialog(); // Abre o formulário FormClientes
            
            
        }

        // Botão Funcionarios - Abre o FormFuncionarios
        private void Funcionariosbtn_Click(object sender, EventArgs e)
        {
            try
            {
                FormFuncionarios FmFuncionarios = new FormFuncionarios();
                FmFuncionarios.ShowDialog(); // Abre o formulário FormFuncionarios
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar abrir o formulário.");
            }
        }

        // Método que é executado quando o formulário é carregado
        // Preenche as tabelas com os dados
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            this.pessoas_FuncionarioTableAdapter.FillFuncionarios(this.data.Pessoas_Funcionario);
            this.pessoasTableAdapter1.Fill(this.data.Pessoas);
            this.sessãoTableAdapter1.Sessoes_diarias(this.data.Sessão);

        }

        // Evento acionado quando uma célula da tabela é clicada
        // Abre o formulário FormAtendimento passando o o idsessao como argumento
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            // Verifica se a célula clicada é uma célula de botão
            
                string funcionario_Nome = selecionar_funcionario_cb.Text; // Obtém o Nome do Funcionario da célula selecionada da combobox
                string idSessao = dataGridView1.Rows[e.RowIndex].Cells["IdSessao"].Value.ToString(); // Obtém o id da sessão da célula selecionada
                string NomeFilme = dataGridView1.Rows[e.RowIndex].Cells["filmeNome"].Value.ToString(); // Obtém o nome do filme da célula selecionada
                DateTime hora = DateTime.Parse(dataGridView1.Rows[e.RowIndex].Cells["datahora"].Value.ToString()); // Obtém a data e hora da célula selecionada
                FormAtendimento FmAtendimento = new FormAtendimento(idSessao, funcionario_Nome, NomeFilme, hora); // Instancia o formulário com o id da sessão como argumento
                FmAtendimento.ShowDialog(); // Abre o formulário FormAtendimento  
        }

        // Atualiza a lista de sessões diárias
        private void sessoes_diariasToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.sessãoTableAdapter1.Sessoes_diarias(this.data.Sessão);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void sessoes_diariasToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.sessãoTableAdapter1.Sessoes_diarias(this.data.Sessão);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
