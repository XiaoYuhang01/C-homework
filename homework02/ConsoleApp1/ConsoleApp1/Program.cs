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
            Console.WriteLine("请输入一个整数");
            string initNum = Console.ReadLine();
            int num = int.Parse(initNum);

            Console.WriteLine("所有素数因子如下");
            if (num >= 2)
            {
                for (int factor = 2; factor <= num; factor++)
                {
                    if (num % factor == 0 && Prime(factor))
                    {
                        Console.WriteLine(factor);
                    }
                }
            }
            else
                Console.WriteLine("Wrong");
            
        }

        public static bool Prime(int a)
        {
            int factor = 2;
            for(factor = 2; a >= factor; factor++)
            {
                if(a%factor == 0)
                {
                    break;
                }
             }
            if(factor == a)
            { return true; }
            else
            { return false; }
        }
            
        
    }
}
