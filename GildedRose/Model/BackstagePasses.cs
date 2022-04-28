namespace GildedRose.Model
{
    public class BackstagePasses : Rose
    {
        private static string BACKSTAGE_PASSES_NAME = "Backstage passes";
        public BackstagePasses()
        {
            this.Name = BACKSTAGE_PASSES_NAME;
        }

        public BackstagePasses(int sellIn, int quality)
        {
            this.Name = BACKSTAGE_PASSES_NAME;
            this.SellIn = sellIn;
            this.Quality = quality;
        }

        public override void UpdateQuality()
        {
            this.SellIn--;

            increaseQuality();

            if (this.SellIn < 10)
            {
                increaseQuality();
            }

            if (this.SellIn < 5)
            {
                increaseQuality();
            }

            if (this.SellIn < 0)
            {
                this.Quality = 0;
            }
        }

    }
}
