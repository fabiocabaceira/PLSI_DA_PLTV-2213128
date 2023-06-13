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

        private void FormClientes_Load(object sender, EventArgs e)
        {
            // Consultar
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
            if (e.ColumnIndex == this.dataGridView1.Columns["BilhetesVendidos"].Index || e.ColumnIndex == this.dataGridView1.Columns["ValorTotal"].Index)
            {
                nomeCliente = dataGridView1.Rows[e.RowIndex].Cells["Nome"].Value == null ?
                  string.Empty : dataGridView1.Rows[e.RowIndex].Cells["Nome"].Value.ToString();

                Cliente cliente = cinegest.Clientes.FirstOrDefault(b => b.Nome == nomeCliente);

                var nrDeBilhetes = cliente != null && cliente.Bilhetes != null ? cliente.Bilhetes.Count : 0;
                var bilhetes = cinegest.Bilhetes.OfType<Bilhete>().ToList();
                var bilhetesDoCliente = bilhetes.Where(b => b.ClienteId == cliente?.Id);

                int precoTotal = 0;
                foreach (var bilhete in bilhetesDoCliente)
                {
                    var sessaos = cinegest.Sessaos.OfType<Sessao>().ToList();
                    var sessoesDoCliente = sessaos.Where(s => s.Id == bilhete.SessaoId);
                    foreach (var sessao in sessoesDoCliente)
                    {
                        precoTotal += sessao.Preco;
                    }
                }

                if (e.ColumnIndex == this.dataGridView1.Columns["BilhetesVendidos"].Index)
                {
                    if (nrDeBilhetes > 0)
                    {
                        e.Value = nrDeBilhetes;
                    }
                    else
                    {
                        e.Value = 0;
                    }
                }
                else if (e.ColumnIndex == this.dataGridView1.Columns["ValorTotal"].Index)
                {
                    if (precoTotal > 0)
                    {
                        e.Value = precoTotal;

                    }
                    else
                    {
                        e.Value = 0;
                    }
                }
            }
        }

    }
}