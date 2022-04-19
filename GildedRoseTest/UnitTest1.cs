using GildedRose.Original;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace GildedRoseTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ShouldDecreaseQualityByOneForNormalWhenOneDayIsPassed()
        {
            IList<Item> Item = new List<Item>{
                new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20}
            };

            var app = new GildedRose.Original.GildedRose(Item);

            app.UpdateQuality();

            Assert.AreEqual(9, Item[0].SellIn);
            Assert.AreEqual(19, Item[0].Quality);
        }

        [TestMethod]
        public void ShouldIncreaseQualityByOneForAgedBrieWhenOneDayIsPassed()
        {
            IList<Item> Item = new List<Item>{
                new Item {Name = "Aged Brie", SellIn = 2, Quality = 0}
            };

            var app = new GildedRose.Original.GildedRose(Item);

            app.UpdateQuality();

            Assert.AreEqual(1, Item[0].SellIn);
            Assert.AreEqual(1, Item[0].Quality);
        }

        [TestMethod]
        public void ShouldNotChangeQualityForSulfurasWhenOneDayIsPassed()
        {
            IList<Item> Item = new List<Item>{
                new Item {Name = "Sulfuras", SellIn = 0, Quality = 80}
            };

            var app = new GildedRose.Original.GildedRose(Item);

            app.UpdateQuality();

            Assert.AreEqual(0, Item[0].SellIn);
            Assert.AreEqual(80, Item[0].Quality);
        }

        [TestMethod]
        public void ShouldIncreaseQualityByOneForBackstageWhenOneDayIsPassed()
        {
            IList<Item> Item = new List<Item>{
                new Item {Name = "Backstage passes", SellIn = 15, Quality = 20}
            };

            var app = new GildedRose.Original.GildedRose(Item);

            app.UpdateQuality();

            Assert.AreEqual(14, Item[0].SellIn);
            Assert.AreEqual(21, Item[0].Quality);
        }

        [TestMethod]
        public void ShouldDecreaseQualityByTwoForConjuredWhenOneDayIsPassed()
        {
            IList<Item> Item = new List<Item>{
                new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
            };

            var app = new GildedRose.Original.GildedRose(Item);

            app.UpdateQuality();

            Assert.AreEqual(2, Item[0].SellIn);
            Assert.AreEqual(4, Item[0].Quality);
        }
    }
}
