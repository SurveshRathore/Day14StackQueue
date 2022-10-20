using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14StackAndQueue
{
    class Queue
    {
        public int data;
        public Queue next;
        public Queue(int data)
        {
            this.data = data;
        }
    }
}
