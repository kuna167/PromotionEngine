using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.Models
{
    public class Product
    {
        public string ProductCode { get; set; }
        public int price { get; set; }
    }
    public class ProductA : Product
    {
        public ProductA(string SKU)
        {
            ProductCode = SKU;
            price = 50;
        }
    }
    public class ProductB : Product
    {
        public ProductB(string SKU)
        {
            ProductCode = SKU;
            price = 30;
        }
    }
    public class ProductC : Product
    {
        public ProductC(string SKU)
        {
            ProductCode = SKU;
            price = 20;
        }
    }
    public class ProductD : Product
    {
        public ProductD(string SKU)
        {
            ProductCode = SKU;
            price = 15;
        }
    }
}
