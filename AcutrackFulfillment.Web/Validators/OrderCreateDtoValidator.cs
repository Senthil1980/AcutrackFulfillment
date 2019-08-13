using com.Acutrack.Fulfillment.WebAPI.Orders;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace com.Acutrack.Fulfillment.WebAPI.Validators
{
    public class OrderCreateDtoValidator : AbstractValidator<OrderCreateDto>
    {
        public OrderCreateDtoValidator()
        {
            RuleFor(o => o.ClientShopId).GreaterThan(0);
            RuleFor(o => o.ClientGatewayId).GreaterThan(0);
            RuleForEach(o => o.OrderItems).SetValidator(new OrderItemCreateDtoValidator());
        }
    }
}
