using ECommerseApiAutomation.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ECommerseApiAutomation.Utilities
{
    public class CartHttpClient
    {
        private static HttpClient _client;
        public CartHttpClient() 
        {
            _client = new HttpClient() ;
            _client.BaseAddress = new Uri(UrlConstants.baseUrl);
        }
        public async Task<HttpResponseMessage> GetHttpClient(string route)
        {                    
            var product = await _client.GetAsync(route);
            return product;
        }
        public async Task<HttpResponseMessage> GetOneProductHttpClient(string route)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(UrlConstants.baseUrl);
            var product = await client.GetAsync(route);
            return product;
        }
        public async Task<HttpResponseMessage> CreateProductHttpClient(string route)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(UrlConstants.baseUrl);
            var requestBody = new
            {
                title = "BMW Pencil"

            };
            var serialisebody = JsonSerializer.Serialize(requestBody);
            var headersContent =  new StringContent (serialisebody, Encoding.UTF8,"application/json");
            var product = await client.PostAsync(route, headersContent);
            return product;
        }

    }
}
