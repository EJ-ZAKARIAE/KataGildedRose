using System;
using System.Collections.Generic;
using System.Text;
using GildedRose.Model;
using System.Linq;

namespace GildedRose.Solution.Business
{
    public class QualityUpdater : IQualityUpdater
    {

        private readonly IEnumerable<Rose> Items;
        public QualityUpdater(IEnumerable<Rose> items)
        {
            Items = items;
        }


        public void UpdateQuality()
        {
            foreach (var item in Items)
            {
                item.UpdateQuality();
            }
        }


        public void Print()
        {
            foreach (var item in Items)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
