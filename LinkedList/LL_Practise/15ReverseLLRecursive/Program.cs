using System;

namespace _15ReverseLLRecursive
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
            Node result = s.ReverseLL(n3);
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
        Node Head;
        public Node ReverseLL(Node head)
        {
            if (head == null)
            {
                return Head;
            }
            RecursiveReverse(head);
            return Head;
        }
        private void RecursiveReverse(Node head)
        {
            if (head.next == null)
            {
                Head = head;
                return;
            }
            RecursiveReverse(head.next);
            Node p = head;
            Node q = head.next;
            q.next = p;
            p.next = null;
        }
    }
}
