using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinegest
{
    public partial class Pessoas_Cliente : Pessoa
    {
        public Pessoas_Cliente(string Nome, string Morada, int NumFiscal) 
        {
            this.Nome = Nome;
            this.Morada = Morada;
            this.Pessoas_Cliente.NumFiscal = NumFiscal;
        }    
    }
}
