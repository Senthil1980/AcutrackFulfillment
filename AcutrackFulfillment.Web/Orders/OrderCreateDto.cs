using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace com.Acutrack.Fulfillment.WebAPI.Orders
{
    public class OrderCreateDto
    {

        [Required]
        public int ClientGatewayId { get; set; }
        [Required]
        public bool Valid { get; set; } = true;
        [Required(AllowEmptyStrings = false, ErrorMessage = "PONumber value Required")]
        public string PONumber { get; set; }
        public Nullable<int> ClientShopId { get; set; }
        public string AdditionalPONumber { get; set; }
        public Nullable<bool> UseShopAccount { get; set; }
        [Required]
        public List<OrderItemCreateDto> OrderItems { get; set; } = new List<OrderItemCreateDto>();
        [Required]
        public List<ShippingInfoCreateDto> ShipingInfos { get; set; } = new List<ShippingInfoCreateDto>();
    }
}
