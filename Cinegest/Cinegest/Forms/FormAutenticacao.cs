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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nomeFuncionario = funcionarioNometb.Text.ToString();
            var funcionarios = cinegest.Funcionarios.Where(b => b.Nome == nomeFuncionario);
            //bool autenticacao = funcionarios.Any();
            bool autenticacao = true;

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
