using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Customer
    {
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

        public Customer(string CustomerName) { this.CustomerName = CustomerName; }
        public Customer() { }

        public override string ToString()
        {
            return CustomerName;
        }
    }
}
