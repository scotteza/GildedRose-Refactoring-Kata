namespace GildedRose.Items
{
    public class CheeseItem : Item
    {
        public CheeseItem(string name, int sellIn, int quality) : base(name, sellIn, quality)
        {
        }

        public override void HandleExpiry()
        {
            if (!IsExpired())
            {
                return;
            }

            if (Quality < 50)
            {
                Quality = Quality + 1;
            }
        }
    }
}