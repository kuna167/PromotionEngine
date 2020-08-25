using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    interface ICart
    {
        int ApplyPromotion();
        void AddProducttoCart(Product Prod);
    }

    class Cart : ICart
    {
        IPromotion _IPromo;
        IPromotionCD _IPromoCD;
        List<Product> CartProducts = new List<Product>();
        public Cart()
        {

        }
        //public IPromotion GetPromoObject(IPromotion IPromo)
        //{
        //    return _IPromo = IPromo;
        //}
        public void AddProducttoCart(Product Prod)
        {
            CartProducts.Add(Prod);
        }

        public int ApplyPromotion()
        {            
            int NoOfA = 0;
            int NoOfB = 0;
            int NoOfC = 0;
            int NoOfD = 0;
            bool promoA = false;
            bool promoB = false;
            bool promoC = false;
            bool promoD = false;
            Product prodA = new ProductA("A");
            Product prodB = new ProductB("B");
            Product prodC = new ProductC("C");
            Product prodD = new ProductD("D");
            int Total = 0;
            foreach (Product CP in CartProducts)
            {
                if (CP.GetType().Name == "ProductA")
                {
                    NoOfA++;
                }
                if (CP.GetType().Name == "ProductB")
                {
                    NoOfB++;
                }
                if (CP.GetType().Name == "ProductC")
                {
                    NoOfC++;
                }
                if (CP.GetType().Name == "ProductD")
                {
                    NoOfD++;
                }
            }
            if (NoOfA > 2)
            {
                int promopairs = 0;
                int remainitems = 0;
                remainitems = NoOfA % 3;
                promopairs = NoOfA / 3;
                _IPromo = new PromotionA();
                Total = Total + _IPromo.Calculate(NoOfA, promopairs, remainitems);
                promoA = true;
            }
            else if (NoOfB > 1)
            {
                int promopairs = 0;
                int remainitems = 0;
                remainitems = NoOfB % 2;
                promopairs = NoOfB / 2;
                _IPromo = new PromotionB();
                Total = Total + _IPromo.Calculate(NoOfB, promopairs, remainitems);
                promoB = true;
            }
            else if (NoOfC > 0 && NoOfD > 0)
            {
                int promopairs = 0;
                int remainitemsC = 0;
                int remainitemsD = 0;

                if (NoOfC == NoOfD)
                {
                    promopairs = NoOfC;
                    remainitemsC = 0;
                    remainitemsD = 0;
                }
                else if (NoOfC > NoOfD)
                {
                    promopairs = NoOfD;
                    remainitemsC = NoOfC - NoOfD;
                    remainitemsD = 0;
                }
                else
                {
                    promopairs = NoOfC;
                    remainitemsC = 0;
                    remainitemsD = NoOfD - NoOfC;
                }
                _IPromoCD = new PromotionCD();
                Total = Total + _IPromoCD.Calculate(NoOfC, NoOfD, promopairs, remainitemsC, remainitemsD);
                promoC = true;
                promoD = true;
            }
            foreach (Product prod in CartProducts)
            {
                if (prod.GetType().Name == "ProductA" && promoA == false)
                {                    
                    Console.WriteLine("{0} * A {1}", NoOfA, (NoOfA * prodA._price));
                    promoA = true;
                    Total = Total + (NoOfA * prodA._price);
                }
                else if (prod.GetType().Name == "ProductB" && promoB == false)
                {
                    Console.WriteLine("{0} * B {1}", NoOfB, (NoOfB * prodB._price));
                    promoB = true;
                    Total = Total + (NoOfB * prodB._price);
                }
                else if (prod.GetType().Name == "ProductC" && promoC == false)
                {
                    Console.WriteLine("{0} * C {1}", NoOfC, (NoOfC * prodC._price));
                    promoC = true;
                    Total = Total + (NoOfC * prodC._price);
                }
                else if (prod.GetType().Name == "ProductD" && promoD == false)
                {
                    Console.WriteLine("{0} * D {1}", NoOfD, (NoOfD * prodD._price));
                    promoD = true;
                    Total = Total + (NoOfD * prodD._price);
                }
            }
            return Total;
        }
    }
}
