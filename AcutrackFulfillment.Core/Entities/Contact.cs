namespace AcutrackFulfillment.Core.Entities
{
    public class Contact : AuditEntity
    {

        public Contact()
        {
            //this.Companies = new HashSet<Company>();
            //this.Shipping_Info = new HashSet<Shipping_Info>();
        }
     
        public string Company { get; set; }
        public string Department { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public bool Enabled { get; set; }   

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Company> Companies { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Shipping_Info> Shipping_Info { get; set; }
    }
}