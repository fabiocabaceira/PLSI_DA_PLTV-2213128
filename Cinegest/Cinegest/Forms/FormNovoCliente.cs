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
            string nome = nometb.Text;
            string morada = moradatb.Text;
            int numFiscal = int.Parse(numFiscaltb.Text);
            if (nome == "" || morada == "" )
            {
                MessageBox.Show("Tem de insirir todos os campos para poder adicionar um cliente");
            }
            else
            { 
                Cliente novocliente = new Cliente(nome, morada, numFiscal);
                db.Pessoas.Add(novocliente);     
                db.SaveChanges();
            }

        }

        private void FormClientes_Load(object sender, EventArgs e)
        {

        }
    }
}
