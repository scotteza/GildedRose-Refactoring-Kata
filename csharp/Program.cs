using GildedRose.Items;
using System;
using System.Collections.Generic;

namespace GildedRose
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("OMGHAI!");

            IList<Item> items = new List<Item>{
                Item.GetItem ("+5 Dexterity Vest", 10, 20),
                Item.GetItem ("Aged Brie", 2, 0),
                Item.GetItem ("Elixir of the Mongoose", 5, 7),
                Item.GetItem ("Sulfuras, Hand of Ragnaros", 0, 80),
                Item.GetItem ("Sulfuras, Hand of Ragnaros", -1, 80),
                Item.GetItem("Backstage passes to a TAFKAL80ETC concert",15,20),
                Item.GetItem("Backstage passes to a TAFKAL80ETC concert",10,49),
                Item.GetItem("Backstage passes to a TAFKAL80ETC concert",5,49),
				// this conjured item does not work properly yet
				Item.GetItem ("Conjured Mana Cake", 3, 6)
            };

            var app = new GildedRose(items);


            for (var i = 0; i < 31; i++)
            {
                Console.WriteLine("-------- day " + i + " --------");
                Console.WriteLine("name, sellIn, quality");
                foreach (var item in items)
                {
                    System.Console.WriteLine(item.Name + ", " + item.SellIn + ", " + item.Quality);
                }
                Console.WriteLine("");
                app.UpdateQuality();
            }
        }
    }
}
