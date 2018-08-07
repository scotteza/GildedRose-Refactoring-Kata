namespace GildedRose.Items
{
    public class BackstagePassItem : Item
    {
        public BackstagePassItem(string name, int sellIn, int quality) : base(name, sellIn, quality)
        {
        }

        public override void HandleExpiry()
        {
            if (!IsExpired())
            {
                return;
            }

            Quality = Quality - Quality;
        }
    }
}