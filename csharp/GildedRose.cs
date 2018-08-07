using GildedRose.Items;
using System.Collections.Generic;

namespace GildedRose
{
    public class GildedRose
    {
        private readonly IList<Item> items;

        public GildedRose(IList<Item> items)
        {
            this.items = items;
        }

        public void UpdateQuality()
        {
            foreach (var currentItem in items)
            {
                currentItem.HandleQualityChanges();

                currentItem.DecreaseSellin();

                currentItem.HandleExpiry();
            }
        }
    }
}
