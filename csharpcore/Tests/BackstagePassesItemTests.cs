using Xunit;
using System.Collections.Generic;
using csharpcore.Items;

namespace csharpcore.Tests
{
    public class BackstagePassesItemTests
    {
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
        [InlineData(10, 49, 1, 50)]
        [InlineData(5, 49, 1, 50)]
        public void Test_BackstagePasses_Quality_OverTime(int sellIn, int intialQuality, int numberOfPassedDays, int expectedQuality)
        {
            IItem item = new BackstagePassesItem(new Item { Name = "Backstage passes to a TAFKAL80ETC concert", Quality = intialQuality, SellIn = sellIn });
            for (int i = 0; i < numberOfPassedDays; i++)
            {
                item.UpdateItemAfterOneDay();
            }
            Assert.Equal(expectedQuality, item.Quality);
        }
    }
}
