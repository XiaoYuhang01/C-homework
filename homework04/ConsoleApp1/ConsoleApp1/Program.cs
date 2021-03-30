using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> intlist = new GenericList<int>();
            for(int i = 0; i < 10; i++)
            {
                intlist.Add(i);
            }
            Action<int> ListAction = i => Console.WriteLine(i);

            int max =  intlist.headData;
            int min = max;
            int sum = 0;
            ListAction += i => { if (i > max) max = i; };
            ListAction += i => { if (i < min) min = i; };
            ListAction += i => { sum += i;  };
            
            intlist.ForEach(ListAction);
            Console.WriteLine($"最大值:{ max },最小值:{min},和:{sum}");
        }
    }
}
