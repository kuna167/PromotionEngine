using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PromotionEngine.BusinessLogic;
using PromotionEngine.Models;
using PromotionEngine.Contracts;

namespace PromotionEngine.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        CartUtilities cartutilities;
        [TestMethod]
        public void AddProducttoCart_Test()
        {
            cartutilities = new CartUtilities();
            cartutilities.AddProducttoCart(new ProductA("A"));
            string InputSKU = "A";
            string ExpectedSKU = cartutilities.CartProducts[0].ProductCode;
            Assert.AreEqual(InputSKU, ExpectedSKU);
        }
        [TestMethod]
        public void DisplayTotalAmountwithProducts_3A_Test()
        {
            cartutilities = new CartUtilities();
            cartutilities.CartProducts.Add(new ProductA("A"));
            cartutilities.CartProducts.Add(new ProductB("B"));
            cartutilities.CartProducts.Add(new ProductC("A"));
            cartutilities.CartProducts.Add(new ProductD("A"));

            int InputAmount = 160;
            int ExpectedAmount = cartutilities.DisplayTotalAmountwithProducts();

            Assert.AreEqual(InputAmount, ExpectedAmount);
        }
        [TestMethod]
        public void DisplayTotalAmountwithProducts_2B_Test()
        {
            cartutilities = new CartUtilities();
            cartutilities.CartProducts.Add(new ProductA("A"));
            cartutilities.CartProducts.Add(new ProductB("B"));
            cartutilities.CartProducts.Add(new ProductC("A"));
            cartutilities.CartProducts.Add(new ProductD("B"));

            int InputAmount = 145;
            int ExpectedAmount = cartutilities.DisplayTotalAmountwithProducts();

            Assert.AreEqual(InputAmount, ExpectedAmount);
        }
        [TestMethod]
        public void DisplayTotalAmountwithProducts_1C1D_Test()
        {
            cartutilities = new CartUtilities();
            cartutilities.CartProducts.Add(new ProductA("A"));
            cartutilities.CartProducts.Add(new ProductB("B"));
            cartutilities.CartProducts.Add(new ProductC("C"));
            cartutilities.CartProducts.Add(new ProductD("D"));

            int InputAmount = 110;
            int ExpectedAmount = cartutilities.DisplayTotalAmountwithProducts();

            Assert.AreEqual(InputAmount, ExpectedAmount);
        }
    }
}
