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
    
    public partial class Service
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Service()
        {
            this.Carrier_Service = new HashSet<Carrier_Service>();
        }
    
        public int id { get; set; }
        public string Name { get; set; }
        public int ShippingType_Id { get; set; }
        public Nullable<bool> TrackingAvailable { get; set; }
        public Nullable<decimal> InsuranceValue { get; set; }
        public string EstimatedDeliveryTime { get; set; }
        public string ChartOfAccountId { get; set; }
        public Nullable<int> PriorityLevel { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateModified { get; set; }
        public bool Enabled { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Carrier_Service> Carrier_Service { get; set; }
        public virtual Shipping_Type Shipping_Type { get; set; }
    }
}
