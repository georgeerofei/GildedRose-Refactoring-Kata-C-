using System;
using System.Collections.Generic;
using System.Text;

namespace csharpcore
{
    /*
     * - Once the sell by date has passed, Quality degrades twice as fast
	- The Quality of an item is never negative
	- The Quality of an item is never more than 50
     */

     /*Adapter class for Item*/
    public class GeneralItem : IItem
    {
        private Item _item;

        protected readonly int MaxQuality=50;
        public GeneralItem(Item item)
        {
            _item= item;
        }
        public string Name { get => _item.Name;  protected set => _item.Name = value; }
        public int SellIn{  get => _item.SellIn; protected set => _item.SellIn = value; }
        public virtual int Quality { 
            get => _item.Quality; 
            
            protected set
            {
                if (value > MaxQuality)
                    _item.Quality = MaxQuality;
                else if (value < 0)
                    _item.Quality = 0;
                else
                    _item.Quality = value;
            }
        }

        public virtual void UpdateItemAfterOneDay() 
        {
            SellIn = SellIn - 1;
            Quality= SellIn >= 0 ? Quality - 1 : Quality - 2;
        }
    }
}
