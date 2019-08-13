using AcutrackFulfillment.Core.Entities;
using AcutrackFulfillment.Core.OrderAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcutrackFulfillment.Core.Specifications
{
    public class OrderFilterSpecification: BaseSpecification<Order>
    {
        public OrderFilterSpecification(int? id, String poNumber, int? Status_id, DateTime? _dateFrom, DateTime?_dateTo)
            : base(i => (!id.HasValue || i.Id == id) && (poNumber == string.Empty || i.PONumber == poNumber) && (!id.HasValue || i.OrderStatusId == Status_id) && (!_dateFrom.HasValue || i.DateCreated == _dateFrom) && (!_dateTo.HasValue || i.DateCreated == _dateTo))
        {

        }
        
    }
}
