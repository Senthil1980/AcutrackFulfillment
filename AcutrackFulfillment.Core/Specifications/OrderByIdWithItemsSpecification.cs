using AcutrackFulfillment.Core.Entities;
using AcutrackFulfillment.Core.OrderAggregate;
using System.Collections.Generic;

namespace AcutrackFulfillment.Core.Specifications
{
    public class OrderByIdWithItemsSpecification : BaseSpecification<Order>
    {
        public OrderByIdWithItemsSpecification(int orderId) : base(o => o.Id == orderId)
        {
            AddInclude(o => o.OrderItems);
            AddInclude(o => o.ShippingInfos);

        }
    }
}
