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
        // Variáveis 
        public int contador = 1;
        public string idSessao;
        public string funcionario_Nome;
        public string nomeFilme;
        DateTime hora;
        public List<String> Bilhete = new List<String>();
        CineGestEntities5 cinegest;
        string nomeCliente;
        Cliente cliente;
        Funcionario funcionario;
        public int i = 1;
        public string nomeCliente1;
        public string lugar2;
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

        private void criarBilhetes()
        {
            int s1 = int.Parse(idSessao);

            var bilhetes = cinegest.Bilhetes.FirstOrDefault(b => b.SessaoId == s1);

            if (bilhetes == null)
            {

                Sessao sessao = cinegest.Sessaos.FirstOrDefault(b => b.Id == s1);
                Sala sala = cinegest.Salas.FirstOrDefault(b => b.Id == sessao.SalaId);
                int lugares = sala.Filas * sala.Colunas;
                funcionario = cinegest.Funcionarios.FirstOrDefault(b => b.Nome == funcionario_Nome);
                while (i <= lugares)
                {
                    int lugar = i;
                    string estado = "Disponível";
                    int sessao_id = int.Parse(idSessao);
                    int funcionario_id = funcionario.Id;
                    int cliente_id = 4;
                    Bilhete bilhete = new Bilhete(lugar, estado, sessao_id, funcionario_id, cliente_id);
                    cinegest.Bilhetes.Add(bilhete);
                    cinegest.SaveChanges();
                    i++;
                }
            }

        }

        // Método que lista os bilhetes disponíveis para a sessão selecionada
        private void listarBilhetes()
        {
            bilhetesBindingSource1.DataSource = null;
            int s1 = int.Parse(idSessao);
            var bilhetes = cinegest.Bilhetes.ToList().Where(b => b.SessaoId == s1);
            Console.WriteLine(bilhetes);
            bilhetesBindingSource1.DataSource = bilhetes;

        }

        private void FormAtendimento_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cineGestDataSet1.Pessoas_Cliente' table. You can move, or remove it, as needed.
            this.pessoas_ClienteTableAdapter.Fill(this.cineGestDataSet1.Pessoas_Cliente);
            // TODO: This line of code loads data into the 'cineGestDataSet.Bilhetes' table. You can move, or remove it, as needed.
            funcionariolbl.Text = "Funcionário atual: " + funcionario_Nome;
            criarBilhetes();
            listarBilhetes();
            funcionario = cinegest.Funcionarios.FirstOrDefault(b => b.Nome == funcionario_Nome);
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Verifica se o valor da célula não é nulo ou vazio antes de acessá-lo
            if (dataGridView1.Rows[e.RowIndex].Cells["Estado"].Value != null && !string.IsNullOrEmpty(dataGridView1.Rows[e.RowIndex].Cells["Estado"].Value.ToString()))
            {
                // Define a cor de fundo da célula com base no valor da coluna "Estado"
                if (dataGridView1.Rows[e.RowIndex].Cells["Estado"].Value.ToString() == "Disponível")
                {
                    e.CellStyle.BackColor = Color.LightGreen;
                }
                else if (dataGridView1.Rows[e.RowIndex].Cells["Estado"].Value.ToString() == "Vendido")
                {
                    e.CellStyle.BackColor = Color.Gray;
                }
            }

            // Obtém o ID da sessão selecionada
            int s1 = int.Parse(idSessao);

            // Obtém a sala associada à sessão
            Sessao sessao = cinegest.Sessaos.FirstOrDefault(b => b.Id == s1);
            Sala sala = cinegest.Salas.FirstOrDefault(b => b.Id == sessao.SalaId);

            // Obtém o nome da sala
            string nomeSala = sala.Nome.ToString();

            // Define o valor da célula com base no índice da coluna
            if (e.ColumnIndex == this.dataGridView1.Columns["NomeSala"].Index)
            {
                e.Value = nomeSala;
            }
            else
            {
                e.Value = e.Value;
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

        private void emitir_bilhete(string nomeCliente)
        {
            int s1 = int.Parse(idSessao);

            // Cria um arquivo de texto com um nome de arquivo exclusivo para cada bilhete
            TextWriter bilhete1 = new StreamWriter($"C:\\\\Users\\\\Public\\\\bilhete{contador}.txt");
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
            foreach (var lugar2 in Bilhete)
            {
                bilhete1.Write($"{lugar2} ");
                int lugar3 = int.Parse(lugar2);
                Bilhete bilhete = cinegest.Bilhetes.FirstOrDefault(b => b.Lugar == lugar3 && b.SessaoId == s1);
                bilhete.Estado = "Vendido";
                cinegest.SaveChanges();

                var cliente3 = cinegest.Clientes.FirstOrDefault(b => b.Nome == nomeCliente);
                if (cliente3 == null)
                {
                    bilhete.ClienteId = 4;
                    cinegest.SaveChanges();

                }
                else
                {
                    bilhete.ClienteId = cliente3.Id;
                    cinegest.SaveChanges();

                }
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
            int lugar1 = 0;
            int s1 = int.Parse(idSessao);

            if (e.RowIndex >= 0)
            {
                // Obtém o lugar do bilhete que foi alterado
                var lugar = dataGridView1.Rows[e.RowIndex].Cells["Lugar"].Value.ToString();
                lugar1 = int.Parse(lugar);
                // Adiciona o lugar a um array de lugares do bilhete

                var bilhetes = cinegest.Bilhetes.ToList().Where(b => b.SessaoId == s1 && b.Lugar == lugar1);
                foreach (var bilhete in bilhetes)
                {
                    if (bilhete.Estado == "Disponível" && bilhete.SessaoId == s1)
                    {
                        lugar2 = lugar1.ToString();
                        Bilhete.Add(lugar2);

                    }
                    else
                    {
                        MessageBox.Show("O bilhete que selecionou já foi vendido");

                    }
                }

            }
        }

        private void emitirbtn_Click(object sender, EventArgs e)
        {

            string nome = cliente_Nometb.Text;
            string morada = cliente_Moradatb.Text;
            int numFiscal = int.Parse(cliente_Numfiscaltb.Text);
            if (nome == "" || morada == "")
            {
                MessageBox.Show("Tem de insirir todos os campos");
            }
            var cliente = cinegest.Clientes.FirstOrDefault(b => b.Nome == nome);
            contador++;

            if (cliente == null)
            {
                DialogResult result = MessageBox.Show("Deseja guardar os dados do novo cliente na base de dados", "Confirmar", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    Cliente novocliente = new Cliente(nome, morada, numFiscal);
                    cinegest.Pessoas.Add(novocliente);
                    cinegest.SaveChanges();
                    nomeCliente = novocliente.Nome;
                    emitir_bilhete(nomeCliente);
                }
                else
                {
                    nomeCliente1 = nomeCliente;
                    emitir_bilhete(nomeCliente1);
                }

            }
            else
            {
                emitir_bilhete(nome);
            }

        }
    }
}