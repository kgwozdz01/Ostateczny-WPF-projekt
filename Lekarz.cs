//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ostateczny_WPF_projekt
{
    using System;
    using System.Collections.Generic;
    
    public partial class Lekarz
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Lekarz()
        {
            this.TerminyUmowione = new HashSet<TerminyUmowione>();
        }
    
        public int ID_lekarza { get; set; }
        public string imie_lekarza { get; set; }
        public string nazwisko_lekarza { get; set; }
        public string specjalizacja { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TerminyUmowione> TerminyUmowione { get; set; }
    }
}
