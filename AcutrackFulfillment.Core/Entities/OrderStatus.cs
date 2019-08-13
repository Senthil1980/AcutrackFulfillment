using System;
using System.Collections.Generic;
using System.Text;

namespace AcutrackFulfillment.Core.Entities
{
    public class OrderStatus: BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
