using Xunit;
using System.Collections.Generic;
using csharpcore.Items;

namespace csharpcore.Tests
{
    public class CheeseItemTests
    {
        [Theory]
        [InlineData(10, 1, 9)]
        [InlineData(10, 5, 5)]
        [InlineData(10, 10, 0)]
        [InlineData(10, 30, -20)]
        public void Test_CheeseItem_SellIn_OverTime(int sellIn, int numberOfPassedDays, int expectedSellIn)
        {
            IItem item = new CheeseItem(new Item { Name = "CheeseItem", Quality = 20, SellIn = sellIn });
            for (int i = 0; i < numberOfPassedDays; i++)
            {
                item.UpdateItemAfterOneDay();
            }
            Assert.Equal(expectedSellIn, item.SellIn);
        }


        [Theory]
        [InlineData(10, 20, 1, 21)]
        [InlineData(10, 20, 5, 25)]
        [InlineData(10, 20, 10, 30)]
        [InlineData(10, 20, 30, 50)]
        public void Test_CheeseItem_Quality_OverTime(int sellIn, int intialQuality, int numberOfPassedDays, int expectedQuality)
        {
            IItem item = new CheeseItem(new Item { Name = "CheeseItem", Quality = intialQuality, SellIn = sellIn });
            for (int i = 0; i < numberOfPassedDays; i++)
            {
                item.UpdateItemAfterOneDay();
            }
            Assert.Equal(expectedQuality, item.Quality);
        }
    }
}
