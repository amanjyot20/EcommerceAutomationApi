using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerseApiAutomation.Models.DummyJsonProduct
{
    public class DummyProduct
    {
        public List<Product> Products { get; set; }
        public string Total { get; set; }
        public string Skip { get; set; }
        public string Limit { get; set; }
    }
}
