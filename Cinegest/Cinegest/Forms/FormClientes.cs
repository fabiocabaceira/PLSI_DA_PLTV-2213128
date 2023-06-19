using System;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Linq;
using System.Windows.Forms;

namespace Cinegest.Forms
{
    public partial class FormClientes : Form
    {
        CineGestEntities5 cinegest;
        string nomeCliente = "";
        int nrDeBilhetes;
        int precoTotal;

        /// <summary>
        /// construtor da classe
        /// </summary>
        public FormClientes()
        {
            cinegest = new CineGestEntities5();
            InitializeComponent();
        }

        /// <summary>
        /// Evento que carrega a tabela com os dados da base de dados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormClientes_Load(object sender, EventArgs e)
        {

            this.pessoas_ClienteTableAdapter.Fill(this.cineGestDataSet.Pessoas_Cliente);

        }

        /// <summary>
        /// Metodo que permite registar um novo cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NovoClientebtn_Click(object sender, EventArgs e)
        {
            FormNovoCliente formNovoCliente = new FormNovoCliente();
            formNovoCliente.ShowDialog();
            FormClientes_Load(sender, e);
        }

        /// <summary>
        /// Metodo que permite alterar os dados de um cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AlterarClientebtn_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = alterarNomelbl.Text;
                string morada = alterarMoradalbl.Text;
                int numFiscal = int.Parse(alterarNumFiscallbl.Text);
                Cliente cliente = cinegest.Clientes.FirstOrDefault(b => b.Nome == nomeCliente);
                if (cliente == null)
                {
                    MessageBox.Show("Não existe nenhum cliente com esse nome");
                    return;
                }
                else
                {
                    cliente.Nome = nome;
                    cliente.Morada = morada;
                    cliente.NumFiscal = numFiscal;
                    cinegest.SaveChanges();
                    FormClientes_Load(sender, e);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
            


        }

        /// <summary>
        /// Metodo que permite apagar um cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ApagarClientebtn_Click(object sender, EventArgs e)
        {
            try
            {
                // recolher os dados do formulário
                string nome = alterarNomelbl.Text;
                var clientes = cinegest.Clientes.ToList().Where(b => b.Nome == nome);
                // apagar o cliente
                foreach (var cliente in clientes)
                {
                    cinegest.Clientes.Remove(cliente);
                    cinegest.SaveChanges();
                    FormClientes_Load(sender, e);

                }

            }
            catch (Exception)
            {
                MessageBox.Show("Não é possível apagar este cliente porque tem bilhetes associados.");
            }

        }

        /// <summary>
        /// Metodo que permite selecionar um cliente da tabela
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Verifica se a coluna atual é a "BilhetesVendidos" ou "ValorTotal"
            if (e.ColumnIndex != this.dataGridView1.Columns["BilhetesVendidos"].Index && e.ColumnIndex != this.dataGridView1.Columns["ValorTotal"].Index)
            {
                return;
            }

            // Obtém o nome do cliente a partir da linha atual
            var nomeCliente = dataGridView1.Rows[e.RowIndex].Cells["Nome"].Value?.ToString();

            // Obtém o cliente correspondente ao nome
            var cliente = cinegest.Clientes.FirstOrDefault(b => b.Nome == nomeCliente);

            // Obtém o número de bilhetes comprados pelo cliente
            var nrDeBilhetes = cliente?.Bilhetes?.Count ?? 0;

            // Obtém todos os bilhetes vendidos
            var bilhetes = cinegest.Bilhetes.OfType<Bilhete>().ToList();

            // Obtém apenas os bilhetes vendidos pelo cliente atual
            var bilhetesDoCliente = bilhetes.Where(b => b.ClienteId == cliente?.Id);

            // Calcula o preço total dos bilhetes vendidos pelo cliente atual
            var precoTotal = bilhetesDoCliente.Sum(b => cinegest.Sessaos.OfType<Sessao>().FirstOrDefault(s => s.Id == b.SessaoId)?.Preco ?? 0);

            // Define o valor da célula atual com o número de bilhetes vendidos ou com o valor total, dependendo da coluna
            e.Value = e.ColumnIndex == this.dataGridView1.Columns["BilhetesVendidos"].Index ? nrDeBilhetes : precoTotal;
        }

        /// <summary>
        /// Metodo que permite selecionar um cliente da tabela
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Obtém o nome do cliente a partir da linha atual
                nomeCliente = dataGridView1.Rows[e.RowIndex].Cells["Nome"].Value.ToString();
                // Obtém o cliente correspondente ao nome
                var cliente = cinegest.Pessoas.OfType<Cliente>().FirstOrDefault(c => c.Nome.Contains(nomeCliente));
                // Verifica se o cliente existe
                if (cliente != null)
                {
                    // Define os valores dos campos de texto com os dados do cliente
                    alterarNomelbl.Text = cliente.Nome;
                    alterarMoradalbl.Text = cliente.Morada;
                    alterarNumFiscallbl.Text = cliente.NumFiscal.ToString();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }             
           
        }

    }
}