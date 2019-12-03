using System;
using System.Collections.Generic;
using System.Text;

namespace csharpcore.Items
{
    public class LegendaryItem:GeneralItem
    {
        /*
         * TODO clarify 
         *LegendaryItem does not update the SellIn field. This is against the requirements.
          If this was a real client I would need to clarify with him what should I do. 
          In these situations the requirements may be lacking in details or the initial implementation may be wrong.
       */
        public override int Quality
        {
            protected set
            {
                ;//do nothing
            }
        }

        public LegendaryItem(Item item) : base(item)
        {
            Quality = 80;
        }

        public override void UpdateItemAfterOneDay()
        {
            ;//do nothing
        }
    }
}
