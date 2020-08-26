using System;
using System.Collections.Generic;
using System.Text;
using PromotionEngine.Models;
using PromotionEngine.Contracts;

namespace PromotionEngine.BusinessLogic
{
    public class PromotionA:IPromotion
    {

        public PromotionA()
        {

        }
        Product prodA = new ProductA("A");
        public int Calculate(int NoOfItems, int promopairs, int remainitems)
        {
            int totalA = (promopairs * 130) + (remainitems * prodA.price);
            Console.WriteLine("{0} * A {1}", NoOfItems, totalA);
            return totalA;
        }
    }
    public class PromotionB : IPromotion
    {
        Product prodB = new ProductB("B");
        public int Calculate(int NoOfItems, int promopairs, int remainitems)
        {
            int totalB = (promopairs * 45) + (remainitems * prodB.price);
            Console.WriteLine("{0} * B {1}", NoOfItems, totalB);
            return totalB;
        }
    }
    public class PromotionCD : IPromotionCD
    {
        Product prodC = new ProductC("C");
        Product prodD = new ProductD("D");

        public int Calculate(int NoOfItemsC, int NoOfItemsD, int promopairs, int remainitemsC, int remainitemsD)
        {
            int totalCD = 0;
            Console.WriteLine("{0} * C {1}", NoOfItemsC, remainitemsC * prodC.price);
            Console.WriteLine("{0} * D {1}", NoOfItemsD, (promopairs * 30) + (remainitemsD * prodD.price));
            totalCD = (remainitemsC * prodC.price) + (promopairs * 30) + (remainitemsD * prodD.price);
            return totalCD;
        }
    }
}
