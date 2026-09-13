using ECommerseApiAutomation.Models.DummyJsonProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Xunit;
using ECommerseApiAutomation.Utilities;
namespace ECommerseApiAutomation.TestCases.DummyJsonProducts
{
    public class ProductsTest
    {
        private static JsonSerializerOptions _JsonOptions;
        private static CartHttpClient _cartHttpClient;
        public ProductsTest() 
        {
            _cartHttpClient = new CartHttpClient();
            _JsonOptions = new JsonSerializerOptions {PropertyNameCaseInsensitive = true};
        }
        [Fact]

        public async Task GetAllPRoducts()
        {
            //Arrange
            string expectedTitle = "Essence Mascara Lash Princess";
            //Act
            var response = await _cartHttpClient.GetHttpClient("Products");
            var responseString = await response.Content.ReadAsStringAsync();
            var responseBody = JsonSerializer.Deserialize<DummyProduct>(responseString, _JsonOptions);
            var actualTitle = responseBody.Products
                .Where(p => p.Id == 1)
                .Select(c => c.Title).FirstOrDefault();
            //Assertion
            Assert.Equal(200, (double)response.StatusCode);
            Assert.Equal(expectedTitle, actualTitle);

        }
        [Fact]
        public async Task CreateNewProduct()
        {
            int ids = 195;
            var response = await _cartHttpClient.CreateProductHttpClient("Products/add");
            var responseString = await response.Content.ReadAsStringAsync();

            //
            var responseBody = JsonSerializer.Deserialize<Product>(responseString, _JsonOptions);      
           // Assert.Equal(201, (double)response.StatusCode);
           // var actualId = responseBody.Id;
                
           // Assert.Equal(ids, actualId);
        }
        public async Task GetSingleProduct()
       {
            string expectedBrand = "Essence";
            var response = await _cartHttpClient.GetHttpClient("Products/1");
            var responseString = await response.Content.ReadAsStringAsync();
            var responseBody = JsonSerializer.Deserialize<DummyProduct>(responseString, _JsonOptions);
            var actualBrand= responseBody.Products
                .Where(p => p.Id == 1)
                .Select(c => c.Brand).FirstOrDefault();
            //Assertion
            Assert.Equal(200, (double)response.StatusCode);
            Assert.Equal(expectedBrand, actualBrand);

        }

        public async Task SearchProduct()
        {
            string expectedBrand = "Essence";
            var response = await _cartHttpClient.GetHttpClient("products/search?q=phone");
            var responseString = await response.Content.ReadAsStringAsync();
            var responseBody = JsonSerializer.Deserialize<DummyProduct>(responseString, _JsonOptions);
            var actualBrand = responseBody.Products
                .Where(p => p.Id == 1)
                .Select(c => c.Brand).FirstOrDefault();
            //Assertion
            Assert.Equal(200, (double)response.StatusCode);
            Assert.Equal(expectedBrand, actualBrand);

        }
       
    }
}
