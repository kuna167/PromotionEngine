using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using PromotionEngine.Contracts;
using PromotionEngine.Models;
using PromotionEngine.BusinessLogic;

namespace PromotionEngine
{       
    public class Program
    {       
        static void Main(string[] args)
        {
            ICart c1 = new CartUtilities();
            int total = 0;
            //Adding the products to Cart
            c1.AddProducttoCart(new ProductA("A"));
            c1.AddProducttoCart(new ProductB("B"));
            c1.AddProducttoCart(new ProductC("C"));
            c1.AddProducttoCart(new ProductD("D"));
            c1.AddProducttoCart(new ProductA("A"));
            c1.AddProducttoCart(new ProductA("A"));
            c1.AddProducttoCart(new ProductB("B"));
            c1.AddProducttoCart(new ProductA("A"));

            //Allying discounts to the eligible products
            total = c1.DisplayTotalAmountwithProducts();

            Console.WriteLine("======================");
            Console.WriteLine("Total {0}", total);
            Console.ReadLine();
        }
    }
}
