using AcutrackFulfillment.Infrastructure.Data.Configuration;
using Microsoft.EntityFrameworkCore;
using Ardalis.EFCore.Extensions;
using AcutrackFulfillment.Core.OrderAggregate;
using AcutrackFulfillment.Core.ReadModel;
using AcutrackFulfillment.Core.Entities;

namespace AcutrackFulfillment.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }
        public DbSet<Order> Orders{get; set;}
        public DbSet<OrderStatus> OrderStatuses{get; set;}

        public DbSet<Filter> Filters { get; set; }

        public DbSet<Action> Actions { get; set; }

        public DbQuery<OrderSearchResult> OrderSearchResults { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //TODO:UseReflection to get all configuration          
            modelBuilder.ApplyAllConfigurationsFromCurrentAssembly(typeof(OrderConfiguration).Assembly);
            //modelBuilder.ApplyAllConfigurationsFromCurrentAssembly(typeof(ShippingConfiguration).Assembly);

        }

    }

}
