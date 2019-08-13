using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace com.Acutrack.Fulfillment.WebAPI.DTO
{
    public class AddressUpdateDto : AddressCreateDto
    {
        public int Id { get; set; }
    }
    public class AddressCreateDto
    {       


        public string StreetAddress1 { get; set; }
        public string StreetAddress2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Zip { get; set; }
    }
}
