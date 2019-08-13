namespace AcutrackFulfillment.Core.Entities
{
    public class Address : AuditEntity
    {

        public Address()
        {
            //this.Companies = new HashSet<Company>();
            //this.Shipping_Info = new HashSet<Shipping_Info>();
            //this.Warehouses = new HashSet<Warehouse>();
        }
               
        public string StreetAddress1 { get; set; }
        public string StreetAddress2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Zip { get; set; }
        public bool IsValidated { get; set; }
        public bool LabelPrinted { get; set; }   

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Company> Companies { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Shipping_Info> Shipping_Info { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Warehouse> Warehouses { get; set; }
    }
}