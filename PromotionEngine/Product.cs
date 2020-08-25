using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    class Product
    {
        public string ProductCode { get; set; }
        public int price { get; set; }
    }
    class ProductA : Product
    {
        public ProductA(string SKU)
        {
            ProductCode = SKU;
            price = 50;
        }
    }
    class ProductB : Product
    {
        public ProductB(string SKU)
        {
            ProductCode = SKU;
            price = 30;
        }
    }
    class ProductC : Product
    {
        public ProductC(string SKU)
        {
            ProductCode = SKU;
            price = 20;
        }
    }
    class ProductD : Product
    {
        public ProductD(string SKU)
        {
            ProductCode = SKU;
            price = 15;
        }
    }
}
