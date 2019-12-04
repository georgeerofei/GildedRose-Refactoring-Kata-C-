using System;
using System.Collections.Generic;
using System.Text;

namespace csharpcore
{
     /*Adapter class for Item*/
    public class GeneralItem : IItem
    {
        private Item _item;

        protected readonly int MaxQuality=50;
        protected readonly int MinQuality = 0;
        public GeneralItem(Item item)
        {
            _item= item;
            //validate the new Item
            Quality = item.Quality;
            Name = item.Name;
            SellIn = item.SellIn;
        }
        public string Name { get => _item.Name;  protected set => _item.Name = value; }
        public int SellIn{  get => _item.SellIn; protected set => _item.SellIn = value; }
        public virtual int Quality { 
            get => _item.Quality; 
            
            protected set
            {
                if (value > MaxQuality|| value < MinQuality) 
                {
                    throw new ArgumentOutOfRangeException();
                }
                    
               _item.Quality = value;
            }
        }

        public virtual void UpdateItemAfterOneDay() 
        {
            SellIn = SellIn - 1;
            try
            {
                Quality = SellIn >= 0 ? Quality - 1 : Quality - 2;
            }
            catch (ArgumentOutOfRangeException ex) 
            {
                Quality = MinQuality;
            }
            
        }
    }
}
