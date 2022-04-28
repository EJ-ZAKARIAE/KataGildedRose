using GildedRose.Model;
using GildedRose.Original;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace GildedRoseTest
{
    [TestClass]
    public class QualityUpdaterTest
    {
        [DataTestMethod]
        [DataRow(20, 10, 19, 9, 1)]
        [DataRow(20, 10, 18, 8, 2)]
        [DataRow(20, 10, 15, 5, 5)]
        public void Should_Update_Quality_For_Rose(int startQuality, int startSellerIn, int expectedQuality, int expectedSellIn, int nbrJour)
        {
            var rose = new Rose() { Name = "Elixir of the Mongoose", Quality = startQuality, SellIn = startSellerIn };
            for (int i = 0; i < nbrJour; i++)
            {
                rose.UpdateQuality();

            }

            Assert.AreEqual(expectedQuality, rose.Quality);
            Assert.AreEqual(expectedSellIn, rose.SellIn);

        }

        [DataTestMethod]
        [DataRow(20, 10, 21, 9, 1)]
        [DataRow(20, 10, 22, 8, 2)]
        public void Should_Update_Quality_For_AgedBrie(int startQuality, int startSellerIn, int expectedQuality, int expectedSellIn, int nbrJour)
        {
            var rose = new AgedBrie() { Quality = startQuality, SellIn = startSellerIn };
            for (int i = 0; i < nbrJour; i++)
            {
                rose.UpdateQuality();

            }

            Assert.AreEqual(expectedQuality, rose.Quality);
            Assert.AreEqual(expectedSellIn, rose.SellIn);

        }

        [DataTestMethod]
        [DataRow(20, 10, 20, 10, 1)]
        [DataRow(20, 10, 20, 10, 10)]
        public void Should_Not_Update_Quality_For_Sulfutras(int startQuality, int startSellerIn, int expectedQuality, int expectedSellIn, int nbrJour)
        {
            var rose = new Sulfutras() { Quality = startQuality, SellIn = startSellerIn };
            for (int i = 0; i < nbrJour; i++)
            {
                rose.UpdateQuality();

            }

            Assert.AreEqual(expectedQuality, rose.Quality);
            Assert.AreEqual(expectedSellIn, rose.SellIn);

        }

        [DataTestMethod]
        [DataRow(20, 10, 22, 9, 1)]
        [DataRow(20, 15, 35, 5, 10)]
        public void Should_Update_Quality_For_BackstagePasses(int startQuality, int startSellerIn, int expectedQuality, int expectedSellIn, int nbrJour)
        {
            var rose = new BackstagePasses() { Quality = startQuality, SellIn = startSellerIn };
            for (int i = 0; i < nbrJour; i++)
            {
                rose.UpdateQuality();

            }

            Assert.AreEqual(expectedQuality, rose.Quality);
            Assert.AreEqual(expectedSellIn, rose.SellIn);

        }

        [DataTestMethod]
        [DataRow(20, 10, 18, 9, 1)]
        [DataRow(20, 15, 10, 10, 5)]
        public void Should_Update_Quality_For_Conjured(int startQuality, int startSellerIn, int expectedQuality, int expectedSellIn, int nbrJour)
        {
            var rose = new Conjured() { Quality = startQuality, SellIn = startSellerIn };
            for (int i = 0; i < nbrJour; i++)
            {
                rose.UpdateQuality();

            }

            Assert.AreEqual(expectedQuality, rose.Quality);
            Assert.AreEqual(expectedSellIn, rose.SellIn);

        }
    }
}
