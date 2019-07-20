using LinkedList;
using StacksQueues;
using System;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            //CreateAndShowLinkedList();
            //CreateAndShowStack();
            CreateAndShowQueue();
            Console.Read();
        }

        static void CreateAndShowLinkedList()
        {
            Node headNode = new Node(2);
            headNode.AppendToTail(1);
            headNode.AppendToTail(3);
            headNode.AppendToTail(5);
            headNode.AppendToTail(4);

            headNode.ShowAllNodes();
           
            headNode.DeleteNode(1);

            headNode.ShowAllNodes();
        }

        static void CreateAndShowStack()
        {
            Stack<int> stack = new Stack<int>();
            Console.WriteLine($"Is empty? {stack.IsEmpty()}");

            Console.WriteLine("Add 3");
            stack.Push(3);

            Console.WriteLine("Add 2");
            stack.Push(2);

            Console.WriteLine($"Peek {stack.Peek()}");

            Console.WriteLine("Pop");
            stack.Pop();

            Console.WriteLine($"Peek {stack.Peek()}");

            Console.WriteLine($"Is empty? {stack.IsEmpty()}");

            Console.WriteLine("Pop");
            stack.Pop();

            Console.WriteLine($"Is empty? {stack.IsEmpty()}");
        }

        static void CreateAndShowQueue()
        {
            Queue<int> stack = new Queue<int>();
            Console.WriteLine($"Is empty? {stack.IsEmpty()}");

            Console.WriteLine("Add 3");
            stack.Add(3);

            Console.WriteLine("Add 2");
            stack.Add(2);

            Console.WriteLine($"Peek {stack.Peek()}");

            Console.WriteLine("Pop");
            stack.Remove();

            Console.WriteLine($"Peek {stack.Peek()}");

            Console.WriteLine($"Is empty? {stack.IsEmpty()}");

            Console.WriteLine("Pop");
            stack.Remove();

            Console.WriteLine($"Is empty? {stack.IsEmpty()}");
        }
    }
}
