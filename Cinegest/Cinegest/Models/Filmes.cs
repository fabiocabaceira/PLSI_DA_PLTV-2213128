using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinegest.Models
{
    public partial class Filmes
    {
        public int IdFilme { get; set; }
        public string Nome { get; set; }
        public string Duracao { get; set; }
        public string Activo { get; set; }
        public int Categoria_IdCategoria { get; set; }

        public virtual Categorias Categorias { get; set; }
    }
}
