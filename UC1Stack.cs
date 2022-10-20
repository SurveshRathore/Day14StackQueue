using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Day14StackAndQueue
{
    internal class UC1Stack
    {
        private Stack top;
        public void StackUsingLinkedList()
        {
            this.top = null;
        }
        internal void Push(int item)
        {
            Stack node = new Stack(item);
            if (this.top == null)
            {
                node.next = null;
            }              
            else
            {
                node.next = this.top;
            }                
            this.top = node;
            Console.WriteLine("{0} pushed to stack ", item);
        }

        public void Display()
        {
            Stack temp = this.top;
            while (temp != null)
            {
                Console.Write(temp.data + " "); //56 30 70 
                temp = temp.next;//1400
            }
        }
    }
}
