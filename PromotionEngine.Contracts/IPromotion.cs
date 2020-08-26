using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.Contracts
{
    public interface IPromotion
    {
        int Calculate(int NoOfItems, int promopairs, int remainitems);
    }
}
