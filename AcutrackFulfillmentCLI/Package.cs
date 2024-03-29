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
    
    public partial class Package
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Package()
        {
            this.Package_Shipment = new HashSet<Package_Shipment>();
            this.Package_Shipping = new HashSet<Package_Shipping>();
            this.Package_Item = new HashSet<Package_Item>();
        }
    
        public int id { get; set; }
        public Nullable<System.DateTime> PackDate { get; set; }
        public int PackUser_Id { get; set; }
        public int Status_Id { get; set; }
        public int Box_id { get; set; }
        public Nullable<float> Weight { get; set; }
        public Nullable<int> Box_Sequence_Number { get; set; }
        public Nullable<double> TotalCustomsValue { get; set; }
        public System.DateTime DateCreated { get; set; }
        public Nullable<System.DateTime> DateModified { get; set; }
        public Nullable<bool> Enabled { get; set; }
    
        public virtual OrderStatu OrderStatu { get; set; }
        public virtual Product Product { get; set; }
        public virtual User User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Package_Shipment> Package_Shipment { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Package_Shipping> Package_Shipping { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Package_Item> Package_Item { get; set; }
    }
}
