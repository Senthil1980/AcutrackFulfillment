using System;

namespace AcutrackFulfillment.Core.Entities
{
    public class Service : AuditEntity
    {
        public Service()
        {
            //this.Carrier_Service = new HashSet<Carrier_Service>();
        }

    
        public string Name { get; set; }
        public int ShippingTypeId { get; set; }
        public Nullable<bool> TrackingAvailable { get; set; }
        public Nullable<decimal> InsuranceValue { get; set; }
        public string EstimatedDeliveryTime { get; set; }
        public string ChartOfAccountId { get; set; }
        public Nullable<int> PriorityLevel { get; set; }    
        public bool Enabled { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Carrier_Service> Carrier_Service { get; set; }
       // public  ShippingType shippingType { get; set; }
    }
}