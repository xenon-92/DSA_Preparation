using System;

namespace _9PrintTheValueOfLLInRecursiveOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            Node head = new Node(1);
            Node n1 = new Node(2);
            Node n2 = new Node(3);
            Node n3 = new Node(4);
            head.next = n1;
            n1.next = n2;
            n2.next = n3;
            PrintNode.PrintFwd(head);
            PrintNode.PrintReverse(head);
        }
    }
    class Node
    {
        public int val;
        public Node next;
        public Node(int val)
        {
            this.val = val;
            this.next = null;
        }
    }
    class PrintNode
    {
        public static void PrintFwd(Node n)
        {
            if (n == null)
            {
                Console.WriteLine("end of printing....");
                return;
            }
            Console.Write(n.val);
            PrintFwd(n.next);
        }
        public static void PrintReverse(Node n)
        {
            if (n == null)
            {
                return;
            }
            PrintReverse(n.next);
            Console.Write(n.val);
        }
    }
}
