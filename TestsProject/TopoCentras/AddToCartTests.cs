﻿
using FrameworkProject.Page;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using TestsProject.BaseTests;

namespace TestsProject.TopoCentras
{
    internal class AddToCartTests : BaseTest
    {
        [SetUp]
        public void Open()
        {
            AddToCartPage.Open();
        }

        [Test]
        public void AddToCartTest()
        {
            string expectedProductName = "Mobilusis telefonas";
            string expectedQuantity = "2";

            AddToCartPage.ClickAddToCartButton();
            AddToCartPage.ClickContinueShoppingButton();
            AddToCartPage.SelectProduct();
            AddToCartPage.ClickAddToCartButtonInTheProductPage();
            AddToCartPage.ClickContinueShoppingButton();
            AddToCartPage.HoverOnCartButton();
            AddToCartPage.ClickBuyButton();
            AddToCartPage.ClickQuantityButton();

            List<string> actualProducts = AddToCartPage.GetProductsText();
            Assert.IsTrue(actualProducts.TrueForAll(x => x.Contains(expectedProductName)));

            string actualQuantity = AddToCartPage.GetProductQuantity();
            Assert.AreEqual(expectedQuantity, actualQuantity);
        }
    }
}
