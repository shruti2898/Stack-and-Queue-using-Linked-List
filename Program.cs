using System;

namespace DataStructurePrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            UC1_StackCreation stack = new UC1_StackCreation();
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            stack.Display();

            UC2_RemoveElementsFromStack stack2 = new UC2_RemoveElementsFromStack();
            stack2.Push(70);
            stack2.Push(30);
            stack2.Push(56);
            stack2.Display();
            stack2.Peek();
            stack2.Pop();
            stack2.Peek();
            stack2.Pop();
            stack2.Peek();
            stack2.Pop();
            stack2.Peek();

            UC3_QueueCreation queue = new UC3_QueueCreation();
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);
            queue.Display();

            UC4_RemoveElementsFromQueue queue2 = new UC4_RemoveElementsFromQueue();
            queue2.Enqueue(56);
            queue2.Enqueue(30);
            queue2.Enqueue(70);
            queue2.Display();
            queue2.Dequeue();
            queue2.Display();
            queue2.Dequeue();
            queue2.Display();
            queue2.Dequeue();
            queue2.Display();

            Console.ReadKey();
        }
    }
}
