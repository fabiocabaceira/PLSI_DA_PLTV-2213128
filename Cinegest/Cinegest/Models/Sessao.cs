using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinegest
{
    public partial class Sessao
    {
        public Sessao(int SalaId, System.DateTime Datahora, int Preco, int Filme_Id)
        { 
            this.SalaId = SalaId;
            this.Datahora = Datahora;
            this.Preco = Preco;
            this.Filme_Id = Filme_Id;
        }
    }
}
