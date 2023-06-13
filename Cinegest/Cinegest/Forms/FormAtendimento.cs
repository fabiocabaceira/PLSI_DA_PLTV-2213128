using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinegest.Forms
{
    public partial class FormAtendimento : Form
    {
        // Variáveis de instância
        public string idSessao;
        public string funcionario_Nome;
        public string nomeFilme;
        DateTime hora;
        public List<String> Bilhete = new List<String>();
        CineGestEntities5 cinegest;
        string nomeCliente;
        Cliente cliente;
        Funcionario funcionario;

        public FormAtendimento(string idSessao, string funcionario_Nome, string nomeFilme, DateTime hora)
        {
            // Construtor que recebe o ID da sessão selecionada e o nome do funcionario
            this.idSessao = idSessao;
            this.funcionario_Nome = funcionario_Nome;
            this.nomeFilme = nomeFilme;
            this.hora = hora;
            cinegest = new CineGestEntities5();
            InitializeComponent();
        }

        // Método que lista os bilhetes disponíveis para a sessão selecionada
        private void listarBilhetes()
        {
            bilhetesBindingSource.DataSource = null;
            int s1 = int.Parse(idSessao);
            Console.WriteLine(s1);
            var bilhetes = cineGestDataSet.Bilhetes;
            var bilhetes2 = bilhetes.Where(bilhete => bilhete.SessaoId == s1);
            bilhetesBindingSource.DataSource = bilhetes2;
        }

        private void FormAtendimento_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cineGestDataSet1.Pessoas_Cliente' table. You can move, or remove it, as needed.
            this.pessoas_ClienteTableAdapter.Fill(this.cineGestDataSet1.Pessoas_Cliente);
            // TODO: This line of code loads data into the 'cineGestDataSet.Bilhetes' table. You can move, or remove it, as needed.
            this.bilhetesTableAdapter.Fill(this.cineGestDataSet.Bilhetes);
            funcionariolbl.Text = "Funcionário atual: " + funcionario_Nome;
            listarBilhetes();
            funcionario = cinegest.Funcionarios.FirstOrDefault(b => b.Nome == funcionario_Nome);
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells["Estado"].Value.ToString() == "Disponível")
            {
                e.CellStyle.BackColor = Color.LightGreen;
            }
            else if (dataGridView1.Rows[e.RowIndex].Cells["Estado"].Value.ToString() == "Vendido")
            {
                e.CellStyle.BackColor = Color.Gray;
            }

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string nomeCliente = dataGridView3.Rows[e.RowIndex].Cells["Nome"].Value.ToString();
            cliente = cinegest.Clientes.FirstOrDefault(b => b.Nome == nomeCliente);
            var clientes = this.pessoas_ClienteTableAdapter.GetData().ToList();

            cliente_Nometb.Text = cliente.Nome;
            cliente_Moradatb.Text = cliente.Morada;
            cliente_Numfiscaltb.Text = cliente.NumFiscal.ToString();

        }

        private void emitir_bilhete()
        {
            // Cria um arquivo de texto chamado "teste.txt" na pasta Public do usuário
            TextWriter bilhete1 = new StreamWriter("C:\\\\Users\\\\Public\\\\teste.txt");
            // Escreve os dados do bilhete
            // nome do cliente
            bilhete1.Write("Nome = ");
            bilhete1.Write($"{cliente_Nometb.Text} ");
            //  morada do cliente
            bilhete1.Write("\nMorada = ");
            bilhete1.Write($"{cliente_Moradatb.Text} ");
            // número fiscal do cliente
            bilhete1.Write("\nNumFiscal = ");
            bilhete1.Write($"{cliente_Numfiscaltb.Text} ");
            // nome do filme 
            bilhete1.Write("\nNome Do Filme = ");
            bilhete1.Write($"{nomeFilme} ");
            // data e hora da sessão
            bilhete1.Write("\nData/hora = ");
            bilhete1.Write($"{hora} ");
            // lugar(es) do bilhete 
            bilhete1.Write("\nLugar/Lugares Do Bilhete = ");
            foreach (var lugar1 in Bilhete)
            {
                bilhete1.Write($"{lugar1} ");
                var lugar2 = int.Parse(lugar1);
                Bilhete bilhete = cinegest.Bilhetes.FirstOrDefault(b => b.Lugar == lugar2);
                bilhete.Estado = "Vendido";
                bilhete.ClienteId = cliente.Id;
                bilhete.FuncionarioId = funcionario.Id;
                cinegest.SaveChanges();
            }
            // nome do funcionário 
            bilhete1.Write("\nFuncionário = ");
            bilhete1.Write($"{funcionario_Nome} ");
            // Fecha o arquivo
            bilhete1.Close();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var lugar1 = "";

            if (e.RowIndex >= 0)
            {
                // Obtém o lugar do bilhete que foi alterado
                var lugar = dataGridView1.Rows[e.RowIndex].Cells["Lugar"].Value;
                lugar1 = lugar.ToString();
                // Adiciona o lugar a um array de lugares do bilhete
                Bilhete.Add(lugar1);
            }
        }

        private void emitirbtn_Click(object sender, EventArgs e)
        {

            emitir_bilhete();
        }
    }
}