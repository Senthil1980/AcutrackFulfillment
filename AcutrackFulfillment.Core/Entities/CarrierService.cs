namespace AcutrackFulfillment.Core.Entities
{
    public class CarrierService : AuditEntity
    {
        public CarrierService()
        {
            //this.ClientGateway_CarrierService = new HashSet<ClientGateway_CarrierService>();
            //this.Shipping_Discount = new HashSet<Shipping_Discount>();
            //this.Shipping_Info = new HashSet<Shipping_Info>();
            //this.Shippings = new HashSet<Shipping>();
        }

     
        public int CarrierId { get; set; }
        public int ServiceId { get; set; }
        public bool IsDomestic { get; set; }     
        public bool Enabled { get; set; }
       // public  Carrier Carrier { get; set; }
       // public  Service Service { get; set; }
       // [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<ClientGateway_CarrierService> ClientGateway_CarrierService { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Shipping_Discount> Shipping_Discount { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Shipping_Info> Shipping_Info { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Shipping> Shippings { get; set; }
    }
}