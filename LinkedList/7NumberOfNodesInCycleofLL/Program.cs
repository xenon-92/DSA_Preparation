using System;

namespace _7NumberOfNodesInCycleofLL
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
            n6.next = n2;
            Solution s = new Solution();
            int count = s.NumberOfNodesInCycle(head);
            Console.WriteLine(count);
        }
    }
    class Node
    {
        public int value;
        public Node next;
        public Node(int value)
        {
            this.next = null;
            this.value = value;
        }
    }
    class Solution
    {
        public int NumberOfNodesInCycle(Node head)
        {

            if (head == null)
            {
                return -1;
            }
            //detect if a cycle is present
            bool isCycle = false;
            Node pointer1 = head;
            Node pointer2 = head;
            while (pointer1 != null && pointer2 != null && pointer2.next != null)
            {
                pointer1 = pointer1.next;
                pointer2 = pointer2.next.next;
                if (pointer1.Equals(pointer2))
                {
                    //cycle
                    isCycle = true;
                    break;
                }
            }
            if (isCycle)
            {
                return CountNodes(pointer1, pointer2);
            }
            return -1;
        }
        private int CountNodes(Node pointer1, Node pointer2)
        {
            int count = 1;
            pointer1 = pointer1.next;
            while (!pointer1.Equals(pointer2))
            {
                count += 1;
                pointer1 = pointer1.next;
            }
            return count;
        }
    }
}
