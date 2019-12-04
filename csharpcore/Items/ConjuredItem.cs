using System;
using System.Collections.Generic;
using System.Text;

namespace csharpcore.Items
{
    class ConjuredItem :GeneralItem
    {
      
        public ConjuredItem(Item item) : base(item) {}

        public override void UpdateItemAfterOneDay()
        {
            SellIn = SellIn - 1;
            try
            {
                Quality = SellIn >= 0 ? Quality - 2 : Quality - 4;
            }
            catch 
            {
                Quality = MinQuality;
            }
            
        }
    }
}
