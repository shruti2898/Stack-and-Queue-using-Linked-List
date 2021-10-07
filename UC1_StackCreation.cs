using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructurePrograms
{
    class UC1_StackCreation
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
        public UC1_StackCreation()
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
    }
}
