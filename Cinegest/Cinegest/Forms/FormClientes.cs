using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinegest.Forms
{
    public partial class FormClientes : Form
    {
        CineGestEntities5 cinegest;
        string nomeCliente = "";
        int nrDeBilhetes;
        int precoTotal;
        public FormClientes()
        {
            cinegest = new CineGestEntities5();
            InitializeComponent();
        }

        // Consultar
        private void FormClientes_Load(object sender, EventArgs e)
        {

            this.pessoas_ClienteTableAdapter.Fill(this.cineGestDataSet.Pessoas_Cliente);

        }

        //Registar
        private void novoClientebtn_Click(object sender, EventArgs e)
        {
            FormNovoCliente formNovoCliente = new FormNovoCliente();
            formNovoCliente.ShowDialog();
        }

        //Alterar
        private void alterarClientebtn_Click(object sender, EventArgs e)
        {
            string nome = alterarNomelbl.Text;
            string morada = alterarMoradalbl.Text;
            int numFiscal = int.Parse(alterarNumFiscallbl.Text);
            Cliente cliente = cinegest.Clientes.FirstOrDefault(b => b.Nome == nomeCliente);

            cliente.Nome = nome;
            cliente.Morada = morada;
            cliente.NumFiscal = numFiscal;
            cinegest.SaveChanges();
        }

        //Apagar
        private void apagarClientebtn_Click(object sender, EventArgs e)
        {
            Cliente cliente = cinegest.Clientes.FirstOrDefault(b => b.Nome == nomeCliente);
            cinegest.Clientes.Remove(cliente);
            cinegest.SaveChanges();
        }

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            nomeCliente = dataGridView1.Rows[e.RowIndex].Cells["Nome"].Value.ToString();

            var cliente = cinegest.Pessoas.OfType<Cliente>().FirstOrDefault(c => c.Nome.Contains(nomeCliente));

            if (cliente != null)
            {
                alterarNomelbl.Text = cliente.Nome;
                alterarMoradalbl.Text = cliente.Morada;
                alterarNumFiscallbl.Text = cliente.NumFiscal.ToString();
            }
        }

    }
}