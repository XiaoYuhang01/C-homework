using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums;
            nums = new int [100];

            for(int i = 0; i < 100; i++)
            {
                nums[i] = i;
            }

            for(int i = 0; i < 100; i++)
            {
                if(nums[i]%2 == 0)
                { nums[i] = 0; }
            }
            for (int i = 0; i < 100; i++)
            {
                if (nums[i] % 3 == 0)
                { nums[i] = 0; }
            }
            for (int i = 0; i < 100; i++)
            {
                if (nums[i] % 5 == 0)
                { nums[i] = 0; }
            }
            for (int i = 0; i < 100; i++)
            {
                if (nums[i] % 7 == 0)
                { nums[i] = 0; }
            }

            for(int i = 0; i < 100; i++)
            {
                if (nums[i] != 0)
                {
                    Console.Write(nums[i] + ",");
                }
            }
        }
    }
}
