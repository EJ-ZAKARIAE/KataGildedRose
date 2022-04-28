namespace GildedRose.Model
{
    public class Sulfutras : Rose
    {
        private static string SULFURAS_NAME = "Sulfuras";
        public Sulfutras()
        {
            this.Name = SULFURAS_NAME;
        }

        public Sulfutras(int sellIn, int quality)
        {
            this.Name = SULFURAS_NAME;
            this.SellIn = sellIn;
            this.Quality = quality;
        }

        public override void UpdateQuality()
        {
            
        }

    }
}
