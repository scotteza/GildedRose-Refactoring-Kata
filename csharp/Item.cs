namespace GildedRose
{
    public class Item
    {
        public Item()
        {
        }

        public Item(string name, int sellIn, int quality)
        {
            Name = name;
            SellIn = sellIn;
            Quality = quality;
        }

        public static Item GetItem(string name, int sellIn, int quality)
        {
            return new Item(name, sellIn, quality);
        }

        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }
    }
}
