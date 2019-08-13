using System;

namespace AcutrackFulfillment.Core.Entities
{
    public class Invoice : AuditEntity
    {
        public Invoice()
        {
            //this.Invoice_Details = new HashSet<Invoice_Details>();
            //this.Orders = new HashSet<Order>();
        }
      
        public int ClientId { get; set; }
        public Nullable<int> TransactionMonth { get; set; }
        public Nullable<int> TransactionYear { get; set; }
        public Nullable<bool> Enabled { get; set; }
        public string AccountingRefNumber { get; set; }
        public string Message { get; set; }       
       // public  Client Client { get; set; }

        //public virtual ICollection<Invoice_Details> Invoice_Details { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Order> Orders { get; set; }
    }
}