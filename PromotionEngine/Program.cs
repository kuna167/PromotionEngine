using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    
    
    public class Program
    {       
        static void Main(string[] args)
        {
            ICart c1 = new Cart();
            int total = 0;
            c1.AddProducttoCart(new ProductA("A"));
            c1.AddProducttoCart(new ProductB("B"));
            c1.AddProducttoCart(new ProductC("C"));
            c1.AddProducttoCart(new ProductD("D"));
            c1.AddProducttoCart(new ProductA("A"));
            c1.AddProducttoCart(new ProductA("A"));
            c1.AddProducttoCart(new ProductB("B"));
            c1.AddProducttoCart(new ProductA("A"));
            total = c1.ApplyPromotion();
            Console.WriteLine("======================");
            Console.WriteLine("Total {0}", total);
            Console.ReadLine();
        }
    }
}
