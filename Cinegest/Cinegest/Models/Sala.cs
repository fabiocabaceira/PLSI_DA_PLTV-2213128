using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinegest.Models
{
    public partial class Sala
    {
        public int IdSala { get; set; }
        public string Nome { get; set; }
        public string Colunas { get; set; }
        public string Filas { get; set; }
        public int SessãoIdSessao { get; set; }
        public int? CinemaIdPessoa { get; set; }

        public virtual Sessão Sessão { get; set; }
        public virtual Cinema Cinemas { get; set; }
    }
}
