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
    }
}
