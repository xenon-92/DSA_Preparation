using System;

namespace _16ReverseALLInGroups
{
    // ip  1-2-3-4-5-6-7-8-9
    //op   3-2-1-6-5-4-9-8-7
    class Program
    {
        static void Main(string[] args)
        {
            Node h = new Node(1);
            Node n1 = new Node(2);
            Node n2 = new Node(3);
            Node n3 = new Node(4);
            Node n4 = new Node(5);
            Node n5 = new Node(6);
            Node n6 = new Node(7);
            Node n7 = new Node(8);
            Node n8 = new Node(9);
            h.next = n1;
            n1.next = n2;
            n2.next = n3;
            n3.next = n4;
            n4.next = n5;
            n5.next = n6;
            n6.next = n7;
            n7.next = n8;
            Solution s = new Solution();
            Node result = s.ReverseLlInGroups(h,4);
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
    class Solution
    {
        public Node ReverseLlInGroups(Node head, int k)
        {
            Node prev = null; Node current = head; Node next = null; int count = 0;
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
                head.next = ReverseLlInGroups(next,k);
            }
            return prev;
        }
    }
}
