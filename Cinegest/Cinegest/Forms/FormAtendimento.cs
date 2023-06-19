using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Cinegest.Forms
{
    public partial class FormAtendimento : Form
    {
        // Variáveis de instância
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

        /// <summary>
        /// Construtor da classe FormAtendimento    
        /// </summary>
        /// <param name="idSessao"></param>
        /// <param name="funcionario_Nome"></param>
        /// <param name="nomeFilme"></param>
        /// <param name="hora"></param>
        public FormAtendimento(string idSessao, string funcionario_Nome, string nomeFilme, DateTime hora)
        {
            this.idSessao = idSessao;
            this.funcionario_Nome = funcionario_Nome;
            this.nomeFilme = nomeFilme;
            this.hora = hora;
            cinegest = new CineGestEntities5();
            InitializeComponent();
        }

        /// <summary>
        /// Método que cria os bilhetes para a sessão selecionada
        /// </summary>
        private void CriarBilhetes()
        {
            try
            {
                // Obter o id da sessão
                int.TryParse(idSessao, out int s1);
                // Obter os bilhetes da sessão
                var bilhetes = cinegest.Bilhetes.FirstOrDefault(b => b.SessaoId == s1);

                // Se não existirem bilhetes para a sessão
                if (bilhetes == null)
                {
                    // Obter a Sessão
                    Sessao sessao = cinegest.Sessaos.FirstOrDefault(b => b.Id == s1);
                    // Obter a sala
                    Sala sala = cinegest.Salas.FirstOrDefault(b => b.Id == sessao.SalaId);
                    // Obter o número de lugares
                    int lugares = sala.Filas * sala.Colunas;
                    // Obter o funcionário
                    funcionario = cinegest.Funcionarios.FirstOrDefault(b => b.Nome == funcionario_Nome);
                    // Enquanto o contador for menor ou igual ao número de lugares
                    while (i <= lugares)
                    {
                        // Criar um bilhete
                        int lugar = i;
                        string estado = "Disponível";
                        int sessao_id = int.Parse(idSessao);
                        int funcionario_id = funcionario.Id;
                        int cliente_id = 4;
                        Bilhete bilhete = new Bilhete(lugar, estado, sessao_id, funcionario_id, cliente_id);
                        cinegest.Bilhetes.Add(bilhete);
                        cinegest.SaveChanges();
                        // Incrementar o contador
                        i++;
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        /// <summary>
        /// Método que lista os bilhetes da sessão selecionada
        /// </summary>
        private void ListarBilhetes()
        {
            // Limpar a fonte de dados
            bilhetesBindingSource1.DataSource = null;
            // Obter o id da sessão
            int.TryParse(idSessao, out int s1);
            // Obter os bilhetes da sessão
            var bilhetes = cinegest.Bilhetes.ToList().Where(b => b.SessaoId == s1);
            // Adicionar os bilhetes à fonte de dados
            bilhetesBindingSource1.DataSource = bilhetes;

        }

        /// <summary>
        /// Método que carrega os dados da sessão para o formulário
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormAtendimento_Load(object sender, EventArgs e)
        {
            this.pessoas_ClienteTableAdapter.Fill(this.cineGestDataSet1.Pessoas_Cliente);
            funcionariolbl.Text = "Funcionário atual: " + funcionario_Nome;
            CriarBilhetes();
            ListarBilhetes();
            funcionario = cinegest.Funcionarios.FirstOrDefault(b => b.Nome == funcionario_Nome);
            dataGridView1.CellFormatting += DataGridView1_CellFormatting;
        }

        private void DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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
            int.TryParse(idSessao, out int s1);

            // Obtém a sala associada à sessão
            Sessao sessao = cinegest.Sessaos.FirstOrDefault(b => b.Id == s1);
            Sala sala = cinegest.Salas.FirstOrDefault(b => b.Id == sessao.SalaId);

            // Obtém o nome da sala
            string nomeSala = sala.Nome.ToString();

            // Define o valor da célula com base no índice da coluna
            if (e.ColumnIndex == this.dataGridView1.Columns["NomeSala"].Index)
            {
                // Define o valor da célula
                e.Value = nomeSala;
            }
            else
            {
                // Define o valor da célula
                e.Value = e.Value;
            }
        }

        /// <summary>
        /// Emite um bilhete para o cliente selecionado
        /// </summary>
        /// <param name="nomeCliente">Nome do cliente</param>
        private void EmitirBilhete(string nomeCliente)
        {
            int.TryParse(idSessao, out int s1);

            using (TextWriter bilhete1 = new StreamWriter($"C:\\\\\\\\Users\\\\\\\\Public\\\\\\\\bilhete{contador}.txt"))
            {
                // Obtém informações do cliente
                Cliente cliente = cinegest.Clientes.FirstOrDefault(c => c.Nome == nomeCliente);
                if (cliente == null)
                {
                    cliente = cinegest.Clientes.FirstOrDefault(c => c.Id == 4);
                }

                // Escreve as informações do bilhete no arquivo
                bilhete1.WriteLine($"Nome = {cliente.Nome}");
                bilhete1.WriteLine($"Morada = {cliente.Morada}");
                bilhete1.WriteLine($"NumFiscal = {cliente.NumFiscal}");
                bilhete1.WriteLine($"Nome Do Filme = {nomeFilme}");
                bilhete1.WriteLine($"Data/hora = {hora}");

                // Altera o estado do(s) bilhete(s) vendido(s)
                foreach (var lugar in Bilhete)
                {
                    int.TryParse(lugar, out int lugarNum);
                    Bilhete bilhete = cinegest.Bilhetes.FirstOrDefault(b => b.Lugar == lugarNum && b.SessaoId == s1);
                    if (bilhete != null)
                    {
                        bilhete.Estado = "Vendido";
                        bilhete.ClienteId = cliente.Id;
                        bilhete.FuncionarioId = funcionario.Id;
                        cinegest.SaveChanges();
                    }
                }

                // Escreve informações do funcionário no bilhete
                bilhete1.WriteLine($"Funcionário = {funcionario_Nome}");
            }
        }

        /// <summary>
        /// Evento que é acionado quando o valor de uma célula é alterado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Obtém o ID da sessão selecionada
            int.TryParse(idSessao, out int s1);

            // Verifica se o índice da linha é maior ou igual a 0
            if (e.RowIndex >= 0)
            {
                // Obtém o lugar do bilhete que foi alterado
                var lugar = dataGridView1.Rows[e.RowIndex].Cells["Lugar"].Value.ToString();
                // Converte o lugar para inteiro
                int.TryParse(lugar, out int lugar1);
                // Obtém os bilhetes que têm o lugar selecionado
                IEnumerable<Bilhete> bilhetes = cinegest.Bilhetes.ToList().Where(b => b.SessaoId == s1 && b.Lugar == lugar1);
                // foreach que percorre os bilhetes
                foreach (Bilhete bilhete in bilhetes)
                {
                    // Verifica se o estado do bilhete é "Disponível" e se a sessão é a selecionada
                    if (bilhete.Estado == "Disponível" && bilhete.SessaoId == s1)
                    {
                        // Converte o lugar para string
                        lugar2 = lugar1.ToString();
                        // Adiciona o lugar à lista de lugares do bilhete
                        Bilhete.Add(lugar2);
                    }
                    else
                    {
                        MessageBox.Show("O bilhete que selecionou já foi vendido");

                    }
                }
            }
        }

        /// <summary>
        /// Evento que é acionado quando o utilizador clica numa célula
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Obtém o nome do cliente selecionado
            string nomeCliente = dataGridView3.Rows[e.RowIndex].Cells["Nome"].Value.ToString();

            // Procura o cliente na base de dados
            cliente = cinegest.Clientes.FirstOrDefault(b => b.Nome == nomeCliente);

            // Obtém os dados do cliente selecionado
            var clientes = this.pessoas_ClienteTableAdapter.GetData().ToList();

            // Preenche os campos com os dados do cliente selecionado
            cliente_Nometb.Text = cliente.Nome;
            cliente_Moradatb.Text = cliente.Morada;
            cliente_Numfiscaltb.Text = cliente.NumFiscal.ToString();
        }

        /// <summary>
        /// Evento que é acionado quando o utilizador clica no botão emitir bilhete
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Emitirbtn_Click(object sender, EventArgs e)
        {
            // obtem o nome do cliente
            string nome = cliente_Nometb.Text;
            // obtem a morada do cliente
            string morada = cliente_Moradatb.Text;
            // obtem o numero fiscal do cliente
            int numFiscal = int.Parse(cliente_Numfiscaltb.Text);
            if (nome == "" || morada == "")
            {
                MessageBox.Show("Tem de insirir todos os campos");
            }
            // Procura o cliente na base de dados
            Cliente cliente = cinegest.Clientes.FirstOrDefault(b => b.Nome == nome);
            // Incrementa o contador
            contador++;

            // Verifica se o cliente existe na base de dados
            if (cliente == null)
            {
                DialogResult result = MessageBox.Show("Deseja guardar os dados do novo cliente na base de dados", "Confirmar", MessageBoxButtons.YesNo);
                // Verifica se o utilizador clicou no botão "Sim"
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Cria um novo cliente
                        Cliente novocliente = new Cliente(nome, morada, numFiscal);
                        cinegest.Pessoas.Add(novocliente);
                        cinegest.SaveChanges();
                        nomeCliente = novocliente.Nome;
                        EmitirBilhete(nomeCliente);
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }

                }
                else
                {
                    // Preenche os campos com os dados do cliente selecionado
                    nomeCliente1 = nome;
                    EmitirBilhete(nomeCliente1);
                }

            }
            else
            {
                EmitirBilhete(nome);
            }
            FormAtendimento_Load(sender, e);

        }

        
    }
}