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
    
    public partial class Filme
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Filme()
        {
            this.Sessaos = new HashSet<Sessao>();
        }
    
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Duracao { get; set; }
        public string Activo { get; set; }
        public int CategoriaId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sessao> Sessaos { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
