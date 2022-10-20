using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14StackAndQueue
{
    internal class UC2PeakPopStack
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

        //Peek() returns the top item from the stack 
        internal void Peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            Console.WriteLine("{0} is in the top of the stack ", this.top.data);//NullrefrenceRxception
        }
        
        //Pop() removes the top item from the stack
        internal void Pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty, Deletion is not possible");
                return;
            }
            Console.WriteLine("Value popped is {0} ", this.top.data);
            this.top = this.top.next;
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
