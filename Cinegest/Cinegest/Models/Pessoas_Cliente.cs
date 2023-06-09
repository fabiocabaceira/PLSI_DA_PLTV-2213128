using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinegest.Models
{
    public partial class Pessoas_Cliente : Pessoa
    {
        public string NumFiscal { get; set; }

        public Pessoas_Cliente(string nome, string morada, string numFiscal)
        {
            this.Nome = nome;   
            this.Morada = morada;
            this.NumFiscal = numFiscal;              
        }

        
    }
}
