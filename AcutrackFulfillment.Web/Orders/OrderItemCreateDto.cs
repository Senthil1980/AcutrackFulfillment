using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace com.Acutrack.Fulfillment.WebAPI.Orders
{
    public class OrderItemCreateDto
    {
        [Required]
        public int ProductId { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be greater than 0")]
        public int Quantity { get; set; }
        public int StatusId { get; set; }
        [Required]
        //public int ProductSkuId { get; set; }
        public bool CopyProtection { get; set; } = false;
        
        public string BomId { get; set; }
        public string BomDynamicId { get; set; }
        //public virtual Order Order { get; set; }
       
    }
}
