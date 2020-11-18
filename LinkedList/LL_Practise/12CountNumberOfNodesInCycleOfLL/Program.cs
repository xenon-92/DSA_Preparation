using System;

namespace _12CountNumberOfNodesInCycleOfLL
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
            n3.next = n3;
            Solution s = new Solution();
            int result = s.CountNoOfNodesInCycle(h1);
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
        Node p1;Node p2;
        public int CountNoOfNodesInCycle(Node head)
        {
            bool hasCycle = HasCycle(head);
            if (hasCycle)
            {
                p1 = head;
                while (p1!=p2)
                {
                    p1 = p1.next;
                    p2 = p2.next;
                }
                //after this both the pointers sit on the starting point of the loop
                int count = 1;
                p1 = p1.next;
                while (p1!=p2)
                {
                    p1 = p1.next;
                    count += 1;
                }
                return count;

            }
            return -1;
        }
        private bool HasCycle(Node head)
        {
            bool cycle = false;
            p1 = head;
            p2 = head;
            while (p2 != null && p2.next != null)
            {
                p1 = p1.next;
                p2 = p2.next.next;
                if (p1==p2)
                {
                    cycle = true;
                    break;
                }
            }
            return cycle;
        }
    }
}
