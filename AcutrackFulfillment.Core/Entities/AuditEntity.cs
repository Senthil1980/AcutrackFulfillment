namespace AcutrackFulfillment.Core.Entities
{
    public class AuditEntity : BaseEntity
    {
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateModified { get; set; }
    }
}
