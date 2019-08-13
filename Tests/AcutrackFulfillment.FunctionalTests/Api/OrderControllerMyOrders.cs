using AcutrackFulfillment.Core.OrderAggregate;
using AcutrackFulfillmentRWS;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AcutrackFulfillment.FunctionalTests.Api
{
    public class OrderControllerMyOrders : IClassFixture<CustomWebApplicationFactory<Startup>>
    {
        public HttpClient Client { get; }
        public OrderControllerMyOrders(CustomWebApplicationFactory<Startup> factory)
        {
            Client = factory.CreateClient();

        }
        [Fact]
        public async Task ReturnFourOrders()
        {
            var response = await Client.GetAsync("/api/order/MyOrders");
            response.EnsureSuccessStatusCode();
            var stringresponse = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<List<Order>>(stringresponse);

            Assert.Equal(5, result.Count);
        }
    }
}
