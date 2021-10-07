using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructurePrograms
{
    class UC2_RemoveElementsFromStack
    {
        class Node
        {
            public int data;
            public Node next;
            public Node(int data)
            {
                this.data = data;

            }
        }

        private Node top;
        public UC2_RemoveElementsFromStack()
        {
            this.top = null;
        }

        public void Push(int value)
        {
            Node node = new Node(value);
            if (this.top == null)
                node.next = null;
            else
                node.next = this.top;
            this.top = node;
            Console.WriteLine("{0} pushed to stack ", value);
        }
        public void Display()
        {
            Node temp = this.top;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;//1400
            }
        }

        public void Peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            Console.WriteLine("\n{0} is in the top of the stack ", this.top.data);
        }

        public void Pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty, Deletion is not possible");
                return;
            }
            Console.WriteLine("Value popped is {0} ", this.top.data);
            this.top = this.top.next;
        }

        public void IsEmpty()
        {
            while (this.top != null)
            {
                Peek();
                Pop();
            }
            Console.WriteLine("\nStack is empty");
        }
    }
}
