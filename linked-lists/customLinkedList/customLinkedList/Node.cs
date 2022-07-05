using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customLinkedList
{
    public class Node
    {
        public Node next = null;
        public object value = null;

        public Node(object value)
        {
            this.value = value;
        }
        public void Print()
        {
            Console.Write(value + " -> ");
            if (next != null)
                next.Print();
            else
                Console.WriteLine("[end]");
        }
        public void AddToEnd(object PoValue)
        {
            if (next == null)
                next = new Node(PoValue);
            else
                next.AddToEnd(PoValue);
        }
    }
}