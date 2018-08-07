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
                HandleQualityChanges(currentItem);

                currentItem.DecreaseSellin();

                currentItem.HandleExpiredProducts();
            }
        }

        private static void HandleQualityChanges(Item currentItem)
        {
            if (currentItem.Name != "Aged Brie" && currentItem.Name != "Backstage passes to a TAFKAL80ETC concert")
            {
                if (currentItem.Quality > 0)
                {
                    if (currentItem.Name != "Sulfuras, Hand of Ragnaros")
                    {
                        currentItem.Quality = currentItem.Quality - 1;
                    }
                }
            }
            else
            {
                if (currentItem.Quality < 50)
                {
                    currentItem.Quality = currentItem.Quality + 1;

                    if (currentItem.Name == "Backstage passes to a TAFKAL80ETC concert")
                    {
                        if (currentItem.SellIn < 11)
                        {
                            if (currentItem.Quality < 50)
                            {
                                currentItem.Quality = currentItem.Quality + 1;
                            }
                        }

                        if (currentItem.SellIn < 6)
                        {
                            if (currentItem.Quality < 50)
                            {
                                currentItem.Quality = currentItem.Quality + 1;
                            }
                        }
                    }
                }
            }
        }
    }
}
