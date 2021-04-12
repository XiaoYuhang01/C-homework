using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Order
    {
        public int orderNumber { get; }     //订单号
        public List<Cargo> tradeName { get; }     //商品名称
        public Customer client { get; }     //客户
        public double orderAmount {
            get {
                double sum = 0;
                foreach (OrderDetails OrderDetail in OrderDetailsList) { sum += OrderDetail.DetailPrice; }
                return sum;
            }
        }     //订单金额

        public List<OrderDetails> OrderDetailsList = new List<OrderDetails>();
        
        //      用于判定是否有指定货物的方法，方便在查询时调用
        public bool Search(string h)
        {
            foreach(OrderDetails a in OrderDetailsList)
            {
                if(a.CargoExample.CargoName == h) { return true; }
            }
            return false;
        }
        public Order(int num, Customer c, List<OrderDetails> details)
        {
            orderNumber = num;
            client = c;
            OrderDetailsList = details;
        } 

        public override string ToString()
        {
            string cargos = "";
            foreach (OrderDetails d in OrderDetailsList)
            {
                cargos = cargos +" " + d.CargoExample.CargoName;
            }
            return orderNumber + "|" + cargos + "|" + client + "|" + orderAmount; 
        }

        public override bool Equals(object obj)
        {
            Order orderExample = obj as Order;
            return orderExample != null && orderExample.orderNumber == orderNumber;
        }

        public override int GetHashCode()
        {
            return orderNumber;
        }
    }
}
