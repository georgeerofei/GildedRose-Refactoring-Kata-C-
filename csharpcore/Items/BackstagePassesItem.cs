using System;
using System.Collections.Generic;
using System.Text;

namespace csharpcore
{
    /*
     * - "Aged Brie" actually increases in Quality the older it gets
	- "Backstage passes", like aged brie, increases in Quality as its SellIn value approaches;
	   Quality increases by 2 when there are 10 days or less and by 3 when there are 5 days or less but
	   Quality drops to 0 after the concert
     */
    public class BackstagePassesItem : GeneralItem
    {
        BackstagePassesItem(Item item) : base(item) { }

        public override void UpdateItemAfterOneDay()
        {
            SellIn = SellIn - 1;
            if (SellIn < 0)
            {
                Quality = 0;
            }
            else if (SellIn <= 5)
            {
                Quality += 3;
            }
            else if (SellIn <= 10)
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
