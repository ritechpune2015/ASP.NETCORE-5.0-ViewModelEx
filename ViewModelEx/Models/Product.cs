using System;
using System.Collections.Generic;

namespace ViewModelEx.Models
{
    public class Product
    {
        public Int64    ProductID { get; set; }
        public string ProductName { get; set; }
        public string MfgName { get; set; }
        public decimal Price { get; set; }

        public Product()
        {
            this.ProductID = 1;
            this.ProductName = "Mouse";
            this.MfgName = "Logitech";
            this.Price = 450;

        }
    }
}
