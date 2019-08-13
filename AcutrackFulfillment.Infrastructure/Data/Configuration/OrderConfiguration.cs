using AcutrackFulfillment.Core.OrderAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AcutrackFulfillment.Infrastructure.Data.Configuration
{
    public class OrderConfiguration: IEntityTypeConfiguration<Order>
    {
       
        public void Configure(EntityTypeBuilder<Order> entitybuilder)
        {
            var navigation = entitybuilder.Metadata.FindNavigation(nameof(Order.OrderItems));
            navigation.SetPropertyAccessMode(PropertyAccessMode.Field);

            var ShipInfonavigation = entitybuilder.Metadata.FindNavigation(nameof(Order.ShippingInfos));
            ShipInfonavigation.SetPropertyAccessMode(PropertyAccessMode.Field);



        }
    }
}
