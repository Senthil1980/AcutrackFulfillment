using AcutrackFulfillment.Core.Entities;
using System;

namespace AcutrackFulfillment.Core.OrderAggregate
{
    public class ShippingInfo : AuditEntity
    {
        public ShippingInfo()
        {
            //this.Order_Item = new HashSet<Order_Item>();
            //this.Shipments = new HashSet<Shipment>();
            //this.Shippings = new HashSet<Shipping>();
        }

            
        public int AddressId { get; set; }
        public int ContactId { get; set; }
        public int CarrierServiceId { get; set; }
        public string AmazonShipmentId { get; set; }
        public bool SignatureConfirmation { get; set; } = false;
        public bool SaturdayDelivery { get; set; } = false;
        public string ShipDynamicId { get; set; }

      //  public  Address address { get; set; }
      //  public  CarrierService carrierService { get; set; }
      //  public  Contact Contact { get; set; }
        //public virtual Order Order { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Order_Item> Order_Item { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Shipment> Shipments { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Shipping> Shippings { get; set; }
    }
}