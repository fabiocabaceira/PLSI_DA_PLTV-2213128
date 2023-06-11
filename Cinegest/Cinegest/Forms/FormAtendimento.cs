// Importação de bibliotecas
using Cinegest;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinegest.Forms
{
    // Classe do formulário de atendimento
    public partial class FormAtendimento : Form
    {
        // Variáveis de instância
        public string idSessao;
        public string funcionario_Nome;
        public string nomeFilme;
        DateTime hora;
        public List<String> Bilhete = new List<String>();

        // Construtor
        public FormAtendimento(string idSessao, string funcionario_Nome, string nomeFilme, DateTime hora)
        {
            // Construtor que recebe o ID da sessão selecionada e o nome do funcionario
            this.idSessao = idSessao;
            this.funcionario_Nome = funcionario_Nome;
            this.nomeFilme = nomeFilme;
            this.hora = hora;
            InitializeComponent();
        }

        // Método que lista os bilhetes disponíveis para a sessão selecionada
        private void listarBilhetes()
        {
            bilhetesBindingSource3.DataSource = null;
            int s1 = int.Parse(idSessao);
            Console.WriteLine(s1);
            var bilhetes = data1.Bilhetes;
            var bilhetes2 = bilhetes.Where(bilhete => bilhete.SessãoIdSessao == s1);
            bilhetesBindingSource3.DataSource = bilhetes2;
        }

        // Evento que ocorre quando o formulário é carregado
        private void FormAtendimento_Load(object sender, EventArgs e)
        {
            // Preenche a tabela de bilhetes com a sessão atual
            this.bilhetesTableAdapter1.GetSessaoAtual(this.data1.Bilhetes);
            // Preenche a tabela de clientes
            this.pessoas_ClienteTableAdapter.Fill(this.data1.Pessoas_Cliente);
            // Mostra o nome do funcionário no formulário
            funcionariolbl.Text = "Funcionário atual: " + funcionario_Nome;
            // Lista os bilhetes disponíveis para a sessão selecionada
            listarBilhetes();
            // Adiciona um evento para formatar as células da tabela de bilhetes
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
        }

        // Evento que ocorre quando o botão "getSessaoAtualToolStripButton" é clicado
        private void getSessaoAtualToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.bilhetesTableAdapter1.GetSessaoAtual(this.data1.Bilhetes);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        // Método que verifica o estado do bilhete e muda a cor de fundo da célula de acordo com o estado
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Estado"].Index && e.Value != null)
            {
                if (e.Value.ToString() == "Disponível")
                {
                    e.CellStyle.BackColor = Color.LightGreen;
                }
                else if (e.Value.ToString() == "Vendido")
                {
                    e.CellStyle.BackColor = Color.Gray;
                }
            }
        }

        // Evento que ocorre quando uma célula da tabela de clientes é clicada
        private void clientesdgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string nomeCliente = clientesdgv.Rows[e.RowIndex].Cells["Nome"].Value.ToString();

            var clientes = this.pessoas_ClienteTableAdapter.GetData().ToList();
            foreach (var cliente in clientes)
            {
                if (cliente.Nome.Contains(nomeCliente))
                {
                    cliente_Nometb.Text = cliente.Nome;
                    cliente_Moradatb.Text = cliente.Morada;
                    cliente_Numfiscaltb.Text = cliente.NumFiscal.ToString();
                    break;
                }
            }
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
            }
            // nome do funcionário 
            bilhete1.Write("\nFuncionário = ");
            bilhete1.Write($"{funcionario_Nome} ");
            // Fecha o arquivo
            bilhete1.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            emitir_bilhete();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Preenche o DataTable com os dados da tabela Bilhetes do banco de dados
                this.bilhetesTableAdapter1.FillBy(this.data.Bilhetes);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
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
    }
}
