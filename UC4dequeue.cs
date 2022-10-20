using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Day14StackAndQueue
{
    internal class UC4dequeue
    {
        Queue head = null;

        internal void Enqueue(int data)
        {
            Queue node = new Queue(data);
            if (head == null)
                head = node;
            else
            {
                
                Queue temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into queue ", node.data);
        }

        internal void Dequeu()
        {
            if (head == null)
            {
                Console.WriteLine("Queue is empty");
            }
            else
            {
                Console.WriteLine("The Deque element is : " + head.data);
                head = head.next;

            }
        }

        internal void Display()
        {
            Queue temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Queue is empty");
                return;

            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
