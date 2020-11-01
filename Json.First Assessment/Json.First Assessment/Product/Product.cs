using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Json.First_Assessment.Product
{
   public class Product
    {
        public string OrderId { get; set; }
        public string CreatedAt { get; set; }
        public string CustomerId { get; set; }
        public string LineItems { get; set; }
    }
}
