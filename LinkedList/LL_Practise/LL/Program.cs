using System;

namespace LL
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
            int countI = s.CountNodeIterative(h1);
            int countR = s.CountRecursive(h1);

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
        public int CountNodeIterative(Node head)
        {
            Node current = head;
            int count = 0;
            if (current == null)
            {
                return count;
            }
            while (current != null)
            {
                count += 1;
                current = current.next;
            }
            return count;
        }
        public int CountRecursive(Node head)
        {
            if (head == null)
            {
                return 0;
            }
            return 1 + CountRecursive(head.next);
        }
    }

}
