using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using AcutrackFulfillment.Core.Entities;
using AcutrackFulfillment.Core.OrderAggregate;

namespace AcutrackFulfillment.Core.Specifications
{
    public class OrderSearchSpecification : BaseSpecification<Order>
    {
        
        public OrderSearchSpecification(int skip, int take, int ClientGatewayId, String searchTerm) : 
            base(o => (o.ClientGatewayId == ClientGatewayId) 
            && (o.PONumber.Contains(searchTerm) 
            || o.orderStatus.Name.ToLower().Contains(searchTerm.ToLower()) 
            || o.OrderItems.Any(oi => oi.ProductId.ToString() == searchTerm)
            ))
        {
            //CacheKey = $"{searchTerm}-{skip}-{take}-{nameof(OrderSearchSpecification)}";
            CacheKey = $"{searchTerm}-{skip}-{take}-{nameof(OrderSearchSpecification)}";
            AddInclude(o => o.orderStatus);
            AddInclude(o => o.OrderItems);
            ApplyPaging(skip * take, take);
            ApplyOrderByDescending(o => o.Id);
        
           
        }
        public OrderSearchSpecification(int ClientGatewayId, String searchTerm) : 
            base(o => (o.ClientGatewayId == ClientGatewayId) && (o.PONumber.Contains(searchTerm) || o.orderStatus.Name.ToLower().Contains(searchTerm.ToLower())))
        {
            //CacheKey = $"{searchTerm}-{skip}-{take}-{nameof(OrderSearchSpecification)}";
            CacheKey = $"{searchTerm}-{nameof(OrderSearchSpecification)}";
            AddInclude(o => o.orderStatus); 
            if(searchTerm != string.Empty)
            {
                AddInclude(searchTerm);
            }
            ApplyOrderByDescending(o => o.Id);

        }

    }
}
