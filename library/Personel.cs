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
    
    public partial class Personel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Personel()
        {
            this.TimeTables = new HashSet<TimeTable>();
        }
    
        public int Personel_Id { get; set; }
        public string Personel_Name { get; set; }
        public string Personel_Address { get; set; }
        public string Personel_Phone_Home { get; set; }
        public string Personel_Phone_Mobile { get; set; }
        public int Library_Id { get; set; }
        public byte Personel_Employing { get; set; }
        public int Personel_Salary { get; set; }
        public int Position_Id { get; set; }
    
        public virtual Library Library { get; set; }
        public virtual Position Position { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TimeTable> TimeTables { get; set; }
    }
}
