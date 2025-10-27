using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MgmDIDemo
{
    internal class CowMilk: IMilk
    {
        public string GetMilk()
        {
            return "Cow Milk";
        }
    }
   
}
