using System;
using System.Collections.Generic;
using System.Text;
using PromotionEngine.Models;

namespace PromotionEngine.Contracts
{
    public interface ICart
    {
        int DisplayTotalAmountwithProducts();
        void AddProducttoCart(Product Prod);
    }
}
