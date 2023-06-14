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
    public partial class FormFuncionarios : Form
    {
        public FormFuncionarios()
        {
            InitializeComponent();
        }

        private void FormFuncionarios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cineGestDataSet.Filmes' table. You can move, or remove it, as needed.
            this.filmesTableAdapter.Fill(this.cineGestDataSet.Filmes);

        }
    }
}
