namespace AcutrackFulfillment.Core.Entities
{
    public class OrderProcessingType : BaseEntity
    {
        public OrderProcessingType()
        {
           //this.Clients = new HashSet<Client>();
        }       
        public string Name { get; set; }
        public string Description { get; set; }       
       // public virtual ICollection<Client> Clients { get; set; }
    }
}