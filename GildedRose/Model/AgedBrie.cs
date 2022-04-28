using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRose.Model
{
    public class AgedBrie : Rose
    {
        private static string AGED_BRIE_NAME = "Aged Brie";

        public AgedBrie()
        {
            this.Name = AGED_BRIE_NAME;
        }

        public AgedBrie(int sellIn, int quality)
        {
            this.Name = AGED_BRIE_NAME;
            this.SellIn = sellIn;
            this.Quality = quality; 
        }

        override public void UpdateQuality()
        {
            this.SellIn--;

            increaseQuality();

            if (SellIn < 0)
            {
                increaseQuality();
            }
        }
    }
}
