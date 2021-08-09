using System;
using static DoublyLinkedList;

namespace Doubly_LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            DoublyLinkedList value = new DoublyLinkedList();
            value.addFirst(20);
            value.addFirst(30);
            value.addFirst(40);
            value.addFirst(50);
            value.printlist(value.head);
            value.remove(value.head);
            value.printlist(value.head);
            value.Size(value.head);
            value.Traverse();
        }
    }
}

public class DoublyLinkedList
{
    public Node head;
    public class Node
    {
        public int data { get; set; }
        public Node previous { get; set; }
        public Node next { get; set; }

        public Node() { }
        public Node(int d)
        {
            this.data = d;
        }
    }

    public void addFirst(int newValue)
    {
        Node value = new Node(newValue);
        value.previous = null;
        value.next = head;

        if (head != null)
        {
            head.previous = value;
        }

        head = value;
    }

    public void printlist(Node node)
    {
        
        while (node != null)
        {
            Console.Write(node.data + " ");
            node = node.next;    
        }
        Console.WriteLine();
    }

    public int Size(Node node)
    {
        int res = 0;
        while(node != null)
        {
            res++;
            node = node.next;
        }
        return res;
    }

    public void remove(Node del)
    {
        if(head == null || del == null)
        {
            return;
        }

        if(head == del)
        {
            head = del.next;
        }

        if(del.next != null)
        {
            del.next.previous = del.previous;
        }

        if(del.previous != null)
        {
            del.previous.next = del.next;
        }

        return;
    }

    public void Traverse()
    {
        if(head == null)
        {
            Console.WriteLine("Linked list is null");
            return;
        }

        else
        {
            Node temp = head;
            for(int i=0;i<Size(head);i++)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }

        Console.WriteLine("\n");
    }

}


