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
    public partial class FormNovoFuncionario : Form
    {
        CineGestEntities5 cinegest;
        public FormNovoFuncionario()
        {
            cinegest = new CineGestEntities5();
            InitializeComponent();
        }

        private void FormNovoFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void adicionarbtn_Click(object sender, EventArgs e)
        {
            string nome = nomeFuncionariotb.Text;
            string morada = moradaFuncionariotb.Text;
            int salario = int.Parse(salarioFuncionariotb.Text);
            string funcao = funcaoFuncionariotb.Text;
            Funcionario novoFuncionario = new Funcionario(nome, morada, funcao, salario);
            cinegest.Pessoas.Add(novoFuncionario);
            cinegest.SaveChanges();
            
        }
    }
}
