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
    
    public partial class Pessoas_Funcionario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pessoas_Funcionario()
        {
            this.Bilhetes = new HashSet<Bilhete>();
        }
    
        public int Salario { get; set; }
        public string Funcao { get; set; }
        public int Id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bilhete> Bilhetes { get; set; }
        public virtual Pessoa Pessoa { get; set; }
    }
}
