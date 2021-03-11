using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] nums;
            nums = new int[5, 5] { { 1,2,3,4,5},
                                                { 5,1,2,3,4},
                                                { 4,5,1,2,3},
                                                { 3,4,5,1,2},
                                                { 2,3,4,5,1} };
            Console.WriteLine(topelitz(nums));
        }
        public static bool topelitz(int[,] nums)
        {
            for(int i = 1; i < 5; i++)
            {
                for(int j = 1; j < 5; j++)
                {
                    if (nums[i, j] != nums[i - 1, j - 1])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
