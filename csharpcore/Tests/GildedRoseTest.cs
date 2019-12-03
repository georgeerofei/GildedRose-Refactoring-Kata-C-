using Xunit;
using System.Collections.Generic;

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
    }
}