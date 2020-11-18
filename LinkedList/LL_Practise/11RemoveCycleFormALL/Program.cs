using System;

namespace _11RemoveCycleFormALL
{
    class Program
    {
        static void Main(string[] args)
        {
            Node h1 = new Node(1);
            Node n1 = new Node(2);
            Node n2 = new Node(3);
            Node n3 = new Node(4);
            h1.next = h1;
            n1.next = n2;
            n2.next = n3;
            n3.next = h1;
            Solution s = new Solution();
            s.RemoveCycleFromLL(h1);
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
        Node p1 = null;
        Node p2 = null;
        public void RemoveCycleFromLL(Node head)
        {
            bool hasCycle = IsCyclePresent(head);
            if (hasCycle)
            {
                p2 = head;
                while (p1 != p2)
                {
                    p1 = p1.next;
                    p2 = p2.next;
                }
                //now p1 and p2 sit on then starting point of the cycle
                p2 = p2.next;
                while (p2.next!=p1)
                {
                    p2 = p2.next;
                }
                p2.next = null;
            }
        }
        private bool IsCyclePresent(Node head)
        {
            bool cycle = false;
            p1 = head;
            p2 = head;
            while (p2 != null && p2.next != null)
            {
                p1 = p1.next;
                p2 = p2.next.next;
                if (p1 == p2)
                {
                    cycle = true;
                    break;
                }
            }
            return cycle;
        }
    }
}
