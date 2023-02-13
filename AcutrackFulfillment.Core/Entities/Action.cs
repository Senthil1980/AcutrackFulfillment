using System;
using System.Collections.Generic;
using System.Text;

namespace AcutrackFulfillment.Core.Entities
{
    public class Action : AuditEntity
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string FieldName { get; set; }
        public int Object_Id { get; set; }
        public bool Enabled { get; set; }
        public bool IsActive { get; set; }
      
    }
}
