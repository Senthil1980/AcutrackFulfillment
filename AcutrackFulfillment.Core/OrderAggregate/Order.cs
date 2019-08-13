using AcutrackFulfillment.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcutrackFulfillment.Core.OrderAggregate
{
    public class Order : AuditEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            /*this.Invoice_Details = new HashSet<Invoice_Details>();
            this.Order_Item = new HashSet<Order_Item>();
            this.Order_Queue = new HashSet<Order_Queue>();
            this.Returns = new HashSet<Return>();
            this.Shipping_Info = new HashSet<Shipping_Info>();*/
        }   
        public Nullable<System.Guid> Data_identifier { get; set; }
        public int ClientGatewayId { get; set; }
        public int OrderStatusId { get; set; } = 1;
        public OrderStatus orderStatus { get; set; }
    
        public bool Valid { get; set; } = true;
        public string PONumber { get; set; }
        public Nullable<int> ClientShopId { get; set; }
        public string AdditionalPONumber { get; set; }
        public int InvoiceId { get; set; }
        public bool FulFillFlag { get; set; } = true;
        public string UpdateStatusReason { get; set; }
        public int ShipmentConfirmation { get; set; } = 0;
        public Nullable<bool> UseShopAccount { get; set; }

        private readonly List<OrderItem> _orderItems = new List<OrderItem>();
        private readonly List<ShippingInfo> _shippingInfos = new List<ShippingInfo>();

        public IReadOnlyCollection<OrderItem> OrderItems => _orderItems.AsReadOnly();
        public IReadOnlyCollection<ShippingInfo> ShippingInfos => _shippingInfos.AsReadOnly();
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        /* 
         [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
         public virtual ICollection<Invoice_Details> Invoice_Details { get; set; }
         [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]       
         public virtual ICollection<Order_Queue> Order_Queue { get; set; } = new ICollection<Order_Queue>();     
         [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
         public virtual ICollection<Return> Returns { get; set; }
         [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
         public virtual ICollection<Shipping_Info> Shipping_Info { get; set; }*/

        public void AddItem(OrderItem newOrderItem)
        {
            _orderItems.Add(newOrderItem);
        }
        public void AddShippingInfo(ShippingInfo newShippingInfo)
        {
            _shippingInfos.Add(newShippingInfo);
        }

    }
}
