using System;

namespace _3NthNodeFromEnd
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
            Node result = s.GetNthNodeFromEnd(h1,14);
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
        public Node GetNthNodeFromEnd(Node head, int idxFromEnd)
        {
            if (idxFromEnd < 0)
                return null;
            int length = 0;
            Node current = head;
            while (current != null)
            {
                length += 1;
                current = current.next;
            }
            if (length - idxFromEnd < 0)
            {
                return null;
            }
            Node result = null; current = head;int pos = 0;
            while (current != null)
            {
                if (length - idxFromEnd == pos)
                {
                    result = current;
                    break;
                }
                current = current.next;
                pos += 1;
            }
            return result;
        }
    }
}
