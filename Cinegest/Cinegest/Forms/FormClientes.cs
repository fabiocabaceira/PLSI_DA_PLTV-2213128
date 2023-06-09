using Cinegest.Models;
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
    public partial class FormClientes : Form
    {

        CineGestEntities db;
        public FormClientes()
        {
            InitializeComponent();
            db = new CineGestEntities();
        }

        private void adicionarbtn_Click(object sender, EventArgs e)
        {
            string nome = nometb.Text;
            string morada = moradatb.Text;
            string numFiscal = numFiscaltb.Text;
            if (nome == "" || morada == "" || numFiscal == "")
            {
                MessageBox.Show("Tem de insirir todos os campos para poder adicionar um cliente");
            }
            else
            { 
                Pessoas_Cliente novocliente = new Pessoas_Cliente(nome, morada, numFiscal);
                db.Pessoas_Cliente.Add(novocliente);     
                db.SaveChanges();
            }

        }
    }
}
