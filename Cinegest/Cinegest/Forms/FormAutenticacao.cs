using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Cinegest.Forms
{
    public partial class FormAutenticacao : Form
    {
        CineGestEntities5 cinegest;
        public FormAutenticacao()
        {
            cinegest = new CineGestEntities5();
            InitializeComponent();
        }

        private void FormAutenticacao_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Evento que permite a autenticação de um funcionário 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void entrarbtn_Click(object sender, EventArgs e)
        {
            string nomeFuncionario = funcionarioNometb.Text.ToString();
            var funcionarios = cinegest.Funcionarios.Where(b => b.Nome == nomeFuncionario);
            bool autenticacao = funcionarios.Any();

            if (autenticacao)
            {
                this.Hide();

                FormPrincipal fmPrincipal = new FormPrincipal();
                fmPrincipal.ShowDialog();

            }

            else
            {
                MessageBox.Show("Autenticação Falhou");
            }
        }
    }
}
