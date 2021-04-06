using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class OrderService
    {
        public List<Order> OrderList = new List<Order>();      //一个包含所有订单对象的列表
        
        //      默认按订单号排序
        //      添加订单
        public void Add()
        {
            Console.Write("订单号 ");
            int orderExample = Int32.Parse(Console.ReadLine());
            Console.Write("客户名 ");
            string customerName = Console.ReadLine();
            Console.Write("客户地址 ");
            string customerAddress = Console.ReadLine();
            Console.Write("客户电话 ");
            string customerPhone = Console.ReadLine();

            int a = 1;
            List<string> cargo = new List<string>();
            List<int> number = new List<int>();
            List<double> price = new List<double>();
            while(a == 1)
            {
                Console.Write("货物 ");
                string cargoexample = Console.ReadLine();
                cargo.Add(cargoexample);

                Console.Write("货物数量 ");
                int cargonumber = Int32.Parse(Console.ReadLine());
                number.Add(cargonumber);

                Console.Write("货物价格 ");
                double priceexample = Double.Parse(Console.ReadLine());
                price.Add(priceexample);

                Console.WriteLine("是否继续添加货物？1.是2.否");
                a = Int32.Parse(Console.ReadLine()); 
            }

            AddOrder(orderExample, customerName, customerAddress, customerPhone, cargo, number, price);
        }
        public void AddOrder(int num, string name, string address, string phone, List<string> cargo, List<int> number, List<double> price)
        {
            string customerName = name;
            Customer customerExample = new Customer(customerName);
            customerExample.Address = address;
            customerExample.PhoneNumber = phone;
            List<Cargo> cargoexample = new List<Cargo>();
            for(int i = 0; i < cargo.Count(); i++)
            {
                cargoexample.Add(new Cargo(cargo[i], price[i]));
            }
            
            List<OrderDetails> DetailsExample = new List<OrderDetails>();
            for(int i=0;i<cargo.Count();i++)
            {
                DetailsExample.Add(new OrderDetails(cargoexample[i], number[i])); 
            }

            Order order1 = new Order(num, customerExample, DetailsExample);

            int n = 0;
            foreach (Order a in OrderList)
            {
                if (!order1.Equals(a)) { n++; }
            }
            if (n == OrderList.Count) { OrderList.Add(order1); }
            else { Console.WriteLine("该订单已经添加过"); }
        }

        //      按订单号查询
        public List<Order> SearchByNumber(int h)
        {
            var ResultByNumber = from a in OrderList
                                 where a.orderNumber == h
                                 orderby a.orderAmount 
                                 select a;
            return ResultByNumber.ToList();
        }

        //      按商品名称查询
        public List<Order> SearchByCargo(string h)
        {
            var ResultByCargo = from a in OrderList
                                where a.Search(h) == true
                                 orderby a.orderAmount
                                 select a;
            return ResultByCargo.ToList();
        }

        //      按客户查询
        public List<Order> SearchByClient(string h)
        {
            var ResultByClient = from a in OrderList
                                 where a.client.CustomerName == h
                                 orderby a.orderAmount
                                 select a;
            return ResultByClient.ToList();
        }

        //      按大于指定订单金额查询
        public List<Order> SearchMorethanAmount(double h)
        {
            var ResultMorethanAmount = from a in OrderList
                                 where a.orderAmount > h
                                 orderby a.orderAmount
                                 select a;
            return ResultMorethanAmount.ToList();
        }

        //      按大于指定订单金额查询
        public List<Order> SearchLessthanAmount(double h)
        {
            var ResultLessthanAmount = from a in OrderList
                                       where a.orderAmount < h
                                       orderby a.orderAmount
                                       select a;
            return ResultLessthanAmount.ToList();
        }

        public void Search()
        {
            Console.WriteLine("请选择查询类型:1.订单号 2.商品名称 3.客户名称 4.大于指定金额 5.小于指定金额");
            string i = Console.ReadLine();

            switch (i)
            {
                case "1":
                    Console.WriteLine("输入订单号");
                    string i1 = Console.ReadLine();
                    Console.WriteLine(SearchByNumber(Int32.Parse(i1)).First());
                    break;

                case "2":
                    Console.WriteLine("输入商品名称");
                    string i2 = Console.ReadLine();
                    foreach(Order a2 in SearchByCargo(i2)) { Console.WriteLine(a2); }
                    
                    break;

                case "3":
                    Console.WriteLine("输入客户名");
                    string i3 = Console.ReadLine();
                    foreach (Order a3 in SearchByClient(i3)) { Console.WriteLine(a3); }
                    break;

                case "4":
                    Console.WriteLine("输入指定金额");
                    string i4 = Console.ReadLine();
                    foreach (Order a4 in SearchMorethanAmount(double.Parse(i4))){ Console.WriteLine(a4); }
                    break;

                case "5":
                    Console.WriteLine("输入指定金额");
                    string i5 = Console.ReadLine();
                    foreach (Order a5 in SearchLessthanAmount(Double.Parse(i5))){ Console.WriteLine(a5); }
                    break;

                default:
                    Console.WriteLine("输入错误");
                    break;
            }


        }
        //      按订单号删除订单
        public void DeletOrder()
        {
            Console.WriteLine("请输入要删除的订单号");
            int h = Int32.Parse(Console.ReadLine());
            foreach (Order a in OrderList)
            {
                if (a.orderNumber == h) { OrderList.Remove(a); return; }
            }
            Console.WriteLine("需要删除的订单号不存在,请重新核实");
        }

        //      给定条件修改订单
        public void ModifyOrder()
        {
            Console.WriteLine("请选择你需要修改的项:1.客户名 2.客户地址 3.客户电话");
            string i;
            i = Console.ReadLine();

            switch(i)
            {
                case "1":
                    Console.WriteLine("请输入要修改的客户和修改后的客户名称");
                    string a1 = Console.ReadLine();
                    string b1 = Console.ReadLine();
                    if (SearchByClient(a1) != null)
                    {
                        foreach (Order c in SearchByClient(a1))
                        {
                            c.client.CustomerName = b1;
                        }
                    }
                    else
                        Console.WriteLine("未找到指定的客户名");
                    
                    break;

                case "2":
                    Console.WriteLine("请输入要修改的客户和修改后的客户地址");
                    string a2 = Console.ReadLine();
                    string b2 = Console.ReadLine();
                    if (SearchByClient(a2) != null)
                    {
                        foreach (Order c in SearchByClient(a2))
                        {
                            c.client.Address = b2;
                        }
                    }
                    else
                        Console.WriteLine("未找到指定的客户名");

                    break;

                case "3":
                    Console.WriteLine("请输入要修改的客户和修改后的客户电话");
                    string a3 = Console.ReadLine();
                    string b3 = Console.ReadLine();
                    if (SearchByClient(a3) != null)
                    {
                        foreach (Order c in SearchByClient(a3))
                        {
                            c.client.PhoneNumber = b3;
                        }
                    }
                    else
                        Console.WriteLine("未找到指定的客户名");

                    break;

                default:
                    Console.WriteLine("输入错误");
                    break;
            }
        }
    }
}
