namespace GildedRose
{
    public static class ItemFactory
    {
        public static Item GetItem(string name, int sellIn, int quality)
        {
            return new Item(name, sellIn, quality);
        }
    }
}
