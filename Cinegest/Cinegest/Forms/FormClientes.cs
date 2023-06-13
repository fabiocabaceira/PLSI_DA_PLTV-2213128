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
    public partial class FormClientes : Form
    {
        CineGestEntities5 cinegest;
        string nomeCliente;
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

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            nomeCliente = dataGridView1.Rows[e.RowIndex].Cells["Nome"].Value.ToString();

            var pessoasClientes = cinegest.Pessoas.OfType<Cliente>().ToList();
            foreach (var cliente in pessoasClientes)
            {
                if (cliente.Nome.Contains(nomeCliente))
                {
                    alterarNomelbl.Text = cliente.Nome;
                    alterarMoradalbl.Text = cliente.Morada;
                    alterarNumFiscallbl.Text = cliente.NumFiscal.ToString();
                    break;
                }
            }

        }

        //Apagar
        private void apagarClientebtn_Click(object sender, EventArgs e)
        {
            Cliente cliente = cinegest.Clientes.FirstOrDefault(b => b.Nome == nomeCliente);
            cinegest.Clientes.Remove(cliente);
            cinegest.SaveChanges();
        }
    }
}