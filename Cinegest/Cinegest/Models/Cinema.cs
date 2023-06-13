using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Cinegest
{
    public partial class Cinema
    {


        public Cinema(string Nome, string Email, string Morada)
        { 
            this.Nome = Nome;
            this.Email = Email;
            this.Morada = Morada;
            this.Salas = new HashSet<Sala>();

        }
        
    }
}
