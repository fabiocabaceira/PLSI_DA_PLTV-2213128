using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinegest
{
    public partial class Filme
    {
        public Filme( string nome, string duracao, string activo, Categoria categoria)
        {
            
            Nome = nome;
            Duracao = duracao;
            Activo = activo;
            Categoria = categoria;
        }
    }
}
