using AcutrackFulfillment.Core.OrderAggregate;
using AcutrackFulfillmentRWS;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AcutrackFulfillment.FunctionalTests.Api
{
    public class OrderControllerPostOrder : IClassFixture<CustomWebApplicationFactory<Startup>>
    {
        public HttpClient Client { get; }
        public OrderControllerPostOrder(CustomWebApplicationFactory<Startup> factory)
        {
            Client = factory.CreateClient();

        }
        [Fact]
        public async Task FailsGivenEmptyPONumber()
        {
            var orderToPost = new
            {
                clientGatewayId = 1,
                valid = true,
                poNumber = "",
                clientShopId = 1,
                additionalPONumber = "string",
                useShopAccount = true
            };
            var jsonContent = new StringContent(JsonConvert.SerializeObject(orderToPost), Encoding.UTF8, "application/json");
            var response = await Client.PostAsync("/api/order/post", jsonContent);

            Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
            var stringResponse = await response.Content.ReadAsStringAsync();
            Assert.Contains("PONumber value Required", stringResponse);
         
           
        }
        [Fact]
        public async Task FailsGivenZeroClientGatewayId()
        {
            var orderToPost = new
            {
                clientGatewayId = 0,
                valid = true,
                poNumber = "589898",
                clientShopId = 1,
                additionalPONumber = "string",
                useShopAccount = true
            };
            var jsonContent = new StringContent(JsonConvert.SerializeObject(orderToPost), Encoding.UTF8, "application/json");
            var response = await Client.PostAsync("/api/order/post", jsonContent);

            Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
            var stringResponse = await response.Content.ReadAsStringAsync();
            Assert.Contains("'Client Gateway Id' must be greater than '0'.", stringResponse);


        }
    }
}
