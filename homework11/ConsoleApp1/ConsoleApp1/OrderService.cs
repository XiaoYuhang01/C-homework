using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace ConsoleApp1
{
    public class OrderService
    {
        public List<Order> OrderList
        {
            get
            {
                using (var orderctx = new OrderContext())
                {
                    var result = orderctx.Orders.Include(o => o.OrderDetailsList.Select(d => d.CargoExample)).Include("Customer");
                    return result.ToList<Order>();
                }
            }

        }//一个包含所有订单对象的列表
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

                using (var orderctx = new OrderContext())
                {
                    orderctx.Entry(order1).State = EntityState.Added;
                    orderctx.SaveChanges();
                }
            
        }

        //      按订单号查询
        public Order SearchByNumber(int h)
        {
            using (var orderctx = new OrderContext())
            {
                var result = orderctx.Orders.Include(o => o.OrderDetailsList.Select(d => d.CargoExample)).Include("Customer")
                  .SingleOrDefault(o => o.orderNumber == h);
                return result;
            }
        }

        //      按商品名称查询
        public List<Order> SearchByCargo(string h)
        {
            using (var orderctx = new OrderContext())
            {
                var result = orderctx.Orders.Include(o => o.OrderDetailsList.Select(d => d.CargoExample)).Include("Customer")
                    .Where(order => order.OrderDetailsList.Any(item => item.CargoExample.CargoName == h));
                return result.ToList();
            }
        }

        //      按客户查询
        public List<Order> SearchByClient(string h)
        {
            using (var orderctx = new OrderContext())
            {
                var result = orderctx.Orders.Include(o => o.OrderDetailsList.Select(d => d.CargoExample)).Include("Customer")
                  .Where(order => order.client.CustomerName == h).ToList();
                return result;
            }
        }

        //      按大于指定订单金额查询
        public List<Order> SearchMorethanAmount(double h)
        {
            using (var orderctx = new OrderContext())
            {
                var result = orderctx.Orders.Include(o => o.OrderDetailsList.Select(d => d.CargoExample)).Include("Customer")
                .Where(order => order.orderAmount > h);
                return result.ToList();
            }
        }

        //      按小于指定订单金额查询
        public List<Order> SearchLessthanAmount(double h)
        {
            using (var orderctx = new OrderContext())
            {
                var result = orderctx.Orders.Include(o => o.OrderDetailsList.Select(d => d.CargoExample)).Include("Customer")
                .Where(order => order.orderAmount < h);
                return result.ToList();
            }
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
                    Console.WriteLine(SearchByNumber(Int32.Parse(i1)));
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
        public void DeletOrder(int h)
        {
            using (var orderctx = new OrderContext())
            {
                var result = orderctx.Orders.Include("OrderDetailsList").SingleOrDefault(o => o.orderNumber == h);
                if (result == null) return;
                orderctx.OrderDetails.RemoveRange(result.OrderDetailsList);
                orderctx.Orders.Remove(result);
                orderctx.SaveChanges();
            }
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
