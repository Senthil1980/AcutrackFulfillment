using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace com.Acutrack.Fulfillment.WebAPI.DTO
{
    public class ContactUpdateDto : ContactCreateDto
    {
        public int Id { get; set; }
    }
    public class ContactCreateDto
    {
        public string Company { get; set; }
        public string Department { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }      
    }
}
