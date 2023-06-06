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
            this.idSessao = idSessao;
            InitializeComponent();
        }

        private void FormAtendimento_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cineGestDataSet.Sessão' table. You can move, or remove it, as needed.
            this.sessãoTableAdapter.Fillu(this.cineGestDataSet.Sessão);
            Console.WriteLine(idSessao);
        }
    }
}
