using System;

namespace _7PrintAllNodesOfLL
{
    class Program
    {
        static void Main(string[] args)
        {
            Node h1 = new Node(1);
            Node n1 = new Node(2);
            Node n2 = new Node(3);
            Node n3 = new Node(4);
            h1.next = n1;
            n1.next = n2;
            n2.next = n3;
            Solution s = new Solution();
            s.PrintNodeAscIterative(h1);
            s.PrintNodesAscRecursive(h1);
            Console.ReadKey();
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
    class Solution
    {
        public void PrintNodeAscIterative(Node head)
        {
            Node current = head;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            while (current != null)
            {
                Console.WriteLine(current.val);
                current = current.next;
            }
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkRed;
        }
        public void PrintNodesAscRecursive(Node head)
        {
            if (head == null)
            {
                Console.ResetColor();
                return;
            }
            Console.WriteLine(head.val);
            PrintNodesAscRecursive(head.next);
        }
    }
}
