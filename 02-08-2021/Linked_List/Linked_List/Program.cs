using System;

namespace Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            SinglyLinkedList singly = new SinglyLinkedList();
            singly.AddNode(1);
            singly.AddNode(2);
            singly.AddNode(3);
            singly.AddNode(4);
            singly.AddNode(5);

            singly.DeleteNode(singly, 3);

            singly.Display();
        }
    }

    public class Node
    {
        public int Data;
        public Node Next;

        public Node() { }

        public Node(int data)
        {
            this.Data = data;
            this.Next = null;
        }
    }

    public class SinglyLinkedList
    {
        public Node head;
        public Node tail;

        public void AddNode(int data)
        {
            Node myNode = new Node(data);
            if(head == null)
            {
                head = myNode;
                tail = myNode;
            }
            else
            {
                tail.Next = myNode;
                tail = myNode;
            }
        }

        public void DeleteNode(SinglyLinkedList list,int key)
        {
            Node temp = list.head;
            Node previous = null;
            if(temp != null && temp.Data == key)
            {
                list.head = temp.Next;
                return;
            }

            while(temp != null && temp.Data != key)
            {
                previous = temp;
                temp = temp.Next;
            }

            if(temp == null)
            {
                return;
            }

            previous.Next = temp.Next;
        }

        public void Display()
        {
            Node current = head;

            if(head == null)
            {
                Console.WriteLine("The list is null");
                return;
            }

            while(current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }
        }
    }

    

