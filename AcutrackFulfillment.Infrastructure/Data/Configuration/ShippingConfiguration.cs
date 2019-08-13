using AcutrackFulfillment.Core.Entities;
using AcutrackFulfillment.Core.OrderAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcutrackFulfillment.Infrastructure.Data.Configuration
{
    public class ShippingConfiguration
    {
        public void Configure(EntityTypeBuilder<ShippingInfo> entitybuilder)
        {
            // var navigation = entitybuilder.Metadata.FindNavigation(nameof(ShippingInfo.address));
            //navigation.SetPropertyAccessMode(PropertyAccessMode.Field);

            //For multiple foreign table access -- verification needed
            // var navigation2 = entitybuilder.Metadata.FindNavigation(nameof(ShippingInfo.carrierService));
            //navigation2.SetPropertyAccessMode(PropertyAccessMode.Field);

            // var navigation3 = entitybuilder.Metadata.FindNavigation(nameof(ShippingInfo.Contact));
            // navigation3.SetPropertyAccessMode(PropertyAccessMode.Field);

            entitybuilder.Property(os => os.AmazonShipmentId)
               .HasMaxLength(50);
            entitybuilder.Property(os => os.ShipDynamicId)
                .HasMaxLength(50);
               
        }
    }
}
