using System;

namespace _10DetectCycleReturnBeginningOfCycle
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
            n3.next = n2;
            Solution s = new Solution();
            Node result = s.GetStartingPointOfCycle(h1);
        }
    }
    class Node
    {
        public Node next;
        public int val;
        public Node(int val)
        {
            this.val = val;
        }
    }
    class Solution
    {
        public Node GetStartingPointOfCycle(Node head)
        {
            bool cycle = false;
            Node p1 = head;
            Node p2 = head;
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
            if (!cycle) return null;
            if (cycle)
            {
                p2 = head;
                while (p1 != p2)
                {
                    p1 = p1.next;
                    p2 = p2.next;
                }
            }
            return p1;
        }
    }
}
