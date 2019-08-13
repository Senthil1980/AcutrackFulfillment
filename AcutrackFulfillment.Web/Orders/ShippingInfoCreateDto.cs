using com.Acutrack.Fulfillment.WebAPI.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace com.Acutrack.Fulfillment.WebAPI.Orders
{
    public class ShippingInfoCreateDto
    {
        [Required]
        public AddressCreateDto Address { get; set; }
        [Required]
        public ContactCreateDto Contact { get; set; }
        [Required]
        public int CarrierServiceId { get; set; }
        public string AmazonShipmentId { get; set; }
        public bool SignatureConfirmation { get; set; } = false;
        public bool SaturdayDelivery { get; set; } = false;
        public string ShipDynamicId { get; set; }
      
    }
}
