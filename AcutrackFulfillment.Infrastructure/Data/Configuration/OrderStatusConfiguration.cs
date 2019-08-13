using AcutrackFulfillment.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcutrackFulfillment.Infrastructure.Data.Configuration
{
    public class OrderStatusConfiguration: IEntityTypeConfiguration<OrderStatus>
    {  
        public void Configure(EntityTypeBuilder<OrderStatus> builder)
        {
            builder.Property(os => os.Description)
                 .HasMaxLength(250);
            builder.Property(os => os.Name)
                .HasMaxLength(50)
                .IsRequired();
        }
    }
}
