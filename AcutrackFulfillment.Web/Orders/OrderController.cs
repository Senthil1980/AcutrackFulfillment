using System;
using System.Threading.Tasks;
using AcutrackFulfillment.Core.Interfaces;
using com.Acutrack.Fulfillment.WebAPI.Filters;
using Microsoft.AspNetCore.Mvc;
using AcutrackFulfillment.Core.Specifications;
using System.Linq;
using System.Collections.Generic;
using com.Acutrack.Fulfillment.WebAPI.Orders;
using AutoMapper;
using AcutrackFulfillment.Core.ReadModel;
using AcutrackFulfillment.Core;
using AcutrackFulfillment.Core.OrderAggregate;
using AcutrackFulfillment.Core.Entities;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace com.Acutrack.Fulfillment.WebAPI.Controllers
{

    [Route("api/[controller]/[action]")]
    //[Authorize(IdentityServerConstants.LocalApi.PolicyName)]
    [ApiController] 
    public class OrderController : Controller
    {

        private readonly IAsyncRepository<Order> _orderrepository;
        private readonly IAsyncRepository<Filter> _filterrepository;      
        private readonly IAsyncRepository<AcutrackFulfillment.Core.Entities.Action> _actionrepository;

        private readonly IMapper _mapper;
        private readonly IOrderSearchService _orderSearchService;

        public OrderController(IAsyncRepository<Order> orderrepository, 
            IAsyncRepository<Filter> filterRepository,
            IAsyncRepository<AcutrackFulfillment.Core.Entities.Action> actionRepository,
            IMapper mapper, IOrderSearchService orderSearchService)
        {
            _orderrepository = orderrepository;
            _filterrepository = filterRepository;
            _actionrepository = actionRepository;
            _mapper = mapper;
            _orderSearchService = orderSearchService;
        }
        [HttpGet]
        [NonAction]
        // [Permission(permissionEnum: Permission.View, resource: nameof(Order))]      
        public async Task<IActionResult> GetFilterActionSortingData(int ObjectId)
        {
            var orderFilterData = await _filterrepository.ListAllAsync();
            return Ok(orderFilterData);

        }
       
        // GET: api/<controller>
        [HttpGet]
       // [Permission(permissionEnum: Permission.View, resource: nameof(Order))]      
        public async Task<IActionResult> MyOrders()
        {          
           var orders = await _orderrepository.ListAllAsync();
            return Ok(orders);

        }
        [HttpGet("search/{skip}/{take}/{clientgatewayid}")]
        [Permission(permissionEnum: Permission.View, resource: nameof(Order))]
        public async Task<ActionResult<IEnumerable<OrderSearchResult>>> SearchOrders(int skip, int take, int clientgatewayid, string searchTerm)
        {
            var result = await _orderSearchService.SearchOrdersAsync(searchTerm);
            return Ok(result);

        }

        [HttpGet ("{skip}/{take}/{clientgatewayid}")]        
        [Permission(permissionEnum: Permission.View, resource: nameof(Order))]
        public async Task<IActionResult> GetOrders(int skip, int take, int clientgatewayid, string searchTerm)
        {
            if (searchTerm == null)
            {
                searchTerm = "";
            }
            var result = await _orderrepository.CountAsync(new OrderSearchSpecification(clientgatewayid,searchTerm));
            var orders = await _orderrepository.ListAsync(new OrderSearchSpecification(skip, take, clientgatewayid, searchTerm));
            Response.Headers.Add("X-Total-Count", result.ToString());
            return Ok(orders);

            
        }
        // GET api/<controller>/5
        [HttpGet("{id}")]
        [Permission(permissionEnum: Permission.View, resource: nameof(Order))]
        public async Task<IActionResult> Get(int id)
        {         
            try
            {
                var spec = new OrderByIdWithItemsSpecification(id);
                var order = (await _orderrepository.ListAsync(spec)).SingleOrDefault();
                if(order == null)
                {
                    return NotFound();
                }
                return Ok(order);
            }
            catch(Exception ex)
            {
                return NotFound();
            }
          
        }

        // POST api/<controller>
        [HttpPost]
        [Permission(permissionEnum: Permission.Create, resource: nameof(Order))]
        public async Task<IActionResult> Post([FromBody]OrderCreateDto newOrderDto)
        {
            var newOrder = _mapper.Map<Order>(newOrderDto);
            foreach(var item in newOrderDto.OrderItems)
            {
                newOrder.AddItem(_mapper.Map<OrderItem>(item));
            }
            var validator = new OrderValidator(_orderrepository);
            var result = validator.Validate(newOrder);
            if (result.IsValid)
            {
                await _orderrepository.AddAsync(newOrder);
                return Ok(newOrder);
            }
            return BadRequest(result.Errors);
        }

        //// PUT api/<controller>/5
        [HttpPut("{id}")]
        [Permission(permissionEnum: Permission.Modify, resource: nameof(Order))]
        public async Task<IActionResult> Put(int id, [FromBody]OrderUpdateDto exOrder)
        {
            try
            {
                var order = await _orderrepository.GetByIdAsync(id);
                order.OrderStatusId = exOrder.OrderStatusId;
                order.Valid = Convert.ToBoolean(exOrder.Valid);
                order.ShipmentConfirmation = exOrder.ShipmentConfirmation;
                order.UpdateStatusReason = exOrder.UpdateStatusReason;
                await _orderrepository.UpdateAsync(order);
                return Ok();
            }
            catch(Exception exUpdate)
            {
                return NotFound();
            }
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        [Permission(permissionEnum: Permission.Modify, resource: nameof(Order))]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var order = await _orderrepository.GetByIdAsync(id);
                await _orderrepository.DeleteAsync(order);
                return Ok();
            }
            catch(Exception exDel)
            {
                return NotFound();
            }
        }
    }
}
