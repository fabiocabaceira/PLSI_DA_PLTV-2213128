using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinegest.Models
{
    public partial class Bilhete 
    {


        
        public int IdBilhete { get; set; }
        public string Lugar { get; set; }
        public string Estado { get; set; }
        public int FuncionarioIdPessoa { get; set; }
        public int ClienteIdPessoa { get; set; }
        public int SessãoIdSessao { get; set; }

        public virtual Pessoas_Funcionario Funcionario { get; set; }
        public virtual Pessoas_Cliente Cliente { get; set; }
        public virtual Sessão Sessão { get; set; }
    }
}
