using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.Contracts
{
    public interface IPromotionCD
    {
        int Calculate(int NoOfItemsC, int NoOfItemsD, int promopairs, int remainitemsC, int remainitemsD);
    }
}
