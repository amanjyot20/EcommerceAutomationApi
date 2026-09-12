using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ECommerseApiAutomation.Models.DummyJsonProduct
{
    public class Product
    {
        public int Id {  get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public double DiscountPercentage { get; set; }
        public double Rating { get; set; }
        public double Stock { get; set; }
        public List<string> Tags { get; set; }
        public string Brand { get; set; }
        public string Sku { get; set; }
        public Dimensions Dimensions { get; set; }
        public string warrantyInformation { get; set; }
        public string ShippingInformation { get; set; }

        public string AvailabilityStatus { get; set; }
        public Reviews Reviews { get; set; }
        public string ReturnPolicy { get; set; }
        public string MinimumOrderQuantity { get; set; }
        public Meta Meta { get; set; }
        public List<string> Images { get; set; }
        public string thumbnail { get; set; }

        

    }
}
