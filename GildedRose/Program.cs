using System;
using System.Collections.Generic;
using GildedRose.Model;
using GildedRose.Solution.Business;

namespace GildedRose.Original
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("OMGHAI!");

            IEnumerable<Rose> Items = new List<Rose>{
                new Rose {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                new AgedBrie(2, 0),
                new Rose {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
                new Sulfutras (0, 80),
                new Sulfutras (-1, 80),
                new BackstagePasses(15, 20),
                new BackstagePasses(10, 49),
                new BackstagePasses(5, 49),
				new Conjured(3, 6)
            };

            QualityUpdater qualityUpdater =  new QualityUpdater(Items);

            for (var i = 0; i < 31; i++)
            {
                Console.WriteLine("-------- day " + i + " --------");
                Console.WriteLine("name, sellIn, quality");
                qualityUpdater.Print();
                Console.WriteLine("");
                qualityUpdater.UpdateQuality();
            }
        }
    }
}
