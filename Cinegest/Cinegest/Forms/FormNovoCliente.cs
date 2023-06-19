using Cinegest;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinegest.Forms
{
    public partial class FormNovoCliente : Form
    {

        CineGestEntities5 db;
        public FormNovoCliente()
        {
            InitializeComponent();
            db = new CineGestEntities5();
        }

        private void adicionarbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = nometb.Text;
                string morada = moradatb.Text;
                int numFiscal = 0;

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
