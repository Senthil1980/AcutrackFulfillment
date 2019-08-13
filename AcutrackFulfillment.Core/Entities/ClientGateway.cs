using System;

namespace AcutrackFulfillment.Core.Entities
{
    public class ClientGateway : AuditEntity
    {
        public ClientGateway()
        {
            //this.ClientGateway_ShippingConfirmation = new HashSet<ClientGateway_ShippingConfirmation>();
            //this.ClientGateway_CarrierService = new HashSet<ClientGateway_CarrierService>();
            //this.Orders = new HashSet<Order>();
            //this.Product_SKU = new HashSet<Product_SKU>();
        }
            
        public Nullable<System.Guid> Data_identifier { get; set; }
        public int GatewayId { get; set; }
        public int ClientId { get; set; }
        public string GatewayUserId { get; set; }
        public string StoreKey { get; set; }
        public string AccessToken { get; set; }
        public string GatewayPassword { get; set; }
        public Nullable<int> OrderDownloadType { get; set; }
        public int OrderDownloadDays { get; set; }
        public string SecurityProtocol { get; set; }  
        public bool Enabled { get; set; }

       // public  Client client { get; set; }
        //public  Gateway gateway { get; set; }

        //public virtual ICollection<ClientGateway_ShippingConfirmation> ClientGateway_ShippingConfirmation { get; set; }  
        //public virtual ICollection<ClientGateway_CarrierService> ClientGateway_CarrierService { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Order> Orders { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Product_SKU> Product_SKU { get; set; }
    }
}