using System;
using System.Collections.Generic;
using System.Text;

namespace csharpcore
{
    public class BackstagePassesItem : GeneralItem
    {
        public BackstagePassesItem(Item item) : base(item) { }

        public override void UpdateItemAfterOneDay()
        {
            SellIn = SellIn - 1;
            if (SellIn < 0)
            {
                Quality = 0;
            }
            else if (SellIn < 5)
            {
                Quality += 3;
            }
            else if (SellIn < 10)
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
