//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cinegest
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Morada { get; set; }
    
        public virtual Pessoas_Cliente Pessoas_Cliente { get; set; }
        public virtual Pessoas_Funcionario Pessoas_Funcionario { get; set; }
    }
}
