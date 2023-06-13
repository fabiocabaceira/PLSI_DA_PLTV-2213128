using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinegest
{
    public partial class Funcionario : Pessoa
    {
        public Funcionario(string Nome, string Morada, string Funcao, int Salario)
        {
            this.Nome = Nome;
            this.Morada = Morada;
            this.Funcao = Funcao;
            this.Salario = Salario;

            
        }
    }
}
