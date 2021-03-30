using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
        public class LinkNode<T>
        {
            public LinkNode<T> Next { get; set; }
            public T Data { get; set; }

            public LinkNode(T t)
            {
                Next = null;
                Data = t;
            }
        }

}
