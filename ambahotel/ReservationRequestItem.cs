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
    
    public partial class ReservationRequestItem
    {
        public int ID { get; set; }
        public int ReservationRoomID { get; set; }
        public int ItemID { get; set; }
        public int Qty { get; set; }
        public int TotalPrice { get; set; }
    
        public virtual Item Item { get; set; }
        public virtual ReservationRoom ReservationRoom { get; set; }
    }
}
