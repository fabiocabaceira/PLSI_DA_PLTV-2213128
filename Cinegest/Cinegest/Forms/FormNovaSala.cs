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
        int cinemaId = 1;
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
            try
            {
                if (string.IsNullOrWhiteSpace(salaNometb.Text))
                {
                    MessageBox.Show("Por favor, preencha o nome da sala.");
                    return;
                }
                if (!int.TryParse(salaColunastb.Text, out int colunas) || !int.TryParse(salaFilastb.Text, out int filas))
                {
                    MessageBox.Show("Por favor, preencha as colunas e as filas com números.");
                    return;
                }
                Cinema cinema = cinegest.Cinemas.ToList().FirstOrDefault(c => c.Id == cinemaId);
                if (cinema != null)
                {
                    Sala novaSala = new Sala(colunas, filas, cinemaId, salaNometb.Text);
                    cinegest.Salas.Add(novaSala);
                    cinegest.SaveChanges();
                    MessageBox.Show("Sala adicionada com sucesso.");
                }
                else
                {
                    MessageBox.Show("Tem de preencher primeiro os dados do Cinema");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}