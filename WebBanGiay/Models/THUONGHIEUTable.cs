//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebBanGiay.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class THUONGHIEUTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public THUONGHIEUTable()
        {
            this.GIAYTables = new HashSet<GIAYTable>();
        }
    
        public int MATHUONGHIEU { get; set; }
        public string TENTHUONGHIEU { get; set; }
        public string ANHTHUONGHIEU { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GIAYTable> GIAYTables { get; set; }
    }
}
