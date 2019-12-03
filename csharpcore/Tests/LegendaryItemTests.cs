using Xunit;
using System.Collections.Generic;
using csharpcore.Items;

namespace csharpcore.Tests
{
    public class LegendaryItemTests
    {
        [Theory]
        [InlineData(10, 1, 10)]
        [InlineData(10, 5, 10)]
        [InlineData(10, 10, 10)]
        [InlineData(10, 30, 10)]
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
    }
}
