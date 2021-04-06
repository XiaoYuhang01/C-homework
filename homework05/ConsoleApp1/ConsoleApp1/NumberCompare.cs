using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class NumberCompare:IComparer<Order> 
    {
        public int Compare(Order O1,Order O2)
        {
            return O1.orderNumber - O2.orderNumber;
        }
    }
}
