using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace com.Acutrack.Fulfillment.WebAPI
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            Product _product = new Product(id);
            return _product.Serialize();
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
            Product _product = new Product();
            _product.JsonDeserialize<Product>(value);
           // _product.Save("INSERT");
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
            Product _product = new Product();
            _product.JsonDeserialize<Product>(value);
            //_product.Save("UPDATE");
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Product _order = new Product(id);
           // _order.Save("DELETE");
        }
    }
}
