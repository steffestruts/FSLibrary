//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace library
{
    using System;
    using System.Collections.Generic;
    
    public partial class Booking
    {
        public int Booking_Id { get; set; }
        public int Book_Id { get; set; }
        public int Borrowed_Id { get; set; }
        public int Library_Id { get; set; }
    
        public virtual Book Book { get; set; }
        public virtual Library Library { get; set; }
        public virtual Loan Loan { get; set; }
    }
}
