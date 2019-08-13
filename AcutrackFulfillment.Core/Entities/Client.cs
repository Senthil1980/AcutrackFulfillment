using System;

namespace AcutrackFulfillment.Core.Entities
{
    public class Client : AuditEntity
    {
        public Client()
        {
            //this.Bundles = new HashSet<Bundle>();
            //this.Client_Gateway = new HashSet<Client_Gateway>();
            //this.Client_Shipping_Discount = new HashSet<Client_Shipping_Discount>();
            //this.Client_Shop = new HashSet<Client_Shop>();
            //this.Fees = new HashSet<Fee>();
            //this.Invoices = new HashSet<Invoice>();
            //this.Invoice_Details = new HashSet<Invoice_Details>();
            //this.Products = new HashSet<Product>();
        }

        public string ServiceInterested { get; set; }
        public bool CreditHold { get; set; }
        public int OrderProcessingTypeId { get; set; }
        public bool FimsEnabled { get; set; }
        public int DomesticCarrierId { get; set; }
        public bool InvoiceApproval { get; set; }
        public Nullable<int> StaticServerId { get; set; }
        public Nullable<int> DynamicServerId { get; set; }
       // public OrderProcessingType orderProcessingType { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Bundle> Bundles { get; set; }
       
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Client_Gateway> Client_Gateway { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Client_Shipping_Discount> Client_Shipping_Discount { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Client_Shop> Client_Shop { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Fee> Fees { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Invoice> Invoices { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Invoice_Details> Invoice_Details { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Product> Products { get; set; }
    }
}