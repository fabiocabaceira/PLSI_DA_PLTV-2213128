using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinegest
{
    public partial class Cliente : Pessoa
    {
        public Cliente(string Nome, string Morada, int NumFiscal) 
        {
            this.Nome = Nome;
            this.Morada = Morada;
            this.NumFiscal = NumFiscal;
        }    
    }
}
