using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10] { 23, 1, 10, 3, 24, 129, 7, 12, 64, 1234 };
            Program Nums = new Program();
            int maxNums = Nums.MaxArray(nums);
            int minNums = Nums.MinArray(nums);
            double aveNums = Nums.AveArray(nums);
            int sumNums = Nums.SumArray(nums);
            Console.WriteLine("最大值:" + maxNums);
            Console.WriteLine("最小值:" + minNums);
            Console.WriteLine("平均值:" + aveNums);
            Console.WriteLine("和:" + sumNums);
        }
        public int MaxArray(int[] nums)
        {
            int max = 0;
            max = nums[0];
            for (int i=0;i<nums.Length-1;i++)
            {
                
                if(max<=nums[i+1])
                {
                    max = nums[i + 1];
                }
            }
            return max;
        }

        public int MinArray(int[] nums)
        {
            int min = 0;
            min = nums[0];
            for (int i = 0; i < nums.Length-1; i++)
            {
                
                if (min >= nums[i + 1])
                {
                    min = nums[i + 1];
                }
            }
            return min;
        }

        public double AveArray(int[] nums)
        {
            double average = 0;
            foreach(int num in nums)
            {
                int sum=0; 
                sum += num;
                average = sum / nums.Length;
            }
            return average;
        }

        public int SumArray(int[] nums)
        {
            int sum = 0;
            foreach (int num in nums)
            {
                sum += num;
            }
            return sum;
        }
    }
}
