namespace AcutrackFulfillment.Core.Entities
{
    public class Carrier : AuditEntity
    {
        
        public Carrier()
        {
            //this.Carrier_Service = new HashSet<Carrier_Service>();
        }
   
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Enabled { get; set; } 
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Carrier_Service> Carrier_Service { get; set; }
    }
}