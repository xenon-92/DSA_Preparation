using System;

namespace _14ReverseLLIterative
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
            Node result = s.ReversALL(h1);
        }
    }
    class Node
    {
        int val;
        public Node next;
        public Node(int val)
        {
            this.val = val;
            this.next = null;
        }
    }
    class Solution
    {
        public Node  ReversALL(Node head)
        {
            Node prev = null;Node current = head;Node next = null;
            while (current!=null)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }
            return prev;
        }
    }
}
