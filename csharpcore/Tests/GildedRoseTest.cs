using Xunit;
using System.Collections.Generic;
using csharpcore.Items;

namespace csharpcore
{
    public class GildedRoseTest
    {
        [Fact]
        public void Test_IItem_NameOverTime()
        {
            var name = "foo";
            IList<Item> Items = new List<Item> { new Item { Name = name, SellIn = 0, Quality = 0 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal("foo", Items[0].Name);
        }


        [Theory]
        [InlineData(10,  1, 9 )]
        [InlineData(10,  5, 5)]
        [InlineData(10,  10, 0)]
        [InlineData(10,  30, -20)]
        public void Test_GeneralItem_SellIn_OverTime(int sellIn,  int numberOfPassedDays, int expectedSellIn)
        {
            IItem item = new GeneralItem(new Item { Name = "+5 Dexterity Vest", Quality = 20, SellIn = sellIn });
            for (int i = 0; i < numberOfPassedDays; i++)
            {
                item.UpdateItemAfterOneDay();
            }
            Assert.Equal(expectedSellIn, item.SellIn);
        }


        [Theory]
        [InlineData(10, 20, 1,  19)]
        [InlineData(10, 20, 5, 15)]
        [InlineData(10, 20, 10, 10)]
        [InlineData(10, 20, 30, 0)]
        public void Test_GeneralItem_Quality_OverTime(int sellIn, int intialQuality, int numberOfPassedDays, int expectedQuality)
        {
            IItem item = new GeneralItem(new Item { Name = "+5 Dexterity Vest", Quality = intialQuality, SellIn = sellIn });
            for(int i=0; i< numberOfPassedDays; i++) 
            {
                item.UpdateItemAfterOneDay();
            }
            Assert.Equal(expectedQuality, item.Quality);
        }



        [Theory]
        [InlineData(10, 1, 9)]
        [InlineData(10, 5, 5)]
        [InlineData(10, 10, 0)]
        [InlineData(10, 30, -20)]
        public void Test_BackstagePasses_SellIn_OverTime(int sellIn, int numberOfPassedDays, int expectedSellIn)
        {
            IItem item = new BackstagePassesItem(new Item { Name = "Backstage passes to a TAFKAL80ETC concert", Quality = 20, SellIn = sellIn });
            for (int i = 0; i < numberOfPassedDays; i++)
            {
                item.UpdateItemAfterOneDay();
            }
            Assert.Equal(expectedSellIn, item.SellIn);
        }


        [Theory]
        [InlineData(15, 20, 1, 21)]
        [InlineData(15, 20, 5, 25)]
        [InlineData(15, 20, 10, 35)]
        [InlineData(15, 20, 15, 50)]
        [InlineData(10, 20, 30, 0)]
        public void Test_BackstagePasses_Quality_OverTime(int sellIn, int intialQuality, int numberOfPassedDays, int expectedQuality)
        {
            IItem item = new BackstagePassesItem(new Item { Name = "Backstage passes to a TAFKAL80ETC concert", Quality = intialQuality, SellIn = sellIn });
            for (int i = 0; i < numberOfPassedDays; i++)
            {
                item.UpdateItemAfterOneDay();
            }
            Assert.Equal(expectedQuality, item.Quality);
        }


     

        [Theory]
        [InlineData(10, 1, 9)]
        [InlineData(10, 5, 5)]
        [InlineData(10, 10, 0)]
        [InlineData(10, 30, -20)]
        public void Test_LegendaryItem_SellIn_OverTime(int sellIn, int numberOfPassedDays, int expectedSellIn)
        {
            IItem item = new LegendaryItem(new Item { Name = "Sulfuras, Hand of Ragnaros", Quality = 20, SellIn = sellIn });
            for (int i = 0; i < numberOfPassedDays; i++)
            {
                item.UpdateItemAfterOneDay();
            }
            Assert.Equal(expectedSellIn, item.SellIn);
        }


        [Theory]
        [InlineData(0, 80, 1, 80)]
        [InlineData(0, 80, 5, 80)]
        [InlineData(0, 80, 10, 80)]
        [InlineData(-1, 80, 30, 80)]
        public void Test_LegendaryItem_Quality_OverTime(int sellIn, int intialQuality, int numberOfPassedDays, int expectedQuality)
        {
            IItem item = new LegendaryItem(new Item { Name = "+5 Dexterity Vest", Quality = intialQuality, SellIn = sellIn });
            for (int i = 0; i < numberOfPassedDays; i++)
            {
                item.UpdateItemAfterOneDay();
            }
            Assert.Equal(expectedQuality, item.Quality);
        }


        [Theory]
        [InlineData(10, 1, 9)]
        [InlineData(10, 5, 5)]
        [InlineData(10, 10, 0)]
        [InlineData(10, 30, -20)]
        public void Test_ConjuredItem_SellIn_OverTime(int sellIn, int numberOfPassedDays, int expectedSellIn)
        {
            IItem item = new ConjuredItem(new Item { Name = "Conjured Mana Cake", Quality = 20, SellIn = sellIn });
            for (int i = 0; i < numberOfPassedDays; i++)
            {
                item.UpdateItemAfterOneDay();
            }
            Assert.Equal(expectedSellIn, item.SellIn);
        }


        [Theory]
        [InlineData(10, 20, 1, 18)]
        [InlineData(10, 20, 5, 10)]
        [InlineData(10, 20, 10, 0)]
        [InlineData(10, 20, 30, 0)]
        [InlineData(10, 30, 12, 2)]
        public void Test_ConjuredItem_Quality_OverTime(int sellIn, int intialQuality, int numberOfPassedDays, int expectedQuality)
        {
            IItem item = new ConjuredItem(new Item { Name = "Conjured Mana Cake", Quality = intialQuality, SellIn = sellIn });
            for (int i = 0; i < numberOfPassedDays; i++)
            {
                item.UpdateItemAfterOneDay();
            }
            Assert.Equal(expectedQuality, item.Quality);
        }
    }
}