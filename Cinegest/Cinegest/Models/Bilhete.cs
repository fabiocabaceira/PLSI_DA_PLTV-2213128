using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinegest
{
    public partial class Bilhete
    {
        public Bilhete(int lugar, string estado, int sessao_id, int funcionario_id, int cliente_id)
        {
            this.Lugar = lugar;
            this.Estado = estado;
            this.SessaoId = sessao_id;
            this.FuncionarioId = funcionario_id;
            this.ClienteId = cliente_id;
        }

        public Bilhete() { }    
    }
}