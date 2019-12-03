using Xunit;
using System.Collections.Generic;
using csharpcore.Items;

namespace csharpcore.Tests
{
    public class GeneralItemTests
    {
        [Xunit.Theory]
        [InlineData(10, 1, 9)]
        [InlineData(10, 5, 5)]
        [InlineData(10, 10, 0)]
        [InlineData(10, 30, -20)]
        public void Test_GeneralItem_SellIn_OverTime(int sellIn, int numberOfPassedDays, int expectedSellIn)
        {
            IItem item = new GeneralItem(new Item { Name = "+5 Dexterity Vest", Quality = 20, SellIn = sellIn });
            for (int i = 0; i < numberOfPassedDays; i++)
            {
                item.UpdateItemAfterOneDay();
            }
            Assert.Equal(expectedSellIn, item.SellIn);
        }


        [Theory]
        [InlineData(10, 20, 1, 19)]
        [InlineData(10, 20, 5, 15)]
        [InlineData(10, 20, 10, 10)]
        [InlineData(10, 20, 30, 0)]
        public void Test_GeneralItem_Quality_OverTime(int sellIn, int intialQuality, int numberOfPassedDays, int expectedQuality)
        {
            IItem item = new GeneralItem(new Item { Name = "+5 Dexterity Vest", Quality = intialQuality, SellIn = sellIn });
            for (int i = 0; i < numberOfPassedDays; i++)
            {
                item.UpdateItemAfterOneDay();
            }
            Assert.Equal(expectedQuality, item.Quality);
        }


    }
}
