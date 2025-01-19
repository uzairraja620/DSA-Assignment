using System;

// Node class
class Node
{
    public int Value;
    public Node Next;

    public Node(int value)
    {
        Value = value;
        Next = null;
    }
}

class Stack
{
    private Node head;

    public Stack()
    {
        head = null;
    }

    public void Push(int value)
    {
        Node newNode = new Node(value);
        newNode.Next = head;
        head = newNode;
        Console.WriteLine($"Pushed {value} to the stack.");
    }

    public int Pop()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Stack is empty!");
            return -1;
        }
        int value = head.Value;
        head = head.Next;
        return value;
    }

    public int Peek()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Stack is empty!");
            return -1;
        }
        return head.Value;
    }

    public bool IsEmpty()
    {
        return head == null;
    }
}


class Queue
{
    private Node front;
    private Node rear;

    public Queue()
    {
        front = rear = null;
    }

    public void Enqueue(int value)
    {
        Node newNode = new Node(value);
        if (rear == null)
        {
            front = rear = newNode;
        }
        else
        {
            rear.Next = newNode;
            rear = newNode;
        }
        Console.WriteLine($"Enqueued {value} to the queue.");
    }

    public int Dequeue()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Queue is empty!");
            return -1;
        }
        int value = front.Value;
        front = front.Next;
        if (front == null)
            rear = null;
        return value;
    }

    public int Peek()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Queue is empty!");
            return -1;
        }
        return front.Value;
    }

    public bool IsEmpty()
    {
        return front == null;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Stack Operations:");
        Stack stack = new Stack();
        stack.Push(5);
        stack.Push(15);
        stack.Push(25);
        Console.WriteLine($"Top of stack: {stack.Peek()}");
        Console.WriteLine($"Popped from stack: {stack.Pop()}");
        Console.WriteLine($"Top of stack: {stack.Peek()}");

        Console.WriteLine("\nQueue Operations:");
        Queue queue = new Queue();
        queue.Enqueue(5);
        queue.Enqueue(15);
        queue.Enqueue(25);
        Console.WriteLine($"Front of queue: {queue.Peek()}");
        Console.WriteLine($"Dequeued from queue: {queue.Dequeue()}");
        Console.WriteLine($"Front of queue: {queue.Peek()}");
    }
}