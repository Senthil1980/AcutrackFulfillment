using AcutrackFulfillment.Core.Entities;
using AcutrackFulfillment.Core.OrderAggregate;
using System.Collections.Generic;

namespace AcutrackFulfillment.Core.Specifications
{
    public class GetDataByObjectIdSpecification : BaseSpecification<Filter>
    {
        public GetDataByObjectIdSpecification(int objectId) : base(f => f.Id == objectId)
        {
            //AddInclude(f => f.OrderItems);
           // AddInclude(o => o.ShippingInfos);

        }
    }
}
