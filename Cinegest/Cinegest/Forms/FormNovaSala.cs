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
    public partial class FormNovaSala : Form
    {
        CineGestEntities5 cinegest;
        int cinemaId;
        public FormNovaSala(int cinemaid)
        {
            this.cinemaId = cinemaid;
            cinegest = new CineGestEntities5();
            InitializeComponent();
        }

        private void FormNovaSala_Load(object sender, EventArgs e)
        {

        }

        private void adicionarSalabtn_Click(object sender, EventArgs e)
        {
            string nome = salaNometb.Text;
            int colunas = int.Parse(salaColunastb.Text);
            int filas = int.Parse(salaFilastb.Text);
            Sala novaSala = new Sala(colunas, filas, cinemaId, nome);
            cinegest.Salas.Add(novaSala);
            cinegest.SaveChanges();
        }
    }

}