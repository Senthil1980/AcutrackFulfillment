//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace com.Acutrack.Fulfillment
{
    using System;
    using System.Collections.Generic;
    
    public partial class Stock
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Stock()
        {
            this.Inventory_Location = new HashSet<Inventory_Location>();
        }
    
        public int id { get; set; }
        public Nullable<System.Guid> Data_identifier { get; set; }
        public Nullable<int> SupplierLotNo { get; set; }
        public int Product_Id { get; set; }
        public System.DateTime ReceivedDate { get; set; }
        public System.DateTime DateCreated { get; set; }
        public Nullable<int> ReceivedQty { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Inventory_Location> Inventory_Location { get; set; }
        public virtual Product Product { get; set; }
    }
}