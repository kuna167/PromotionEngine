using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    class Product
    {
        public string _SKU { get; set; }
        public int _price { get; set; }
    }
    class ProductA : Product
    {
        public ProductA(string SKU)
        {
            _SKU = SKU;
            _price = 50;
        }
    }
    class ProductB : Product
    {
        public ProductB(string SKU)
        {
            _SKU = SKU;
            _price = 30;
        }
    }
    class ProductC : Product
    {
        public ProductC(string SKU)
        {
            _SKU = SKU;
            _price = 20;
        }
    }
    class ProductD : Product
    {
        public ProductD(string SKU)
        {
            _SKU = SKU;
            _price = 15;
        }
    }
}
