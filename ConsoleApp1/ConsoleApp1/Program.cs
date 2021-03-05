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
            Console.WriteLine("请输入第一个数字：");
            string A = Console.ReadLine();
            int a = Int32.Parse(A);

            Console.WriteLine("请输入第二个数字：");
            string B = Console.ReadLine();
            double b = Double.Parse(B);
          

            Console.WriteLine("请选择进行的操作:1.加 2.减 3.乘 4.除");
            string C = Console.ReadLine();
            double c = Double.Parse(C);

            double d = 0;
            
            if (c == 1) d = a + b;
            if (c == 2) d = a - b;
            if (c == 3) d = a * b;
            if (c == 4) d = a / b;

            Console.WriteLine($"结果是:{d}");


        }
    }
}
