using Xunit;
using System.Collections.Generic;
using csharpcore.Items;

namespace csharpcore
{
    public class CommonTests
    {
        [Fact]
        public void Test_IItem_NameOverTime()
        {
            var name = "foo";
            IList<IItem> Items = new List<IItem> { new GeneralItem(new Item { Name = name, Quality = 0, SellIn = 0 }) };

            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(name, Items[0].Name);
        }


    

     


     

       


        


       
    }
}