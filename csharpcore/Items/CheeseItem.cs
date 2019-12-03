using System;
using System.Collections.Generic;
using System.Text;

namespace csharpcore.Items
{
    class CheeseItem:GeneralItem     //AgedBrie
    {
        public CheeseItem(Item item) : base(item) { }

        public override void UpdateItemAfterOneDay()
        {
            SellIn = SellIn - 1;
            if (SellIn < 0)
            {
                Quality += 2;
            }
            else 
            {
                Quality += 1;
            }
            
        }
    }
}
