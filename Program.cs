using Day14StackAndQueue;
Console.WriteLine("------------UC1 Create a Stack using Linked List---------------");
UC1Stack linkedListStack = new();
linkedListStack.Push(70);
linkedListStack.Push(30);
linkedListStack.Push(56);

linkedListStack.Display();
Console.WriteLine("\n----------UC2 to Perform the peek and pop on the stack ");
UC2PeakPopStack peakAndPopStack = new();
peakAndPopStack.Push(70);
peakAndPopStack.Push(30);
peakAndPopStack.Push(56);
peakAndPopStack.Display();
Console.WriteLine("\n----------------Performing Peek on the stack.--------------");
peakAndPopStack.Peek();
peakAndPopStack.Peek();
Console.WriteLine("----------------Performing pop on the stack.----------------");
peakAndPopStack.Pop();
peakAndPopStack.Pop();
peakAndPopStack.Pop();
peakAndPopStack.Pop();

Console.WriteLine("------------UC3 Create a Queue using Linked List---------------");
UC3Queue linkedListQueue = new();
linkedListQueue.Enqueue(56);
linkedListQueue.Enqueue(30);
linkedListQueue.Enqueue(70);

linkedListQueue.Display();

Console.WriteLine("------------UC4 Create a dequeue for the Queue using Linked List---------------");
UC4dequeue dequeue = new();
dequeue.Enqueue(56);
dequeue.Enqueue(30);
dequeue.Enqueue(70);
dequeue.Display();

dequeue.Dequeu();
dequeue.Dequeu();
dequeue.Dequeu();
dequeue.Dequeu();
dequeue.Dequeu();
