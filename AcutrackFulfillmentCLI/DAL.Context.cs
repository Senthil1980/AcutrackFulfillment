﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace com.Acutrack.Fulfillment
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AcutrackEntities : DbContext
    {
        public AcutrackEntities()
            : base("name=AcutrackEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<Branding> Brandings { get; set; }
        public virtual DbSet<Bundle> Bundles { get; set; }
        public virtual DbSet<Carrier> Carriers { get; set; }
        public virtual DbSet<Carrier_Service> Carrier_Service { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Client_Gateway> Client_Gateway { get; set; }
        public virtual DbSet<Client_Shipping_Discount> Client_Shipping_Discount { get; set; }
        public virtual DbSet<Client_Shop> Client_Shop { get; set; }
        public virtual DbSet<ClientGateway_CarrierService> ClientGateway_CarrierService { get; set; }
        public virtual DbSet<ClientGateway_ShippingConfirmation> ClientGateway_ShippingConfirmation { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Company_Domain_Object> Company_Domain_Object { get; set; }
        public virtual DbSet<Company_Type> Company_Type { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Discount_Type> Discount_Type { get; set; }
        public virtual DbSet<Domain> Domains { get; set; }
        public virtual DbSet<Domain_Type> Domain_Type { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<Fee> Fees { get; set; }
        public virtual DbSet<Fee_Type> Fee_Type { get; set; }
        public virtual DbSet<Floor> Floors { get; set; }
        public virtual DbSet<Gateway> Gateways { get; set; }
        public virtual DbSet<Inventory> Inventories { get; set; }
        public virtual DbSet<Inventory_Location> Inventory_Location { get; set; }
        public virtual DbSet<InventoryTransaction_Log> InventoryTransaction_Log { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<Invoice_Details> Invoice_Details { get; set; }
        public virtual DbSet<Label_Status> Label_Status { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Order_Item> Order_Item { get; set; }
        public virtual DbSet<Order_Item_Location> Order_Item_Location { get; set; }
        public virtual DbSet<Order_Queue> Order_Queue { get; set; }
        public virtual DbSet<OrderProcessing_Type> OrderProcessing_Type { get; set; }
        public virtual DbSet<OrderStatu> OrderStatus { get; set; }
        public virtual DbSet<Pack_Discount> Pack_Discount { get; set; }
        public virtual DbSet<Package> Packages { get; set; }
        public virtual DbSet<Package_Item> Package_Item { get; set; }
        public virtual DbSet<Package_Shipment> Package_Shipment { get; set; }
        public virtual DbSet<Package_Shipping> Package_Shipping { get; set; }
        public virtual DbSet<PackageItem_Serialnumber> PackageItem_Serialnumber { get; set; }
        public virtual DbSet<Partner> Partners { get; set; }
        public virtual DbSet<Partner_Company> Partner_Company { get; set; }
        public virtual DbSet<Payment_Terms> Payment_Terms { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Product_Category> Product_Category { get; set; }
        public virtual DbSet<Product_CustomsDescription> Product_CustomsDescription { get; set; }
        public virtual DbSet<Product_SKU> Product_SKU { get; set; }
        public virtual DbSet<Product_Type> Product_Type { get; set; }
        public virtual DbSet<ProductAttribute> ProductAttributes { get; set; }
        public virtual DbSet<Reconcile_Type> Reconcile_Type { get; set; }
        public virtual DbSet<Return> Returns { get; set; }
        public virtual DbSet<Return_Action> Return_Action { get; set; }
        public virtual DbSet<Return_Condition> Return_Condition { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Role_Object> Role_Object { get; set; }
        public virtual DbSet<Secure_Object> Secure_Object { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<Shipment> Shipments { get; set; }
        public virtual DbSet<Shipping> Shippings { get; set; }
        public virtual DbSet<Shipping_Discount> Shipping_Discount { get; set; }
        public virtual DbSet<Shipping_Info> Shipping_Info { get; set; }
        public virtual DbSet<Shipping_Type> Shipping_Type { get; set; }
        public virtual DbSet<ShippingZone> ShippingZones { get; set; }
        public virtual DbSet<Sorting> Sortings { get; set; }
        public virtual DbSet<State> States { get; set; }
        public virtual DbSet<Stock> Stocks { get; set; }
        public virtual DbSet<Unit_Of_Measure> Unit_Of_Measure { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Warehouse> Warehouses { get; set; }
        public virtual DbSet<Action> Actions { get; set; }
        public virtual DbSet<Filter> Filters { get; set; }
    }
}
