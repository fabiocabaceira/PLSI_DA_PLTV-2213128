using System;
using System.Windows.Forms;

namespace Cinegest.Forms
{
    public partial class FormNovoCliente : Form
    {

        CineGestEntities5 db;

        /// <summary>
        /// construtor da classe
        /// </summary>
        public FormNovoCliente()
        {
            InitializeComponent();
            db = new CineGestEntities5();
        }

        /// <summary>
        /// Metodo que permite adicionar um novo cliente à base de dados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Adicionarbtn_Click(object sender, EventArgs e)
        {
            try
            {
                // recolher os dados do formulário
                string nome = nometb.Text;
                string morada = moradatb.Text;
                int.TryParse(numFiscaltb.Text, out int numFiscal);

                if (nome == "" || morada == "" || !int.TryParse(numFiscaltb.Text, out numFiscal) || numFiscaltb.Text.Length != 9)
                {
                    MessageBox.Show("Tem de preencher todos os campos corretamente. O número fiscal deve ser um número de 9 dígitos.");
                }
                else
                {
                    Cliente novoCliente = new Cliente(nome, morada, numFiscal);
                    db.Pessoas.Add(novoCliente);
                    db.SaveChanges();
                    MessageBox.Show("Cliente adicionado com sucesso.");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {

        }
    }
}
