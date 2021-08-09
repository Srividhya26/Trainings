using System;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            QueueOperations val = new QueueOperations();
            val.enQueue(10);
            val.enQueue(20);
            val.enQueue(30);
            val.deQueue();
            val.deQueue();
        }
    }
}

class QueueNode
{
    public int key;
    public QueueNode next;

    public QueueNode(int key)
    {
        this.key = key;
        this.next = null;
    }
}

class QueueOperations
{
    QueueNode front, rear;

    public QueueOperations()
    {
        this.front = null;
        this.rear = null;
    }

    public void enQueue(int key)
    {
        QueueNode value = new QueueNode(key);
        if(this.rear == null)
        {
            this.front = value;
            this.rear = value;
            return;
        }

        this.rear.next = value;
        this.rear = value;
        Console.WriteLine(value.key);
    }

    public void deQueue()
    {
        if (this.front == null)
            return;

        QueueNode value = this.front;
        this.front = this.front.next;

        if(this.front == null)
        {
            this.rear = null;
        }
        Console.WriteLine(value.key);
    }
}
