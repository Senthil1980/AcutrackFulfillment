using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace com.Acutrack.Fulfillment.WebAPI.Controllers
{
    public class OrderUpdateDto
    {
        public int OrderStatusId { get; set; }
        public Nullable<bool> Valid { get; set; }
        public int InvoiceId { get; set; }
        public string UpdateStatusReason { get; set; }
        public int ShipmentConfirmation { get; set; }
    }
}
