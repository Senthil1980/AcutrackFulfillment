using AcutrackFulfillment.Core.Entities;
using System;

namespace AcutrackFulfillment.Core.OrderAggregate
{
    public class OrderItem: AuditEntity
    {

        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public int StatusId { get; set; }       
        public int WarehouseId { get; set; }
        public int ProductSkuId { get; set; }
        public bool CopyProtection { get; set; } = false;
        public string BomId { get; set; }
        public string BomDynamicId { get; set; }     

    }
}
