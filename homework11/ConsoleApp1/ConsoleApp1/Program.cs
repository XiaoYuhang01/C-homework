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
            Console.WriteLine("--------------------欢迎使用订单管理系统---------------");
            

            OrderService ServiceExample = new OrderService();
/*            string[] order1 = new string[2]{" 吉米诺维奇数学分析", "饥荒联机版"};
            string[] order2 = new string[1] { "圣经选读" };
            string[] order3 = new string[1] { "Counter-Strike Global Offensive"};
            ServiceExample.AddOrder(1, "李奇伟", order1);
            ServiceExample.AddOrder(2, "丛兴柏", order2);
          ServiceExample.AddOrder(3, "杜特", order3);
*/
            ServiceExample.OrderList.Sort(new NumberCompare());
            string a = "";
            do
            {
                Console.WriteLine("请选择服务类型:");
                Console.WriteLine("1.新增订单  3.查询订单 4.修改订单"); //2.删除订单
                string i = Console.ReadLine();

                switch (i)
                {
                    case "1":
                        ServiceExample.Add();
                        break;

                    case "2":
                        //ServiceExample.DeletOrder();
                        break;

                    case "3":
                        ServiceExample.Search();
                        break;

                    case "4":
                        ServiceExample.ModifyOrder();
                        break;
                }
                Console.WriteLine("是否继续使用系统？1.是2.否");
                a = Console.ReadLine();
            } while (a == "1");
            
        }
    }
}
