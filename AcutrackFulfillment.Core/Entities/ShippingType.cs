namespace AcutrackFulfillment.Core.Entities
{
    public class ShippingType : BaseEntity
    {
        public ShippingType()
        {
            //this.Services = new HashSet<Service>();
        }
              
        public string Name { get; set; }
        public string Description { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Service> Services { get; set; }
    }
}