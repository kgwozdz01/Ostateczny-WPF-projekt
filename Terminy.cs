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
    
    public partial class Terminy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Terminy()
        {
            this.TerminyUmowione = new HashSet<TerminyUmowione>();
        }
    
        public int ID_terminu { get; set; }
        public System.DateTime termin { get; set; }
        public string czy_wolne { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TerminyUmowione> TerminyUmowione { get; set; }
    }
}