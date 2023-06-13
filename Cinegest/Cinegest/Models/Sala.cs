using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinegest
{
    public partial class Sala
    {
     

        public Sala(int Colunas, int filas, int CinemaId, string Nome) 
        {
            this.Colunas = Colunas;
            this.Filas = filas;
            this.CinemaId = CinemaId;
            this.Nome = Nome;

        }   
    }
}
