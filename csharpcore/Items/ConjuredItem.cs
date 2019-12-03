using System;
using System.Collections.Generic;
using System.Text;

namespace csharpcore.Items
{
      /*
       * Conjured" items degrade in Quality twice as fast as normal items
       */
    class ConjuredItem :GeneralItem
    {
      
        public ConjuredItem(Item item) : base(item) {}

        public override void UpdateItemAfterOneDay()
        {
            SellIn = SellIn - 1;
            Quality = SellIn >= 0 ? Quality - 2 : Quality - 4;
        }
    }
}
