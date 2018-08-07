namespace GildedRose
{
    public abstract class Item
    {
        public static Item GetItem(string name, int sellIn, int quality)
        {
            return new BasicItem(name, sellIn, quality);
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
    }

    public class BasicItem : Item
    {
        public BasicItem(string name, int sellIn, int quality) : base(name, sellIn, quality)
        {
        }
    }
}
