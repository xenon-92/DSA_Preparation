using System;

namespace NumberOfTimesAGivenIntOccurs
{
    class Program
    {
        static void Main(string[] args)
        {
            Node head = new Node(1);
            Node n1 = new Node(2);
            Node n2 = new Node(1);
            Node n3 = new Node(3);
            Node n4 = new Node(1);
            head.next = n1;
            n1.next = n2;
            n2.next = n3;
            n3.next = n4;
            Solution s = new Solution();
            int count = s.NoOccurence(head,22);
            Console.WriteLine(count);
        }
    }
    class Node
    {
        public int value;
        public Node next;
        public Node(int val)
        {
            this.value = val;
            this.next = null;
        }
    }
    class Solution
    {
        public int NoOccurence(Node head, int val)
        {
            int count = 0;
            Node current = head;
            while (current != null)
            {
                if (current.value == val)
                {
                    count += 1;
                }
                current = current.next;
            }
            return count;
        }
    }
}
