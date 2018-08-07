using GildedRose.Items;
using NUnit.Framework;
using System.Collections.Generic;

namespace GildedRose
{
    [TestFixture]
    public class GildedRoseTest
    {
        [Test]
        public void Create_An_Item_Named_Foo()
        {
            var items = new List<Item>
            {
                Item.GetItem( "foo", 0, 0)
            };
            var app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual("foo", items[0].Name);
        }

        [Test]
        public void Create_Legendary_Items()
        {
            var item = Item.GetItem("Sulfuras, Hand of Ragnaros", 0, 0);

            Assert.That(item, Is.TypeOf<LegendaryItem>());
        }

        [Test]
        public void Create_Cheese_Items()
        {
            var item = Item.GetItem("Aged Brie", 0, 0);

            Assert.That(item, Is.TypeOf<CheeseItem>());
        }

        [Test]
        public void Create_BackstagePass_Items()
        {
            var item = Item.GetItem("Backstage passes to a TAFKAL80ETC concert", 0, 0);

            Assert.That(item, Is.TypeOf<BackstagePassItem>());
        }
    }
}
