using System;

namespace _9DetectCyclenLL
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
            //n3.next = h1;
            Solution s = new Solution();
            bool hasCycle = s.DetectCycleInLL(h1);
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
        public bool DetectCycleInLL(Node head)
        {
            Node pointer1 = head;
            Node pointer2 = head;
            bool cycle = false;
            while (pointer2 != null && pointer2.next != null)
            {
                pointer1 = pointer1.next;
                pointer2 = pointer2.next.next;
                if (pointer1.Equals(pointer2))
                {
                    cycle = true;
                    break;
                }
            }
            return cycle;
        }
    }
}
