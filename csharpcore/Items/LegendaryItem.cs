using System;
using System.Collections.Generic;
using System.Text;

namespace csharpcore.Items
{
    public class LegendaryItem:GeneralItem
    {
        /*
         * - "Sulfuras", being a legendary item, never has to be sold or decreases in Quality
            -"Sulfuras" is a legendary item and as such its Quality is 80 and it never alters.

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
