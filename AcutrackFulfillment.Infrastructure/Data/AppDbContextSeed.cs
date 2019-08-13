using AcutrackFulfillment.Core.Entities;
using AcutrackFulfillment.Core.OrderAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcutrackFulfillment.Infrastructure.Data
{
    public class AppDbContextSeed
    {
        public static async Task SeedAsync(AppDbContext context)
        {
            if (!context.OrderStatuses.Any())
            {
                context.OrderStatuses.Add(new OrderStatus() { Name = "Open", Description = "New Order" });
                context.OrderStatuses.Add(new OrderStatus() { Name = "Hold", Description = "Hold Order" });
                context.OrderStatuses.Add(new OrderStatus() { Name = "Cancel", Description = "Cancel Order" });
                context.OrderStatuses.Add(new OrderStatus() { Name = "Fulfilled", Description = "Fulfilled Order" });
                context.OrderStatuses.Add(new OrderStatus() { Name = "Inprocess", Description = "Inprocess Order" });
                context.OrderStatuses.Add(new OrderStatus() { Name = "Completed", Description = "Completed Order" });
                await context.SaveChangesAsync();
            }
            if (!context.Orders.Any())
            {
                var firstOrder = new Order() { PONumber = "123456", OrderStatusId = 1 };
                firstOrder.AddItem(new OrderItem() { ProductSkuId = 1, Quantity = 2, ProductId = 1 });
                firstOrder.AddItem(new OrderItem() { ProductSkuId = 2, Quantity = 3, ProductId = 2});
                firstOrder.AddShippingInfo(new ShippingInfo() { AddressId = 1, AmazonShipmentId = "1", ContactId = 1 });
                context.Orders.Add(firstOrder);
                context.Orders.Add(new Order() { PONumber = "123457", OrderStatusId = 2 });
                context.Orders.Add(new Order() { PONumber = "654321", OrderStatusId = 3 });
                context.Orders.Add(new Order() { PONumber = "654322", OrderStatusId = 1 });
                context.Orders.Add(new Order() { PONumber = "6543221", OrderStatusId = 1 });


                await context.SaveChangesAsync();
            }


        }

    }
}
