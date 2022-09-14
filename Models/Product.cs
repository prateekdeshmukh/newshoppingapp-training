using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shopping.Client.Models
{
    
    //https://tinyurl.com/5xk5jfu2
    public class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string ImageFile { get; set; }
        public decimal Price { get; set; }
    }
}