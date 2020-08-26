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
        IPromotion _IPromo;
        IPromotionCD _IPromoCD;
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

            int ActualAmount = 160;
            int ExpectedAmount = cartutilities.DisplayTotalAmountwithProducts();

            Assert.AreEqual(ActualAmount, ExpectedAmount);
        }
        [TestMethod]
        public void DisplayTotalAmountwithProducts_2B_Test()
        {
            cartutilities = new CartUtilities();
            cartutilities.CartProducts.Add(new ProductA("A"));
            cartutilities.CartProducts.Add(new ProductB("B"));
            cartutilities.CartProducts.Add(new ProductC("A"));
            cartutilities.CartProducts.Add(new ProductD("B"));

            int ActualAmount = 145;
            int ExpectedAmount = cartutilities.DisplayTotalAmountwithProducts();

            Assert.AreEqual(ActualAmount, ExpectedAmount);
        }
        [TestMethod]
        public void DisplayTotalAmountwithProducts_1C1D_Test()
        {
            cartutilities = new CartUtilities();
            cartutilities.CartProducts.Add(new ProductA("A"));
            cartutilities.CartProducts.Add(new ProductB("B"));
            cartutilities.CartProducts.Add(new ProductC("C"));
            cartutilities.CartProducts.Add(new ProductD("D"));

            int ActualAmount = 110;
            int ExpectedAmount = cartutilities.DisplayTotalAmountwithProducts();

            Assert.AreEqual(ActualAmount, ExpectedAmount);
        }
        [TestMethod]
        public void DisplayTotalAmountwithProducts_ABC_Test()
        {
            cartutilities = new CartUtilities();
            cartutilities.CartProducts.Add(new ProductA("A"));
            cartutilities.CartProducts.Add(new ProductB("B"));
            cartutilities.CartProducts.Add(new ProductC("C"));

            int ActualAmount = 100;
            int ExpectedAmount = cartutilities.DisplayTotalAmountwithProducts();

            Assert.AreEqual(ActualAmount, ExpectedAmount);
        }
        [TestMethod]
        public void CalculateA_1Pair_0Remaining_Test()
        {
            _IPromo = new PromotionA();
            
            int ActualAmount = 130;
            int ExpectedAmount = _IPromo.Calculate(3,1,0);

            Assert.AreEqual(ActualAmount, ExpectedAmount);
        }
        [TestMethod]
        public void CalculateA_1Pair_1Remaining_Test()
        {
            _IPromo = new PromotionA();

            int ActualAmount = 180;
            int ExpectedAmount = _IPromo.Calculate(3, 1, 1);

            Assert.AreEqual(ActualAmount, ExpectedAmount);
        }
        [TestMethod]
        public void CalculateA_0Pair_2Remaining_Test()
        {
            _IPromo = new PromotionA();

            int ActualAmount = 100;
            int ExpectedAmount = _IPromo.Calculate(2, 0, 2);

            Assert.AreEqual(ActualAmount, ExpectedAmount);
        }
        [TestMethod]
        public void CalculateB_0Pair_0Remaining_Test()
        {
            _IPromo = new PromotionB();

            int ActualAmount = 0;
            int ExpectedAmount = _IPromo.Calculate(0, 0, 0);

            Assert.AreEqual(ActualAmount, ExpectedAmount);
        }
        [TestMethod]
        public void CalculateB_1Pair_0Remaining_Test()
        {
            _IPromo = new PromotionB();

            int ActualAmount = 45;
            int ExpectedAmount = _IPromo.Calculate(1, 1, 0);

            Assert.AreEqual(ActualAmount, ExpectedAmount);
        }
        [TestMethod]
        public void CalculateB_1Pair_1Remaining_Test()
        {
            _IPromo = new PromotionB();

            int ActualAmount = 75;
            int ExpectedAmount = _IPromo.Calculate(1, 1, 1);

            Assert.AreEqual(ActualAmount, ExpectedAmount);
        }
        [TestMethod]
        public void CalculateCD_2Pair_0Remaining_Test()
        {
            _IPromoCD = new PromotionCD();

            int ActualAmount = 60;
            int ExpectedAmount = _IPromoCD.Calculate(2, 2, 2, 0, 0);

            Assert.AreEqual(ActualAmount, ExpectedAmount);
        }
        [TestMethod]
        public void CalculateCD_1Pair_1CRemaining_0DRemaining_Test()
        {
            _IPromoCD = new PromotionCD();

            int ActualAmount = 50;
            int ExpectedAmount = _IPromoCD.Calculate(2, 1, 1, 1, 0);

            Assert.AreEqual(ExpectedAmount, ActualAmount);
        }
        [TestMethod]
        public void CalculateCD_1Pair_0CRemaining_1DRemaining_Test()
        {
            _IPromoCD = new PromotionCD();

            int ActualAmount = 45;
            int ExpectedAmount = _IPromoCD.Calculate(1, 2, 1, 0, 1);

            Assert.AreEqual(ExpectedAmount, ActualAmount);
        }
        [TestMethod]
        public void CalculateCD_0Pair_1CRemaining_0DRemaining_Test()
        {
            _IPromoCD = new PromotionCD();

            int ActualAmount = 20;
            int ExpectedAmount = _IPromoCD.Calculate(1, 0, 0, 1, 0);

            Assert.AreEqual(ExpectedAmount, ActualAmount);
        }
    }
}
