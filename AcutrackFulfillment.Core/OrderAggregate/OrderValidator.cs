using AcutrackFulfillment.Core.Interfaces;
using AcutrackFulfillment.Core.Specifications;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcutrackFulfillment.Core.OrderAggregate
{
    public class OrderValidator : AbstractValidator<Order>
    {
        private readonly IAsyncRepository<Order> _asyncOrderRepository;

        public OrderValidator(IAsyncRepository<Order> asyncOrderRepository)
        {
            _asyncOrderRepository = asyncOrderRepository;
            RuleFor(o => o).Must(BeUnique).WithMessage("PONumber must be unique");
        }

        private bool BeUnique(Order order)
        {
            var Spec = new OrderByPONumberSpecification(order.PONumber, order.ClientGatewayId);
            var count = _asyncOrderRepository.CountAsync(Spec).Result;
            if(count > 0)
            {
                return false;
            }
            return true;
        }
    }
}
