using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinegest.Models
{
    public partial class Sessão
    {

        public int IdSessao { get; set; }
        public DateTime DataHora { get; set; }
        public string Preco { get; set; }
        public int SalaIdSala { get; set; }
        public int Filme_IdFilme { get; set; }

        public virtual Salas Salas { get; set; }
        public virtual Filmes Filmes { get; set; }

    }
}
