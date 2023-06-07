using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinegest.Models
{
    public partial class Pessoas_Funcionario : Pessoa
    {
        public string Salario { get; set; }
        public string Funcao { get; set; }
    }
}
