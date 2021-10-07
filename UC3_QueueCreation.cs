using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructurePrograms
{      
    class UC3_QueueCreation
    {
            class Node
            {
                public int data;
                public Node next;
                public Node(int data)
                {
                    this.data = data;
                    next = null;
                }
            }

            Node head = null;
            internal void Enqueue(int data)
            {
                Node node = new Node(data);
                if (head == null)
                    head = node;
                else
                {
                    Node temp = head;
                    while (temp.next != null)
                    {
                        temp = temp.next;
                    }
                    temp.next = node;
                }
                Console.WriteLine("{0} inserted into queue ", node.data);

            }
           
            internal void Display()
            {
                Node temp = this.head;
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
