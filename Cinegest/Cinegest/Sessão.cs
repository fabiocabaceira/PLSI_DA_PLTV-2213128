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
    
    public partial class Sessão
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sessão()
        {
            this.Bilhetes = new HashSet<Bilhete>();
        }
    
        public int IdSessao { get; set; }
        public System.DateTime DataHora { get; set; }
        public int Preco { get; set; }
        public int SalaIdSala { get; set; }
        public int Filme_IdFilme { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bilhete> Bilhetes { get; set; }
        public virtual Filme Filme { get; set; }
        public virtual Sala Sala { get; set; }
    }
}
