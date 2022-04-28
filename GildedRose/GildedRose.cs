using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRose.Original
{
    public class GildedRose
    {
        private static String AGED_BRIE_NAME = "Aged Brie";
        private static String BACKSTAGE_PASSES_NAME = "Backstage passes";
        private static String Conjured_NAME = "Conjured";
        private static String SULFURAS_NAME = "Sulfuras";

        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            foreach (Item item in getItems())
            {
                if (SULFURAS_NAME.Equals(item.Name))
                {
                    continue;
                }

                item.SellIn = item.SellIn - 1;

                if (AGED_BRIE_NAME.Equals(item.Name))
                {
                    updateAgedBrie(item);
                }
                else if (BACKSTAGE_PASSES_NAME.Equals(item.Name))
                {
                    updateBackstagePass(item);
                }
                else if (Conjured_NAME.Equals(item.Name))
                {
                    updateConjuredItem(item);
                }
                else
                {
                    updateNormalItem(item);
                }
            }

        }

        private void updateAgedBrie(Item item)
        {
            increaseQuality(item);

            if (item.SellIn < 0)
            {
                increaseQuality(item);
            }
        }

        private void updateBackstagePass(Item item)
        {
            increaseQuality(item);

            if (item.SellIn < 10)
            {
                increaseQuality(item);
            }

            if (item.SellIn < 5)
            {
                increaseQuality(item);
            }

            if (item.SellIn < 0)
            {
                item.Quality = 0;
            }
        }

        private void updateNormalItem(Item item)
        {
            decreaseQuality(item);

            if (item.SellIn < 0)
            {
                decreaseQuality(item);
            }
        }

        private void updateConjuredItem(Item item)
        {
            decreaseQuality(item);
            decreaseQuality(item);

            if (item.SellIn < 0)
            {
                decreaseQuality(item);
                decreaseQuality(item);
            }
        }


        private void increaseQuality(Item item)
        {
            if (item.Quality < 50)
            {
                item.Quality = item.Quality + 1;
            }
        }

        private void decreaseQuality(Item item)
        {
            if (item.Quality > 0)
            {
                item.Quality = item.Quality - 1;
            }
        }

        public IList<Item> getItems()
        {
            return Items;
        }

        public void setItems(IList<Item> items)
        {
            this.Items = items;
        }

    }
}
