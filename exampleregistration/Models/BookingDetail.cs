//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace exampleregistration.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class BookingDetail
    {
        public int BookingId { get; set; }
        public double Prize { get; set; }
        public string PickupLoc { get; set; }
        public int CarId { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public int Billid { get; set; }
    
        public virtual BillingDetail BillingDetail { get; set; }
        public virtual Car Car { get; set; }
    }
}