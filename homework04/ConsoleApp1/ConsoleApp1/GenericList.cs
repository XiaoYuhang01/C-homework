using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class GenericList<T>
    {
        private LinkNode<T> head;
        private LinkNode<T> tail;
       
        public GenericList()
        {
            tail = head = null;
        }
        
        public  T headData
        {
            get => head.Data;
        }

        public LinkNode<T> Head { get => head; }

        public void Add(T t)
        {
            LinkNode<T> n = new LinkNode<T>(t);
            if(tail == null) { head = tail = n; }
            else
            {
                tail.Next = n;
                tail = n;
            }
        }

        public void ForEach(Action<T> action)
        {
            LinkNode<T> p = head;
            while(p != null)
            {
                action(p.Data);
                p = p.Next;
            }
        }

        
        
    }
}
