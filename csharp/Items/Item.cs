namespace GildedRose.Items
{
    public abstract class Item
    {
        public static Item GetItem(string name, int sellIn, int quality)
        {
            switch (name)
            {
                case "Sulfuras, Hand of Ragnaros":
                    return new LegendaryItem(name, sellIn, quality);
                case "Backstage passes to a TAFKAL80ETC concert":
                    return new BackstagePassItem(name, sellIn, quality);
                case "Aged Brie":
                    return new CheeseItem(name, sellIn, quality);
                default:
                    return new BasicItem(name, sellIn, quality);
            }
        }

        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }

        protected Item(string name, int sellIn, int quality)
        {
            Name = name;
            SellIn = sellIn;
            Quality = quality;
        }

        public virtual void DecreaseSellin()
        {
            SellIn--;
        }

        public virtual void HandleExpiry()
        {
            // TODO: remove duplication of this everywhere
            if (!IsExpired())
            {
                return;
            }

            if (Quality > 0)
            {
                Quality = Quality - 1;
            }
        }

        protected bool IsExpired()
        {
            return SellIn < 0;
        }

        public void HandleQualityChanges()
        {
            var currentItem = this;
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
