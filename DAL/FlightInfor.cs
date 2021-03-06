//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class FlightInfor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FlightInfor()
        {
            this.files = new HashSet<file>();
            this.Information = new HashSet<Information>();
        }
    
        public int Id { get; set; }
        public Nullable<int> IdUser { get; set; }
        public string UserName { get; set; }
        public int From { get; set; }
        public int ToPlice { get; set; }
        public string TZUser { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime BackDate { get; set; }
        public int Dates { get; set; }
    
        public virtual Country Country { get; set; }
        public virtual Country Country1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<file> files { get; set; }
        public virtual User User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Information> Information { get; set; }
    }
}
