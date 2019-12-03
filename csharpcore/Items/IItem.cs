using System;
using System.Collections.Generic;
using System.Text;

namespace csharpcore
{
    interface IItem
    {
        string Name { get;  }
        int SellIn { get;   }
        int Quality { get;  }
        void UpdateItemAfterOneDay();
    }
}
