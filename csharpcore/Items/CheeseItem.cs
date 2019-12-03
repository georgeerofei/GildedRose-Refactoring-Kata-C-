using System;
using System.Collections.Generic;
using System.Text;

namespace csharpcore.Items
{
    /*TODO clarify 
    This class exists to satisfy the requirements about aged brie deduced from the initial implementation.
    If this was a real client I would need to clarify with him what should I do. 
    In these situations the requirements may be lacking in details or the initial implementation may be wrong.
    */
    class CheeseItem :GeneralItem     
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
