using System;

namespace LinkedList
{
    public class Node
    {
        public Node prev = null;
        public Node next = null;
        public int data;

        public Node(int d)
        {
            data = d;
        }

        public void AppendToTail(int d)
        {
            Node end = new Node(d);
            Node n = this;

            while (n.next != null)
            {
                n = n.next;
            }

            n.next = end;
            n.next.prev = n;
        }

        public Node DeleteNode(int d)
        {
            Node n = this;

            if (n.data == d)
            {
                return this.next;
            }

            while (n.next != null)
            {
                if (n.next.data == d)
                {
                    n.next = n.next.next;

                    if (n.next != null)
                    {
                        n.next.prev = n;
                    }
                    
                    return this;
                }
                n = n.next;
            }

            return this;
        }

        public void ShowAllNodes()
        {            
            Node node = this;
            Console.Write($"|__{this.data}__| {(node.next == null ? "  " : "=>")} ");
            while (node.next != null)
            {
                node = node.next;
                Console.Write($"|__{node.data}__| {(node.next == null ? "  " : "=>")} ");
            }
            Console.Write("\n");
            Console.Write($"|{(this.prev == null ? 0 : this.prev.data)} | {(this.next == null ? 0 : this.next.data)}|");
            Console.Write("    ");
            node = this;
            while (node.next != null)
            {
                node = node.next;
                Console.Write($"|{(node.prev == null ? 0 : node.prev.data)} | {(node.next == null ? 0 : node.next.data)}|");
                Console.Write("    ");
            }
            Console.Write("\n\n");
        }
    }
}
