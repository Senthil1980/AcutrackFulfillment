namespace AcutrackFulfillment.Core.Entities
{
    public class ClientShop : AuditEntity
    {
        public ClientShop()
        {
            //this.Orders = new HashSet<Order>();
        }
    
        public string Name { get; set; }
        public int ClientId { get; set; }     
       // public  Client Client { get; set; }
     
       // public virtual ICollection<Order> Orders { get; set; }
    }
}