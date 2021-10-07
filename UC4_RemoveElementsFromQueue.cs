﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructurePrograms
{
    class UC4_RemoveElementsFromQueue
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

        internal void Dequeue()
        {
            if (head == null)
                Console.WriteLine("\nQueue is empty.");
            else
            {  
                Console.WriteLine("\n{0} removed from queue.",head.data);
                head = head.next;
            }
        }

        internal void Display()
        {
            Node temp = head;
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
