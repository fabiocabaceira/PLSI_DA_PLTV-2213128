using Cinegest.Models;
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
    public partial class FormAtendimento : Form
    {
        public string idSessao;

        public FormAtendimento(string idSessao)
        {
            // Construtor que recebe o ID da sessão selecionada
            this.idSessao = idSessao;
            InitializeComponent();
        }

        private void listarBilhetes()
        {
            // Método que lista os bilhetes disponiveis para a sessão selecionada
            bilhetesBindingSource3.DataSource = null;
            int s1 = int.Parse(idSessao);
            Console.WriteLine(s1);
            var bilhetes = data1.Bilhetes;
            var bilhetes2 = bilhetes.Where(bilhete => bilhete.SessãoIdSessao == s1);
            bilhetesBindingSource3.DataSource = bilhetes2;
        }

        private void FormAtendimento_Load(object sender, EventArgs e)
        {
            // Evento que ocorre quando o formulário é carregado
            this.bilhetesTableAdapter1.GetSessaoAtual(this.data1.Bilhetes);
            listarBilhetes();
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;

        }

        private void getSessaoAtualToolStripButton_Click(object sender, EventArgs e)
        {
            // Evento que ocorre quando o botão "getSessaoAtualToolStripButton" é clicado
            try
            {
                this.bilhetesTableAdapter1.GetSessaoAtual(this.data1.Bilhetes);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Método que verifica o estado do bilhete e muda a cor de fundo da célula de acordo com o estado
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
    }
}
