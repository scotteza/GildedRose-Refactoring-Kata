using System.Collections.Generic;

namespace GildedRose
{
    public class GildedRose
    {
        private readonly IList<Item> items;

        public GildedRose(IList<Item> Items)
        {
            this.items = Items;
        }

        public void UpdateQuality()
        {
            for (var i = 0; i < items.Count; i++)
            {
                var currentItem = items[i];

                HandleQualityChanges(currentItem);

                HandleSellInChanges(currentItem);

                HandleExpiredProducts(currentItem);
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

        private static void HandleSellInChanges(Item currentItem)
        {
            if (currentItem.Name != "Sulfuras, Hand of Ragnaros")
            {
                currentItem.SellIn = currentItem.SellIn - 1;
            }
        }

        private static void HandleExpiredProducts(Item currentItem)
        {
            if (currentItem.SellIn < 0)
            {
                if (currentItem.Name != "Aged Brie")
                {
                    if (currentItem.Name != "Backstage passes to a TAFKAL80ETC concert")
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
                        currentItem.Quality = currentItem.Quality - currentItem.Quality;
                    }
                }
                else
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
