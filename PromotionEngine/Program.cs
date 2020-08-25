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
        //static List<Product> products = new List<Product>();
        
        static void Main(string[] args)
        {
            //products.Add(new ProductA("A"));
            //products.Add(new ProductB("B"));
            //products.Add(new ProductC("C"));
            //products.Add(new ProductD("D"));
            ICart c1 = new Cart();
            int total = 0;
            c1.AddProducttoCart(new ProductA("A"));
            c1.AddProducttoCart(new ProductB("B"));
            c1.AddProducttoCart(new ProductC("C"));
            c1.AddProducttoCart(new ProductD("D"));
            c1.AddProducttoCart(new ProductA("A"));
            //c1.AddProducttoCart(new ProductA("A"));
            //c1.AddProducttoCart(new ProductB("B"));
            total = c1.ApplyPromotion();
            Console.WriteLine("======================");
            Console.WriteLine("Total {0}", total);
            Console.ReadLine();
        }
    }
}
