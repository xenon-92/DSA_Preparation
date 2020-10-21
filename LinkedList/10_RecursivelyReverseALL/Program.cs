using System;

namespace _10_RecursivelyReverseALL
{
    class Program
    {
        static void Main(string[] args)
        {
            Node head = new Node(1);
            Node n1 = new Node(2);
            Node n2 = new Node(3);
            Node n3 = new Node(4);
            Node n4 = new Node(5);
            Node n5 = new Node(6);
            Node n6 = new Node(7);
            head.next = n1;
            n1.next = n2;
            n2.next = n3;
            n3.next = n4;
            n4.next = n5;
            n5.next = n6;
            ReverseLLRecursive rLL = new ReverseLLRecursive();
            rLL.Reverse(head);
        
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
    class ReverseLLRecursive
    {
        public Node newHead = null;
        public void Reverse(Node n)
        {
            if (n.next == null)
            {
                newHead = n;
                return;
            }
            Reverse(n.next);
            Node q = n.next;
            q.next = n;
            n.next = null;
        }
    }
}
