using System;

namespace _11ReverseLLofGivenSize
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
            ReverseLLOfGivenSize rLL = new ReverseLLOfGivenSize();
            var res = rLL.ReverseinGivenSize(head, 3);
        }
    }
    class Node
    {
        public int val;
        public Node next;
        public Node(int val)
        {
            this.next = null;
            this.val = val;
        }
    }
    class ReverseLLOfGivenSize
    {
        public Node ReverseinGivenSize(Node head, int k)
        {
            Node prev = null;
            Node current = head;
            Node next = null;
            int count = 0;
            while (current != null && count < k)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
                count += 1;
            }
            if (next != null)
            {
                head.next = ReverseinGivenSize(next, k);
            }
            return prev;
        }
    }
}
