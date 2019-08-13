using AcutrackFulfillment.Core.OrderAggregate;

namespace AcutrackFulfillment.Core.Specifications
{
    public class OrderByPONumberSpecification : BaseSpecification<Order>
    {
        public OrderByPONumberSpecification(string ponumber,int clientgatewayId) : base(o => o.PONumber == ponumber && o.ClientGatewayId == clientgatewayId)
        {


        }
    }
}
