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

        public void HandleExpiredProducts()
        {
            if (SellIn < 0)
            {
                if (Name != "Aged Brie")
                {
                    if (Name != "Backstage passes to a TAFKAL80ETC concert")
                    {
                        if (Quality > 0)
                        {
                            if (Name != "Sulfuras, Hand of Ragnaros")
                            {
                                Quality = Quality - 1;
                            }
                        }
                    }
                    else
                    {
                        Quality = Quality - Quality;
                    }
                }
                else
                {
                    if (Quality < 50)
                    {
                        Quality = Quality + 1;
                    }
                }
            }
        }
    }
}
