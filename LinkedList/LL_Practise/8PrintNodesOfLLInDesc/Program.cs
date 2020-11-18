using System;

namespace _8PrintNodesOfLLInDesc
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
            s.PrintNodesDesc(h1);
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
        public void PrintNodesDesc(Node head)
        {
            if (head == null)
            {
                Console.WriteLine("end of LL");
                return;
            }
            PrintNodesDesc(head.next);
            Console.WriteLine(head.val);
        }
    }
}
