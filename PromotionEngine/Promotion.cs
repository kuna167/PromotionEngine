using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    interface IPromotion
    {
        int Calculate(int NoOfItems, int promopairs, int remainitems);
    }
    interface IPromotionCD
    {
        int Calculate(int NoOfItemsC, int NoOfItemsD, int promopairs, int remainitemsC, int remainitemsD);
    }
    class PromotionA:IPromotion
    {
        Product prodA = new ProductA("A");
        public int Calculate(int NoOfItems, int promopairs, int remainitems)
        {
            int totalA = (promopairs * 130) + (remainitems * prodA._price);
            Console.WriteLine("{0} * A {1}", NoOfItems, totalA);
            return totalA;
        }
    }
    class PromotionB : IPromotion
    {
        Product prodB = new ProductA("B");        
        public int Calculate(int NoOfItems, int promopairs, int remainitems)
        {
            int totalB = (promopairs * 45) + (remainitems * prodB._price);
            Console.WriteLine("{0} * B {1}", NoOfItems, totalB);
            return totalB;
        }
    }
    class PromotionCD : IPromotionCD
    {
        Product prodC = new ProductC("C");
        Product prodD = new ProductD("D");

        public int Calculate(int NoOfItemsC, int NoOfItemsD, int promopairs, int remainitemsC, int remainitemsD)
        {
            int totalCD = 0;
            Console.WriteLine("{0} * C {1}", NoOfItemsC, remainitemsC * prodC._price);
            Console.WriteLine("{0} * D {1}", NoOfItemsD, (promopairs * 30) + (remainitemsC * prodD._price));
            totalCD = (remainitemsC * prodC._price) + (promopairs * 30) + (remainitemsC * prodD._price);
            return totalCD;
        }
    }
}
