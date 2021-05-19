using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class OrderException:ApplicationException
    {
        private int idnumber;
        public OrderException(string message, int id):base(message)
        {
            this.idnumber = id;
        }
        public int getId()
        {
            return idnumber;
        }

    }
}
