//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ambahotel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cleaning_Room
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cleaning_Room()
        {
            this.CleaningRoomDetails = new HashSet<CleaningRoomDetail>();
        }
    
        public int ID { get; set; }
        public System.DateTime Date { get; set; }
        public int EmployeeID { get; set; }
    
        public virtual Employee Employee { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CleaningRoomDetail> CleaningRoomDetails { get; set; }
    }
}