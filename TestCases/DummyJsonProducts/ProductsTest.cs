using ECommerseApiAutomation.Models.DummyJsonProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Xunit;
namespace ECommerseApiAutomation.TestCases.DummyJsonProducts
{
    public class ProductsTest
    {

        public ProductsTest() 
        {
            new JsonSerializerOptions {PropertyNameCaseInsensitive = true};
        }
        [Fact]
        public async Task GetAllPRoducts()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://dummyjson.com/");
            var response = await client.GetAsync("Products");
            Assert.Equal(200, (double)response.StatusCode);
        }
        [Fact]
        public async Task CreateNewProduct()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://dummyjson.com/");
            var requestBody = new
            {
                title = "BMW Pencil"
                /* other product data */
            };
            var jsonPayload = JsonSerializer.Serialize(requestBody);
            var content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");

            var response = await client.PostAsync("products/add", content);
          
            var responsBody = await response.Content.ReadAsStringAsync();
            var jsonBdy = JsonSerializer.Deserialize<DummyProduct>(responsBody, 
                
                
            var discountProt = jsonBdy.Products
                .Where(id=> id.Id == 0).FirstOrDefault()
                .Se
                
                
                

  
          Assert.Equal(201, (double)response.StatusCode);
        }
        public async Task GetSingleProduct()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://dummyjson.com/");
            var response = await client.GetAsync("products/1");
            var responsBody = await response.Content.ReadAsStringAsync();
            var jsonBdy = JsonSerializer.Deserialize<DummyProduct>(responsBody,
                new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

            var discountProt = jsonBdy.Product.Id == 



          Assert.Equal(201, (double)response.StatusCode);
        }
    }
}
