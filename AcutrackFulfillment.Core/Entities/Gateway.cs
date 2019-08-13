namespace AcutrackFulfillment.Core.Entities
{
    public class Gateway : AuditEntity
    {
        public Gateway()
        {
           // this.Client_Gateway = new HashSet<Client_Gateway>();
        }
               
        public string Name { get; set; }
        public string Template { get; set; }
        public string Url { get; set; }
        public string AppKey { get; set; }
        public string AppPassword { get; set; }
        public string MarketPlaceId { get; set; }
        public bool Enabled { get; set; }

   
        //public virtual ICollection<Client_Gateway> Client_Gateway { get; set; }
    }
}