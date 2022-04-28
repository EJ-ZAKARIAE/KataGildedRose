using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRose.Model
{
    public class Conjured : Rose
    {
        private static String Conjured_NAME = "Conjured";
        public Conjured()
        {
            this.Name = Conjured_NAME;
        }

        public Conjured(int sellIn, int quality)
        {
            this.Name = Conjured_NAME;
            this.SellIn = sellIn;
            this.Quality = quality;
        }

        public override void UpdateQuality()
        {
            this.SellIn--;

            decreaseQuality();
            decreaseQuality();

            if (this.SellIn < 0)
            {
                decreaseQuality();
                decreaseQuality();
            }
        }
    }
}
