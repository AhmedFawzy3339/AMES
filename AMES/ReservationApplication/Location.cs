//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ReservationApplication
{
    using System;
    using System.Collections.Generic;
    
    public partial class Location
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Location()
        {
            this.Guests = new HashSet<Guest>();
        }
    
        public int LocationID { get; set; }
        public string Location_Name { get; set; }
        public string Location_Address { get; set; }
        public Nullable<double> Location_Price { get; set; }
        public Nullable<int> Location_IS_Reserved { get; set; }
        public string Location_Images { get; set; }
        public Nullable<int> User_ID { get; set; }
        public Nullable<int> Admin_ID { get; set; }
        public Nullable<int> Guest_ID { get; set; }
        public string City { get; set; }
        public Nullable<int> imgNumber { get; set; }
    
        public virtual Admin Admin { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Guest> Guests { get; set; }
    }
}
