using GildedRose.Original;
using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRose.Model
{
    public class Rose : Item
    {

        virtual public void UpdateQuality()
        {
            this.SellIn--;

            decreaseQuality();

            if (this.SellIn < 0) 
                decreaseQuality();

        }

        protected void increaseQuality()
        {
            if (this.Quality < 50)
            {
                this.Quality = this.Quality + 1;
            }
        }

        protected void decreaseQuality()
        {
            if (this.Quality > 0)
            {
                this.Quality = this.Quality - 1;
            }
        }
    }
}
