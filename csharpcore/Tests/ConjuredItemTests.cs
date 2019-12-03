using Xunit;
using System.Collections.Generic;
using csharpcore.Items;

namespace csharpcore.Tests
{
    public class ConjuredItemTests
    {
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
