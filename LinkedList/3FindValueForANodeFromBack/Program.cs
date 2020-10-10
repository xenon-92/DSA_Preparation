using System;

namespace _3FindValueForANodeFromBack
{
    class Program
    {
        static void Main(string[] args)
        {
            Node head = new Node(1);
            Node n1 = new Node(11);
            Node n2 = new Node(111);
            Node n3 = new Node(1111);
            Node n4 = new Node(11111);
            head.next = n1;
            n1.next = n2;
            n2.next = n3;
            n3.next = n4;
            Solution s = new Solution();
            int result = s.GetValueFromEnd(head, 0);
            Console.WriteLine(result);
        }
    }
    class Node
    {
        public int value;
        public Node next;
        public Node(int val)
        {
            this.next = null;
            this.value = val;
        }
    }
    //Program for n’th node from the end of a Linked List
    //ex: find the value for 2nd node from back
    class Solution
    {
        public int GetValueFromEnd(Node head, int backNode)
        {
            //edge case
            if (backNode < 1)
            {
                return -1;
            }
            //nth node from back is Length - backPos from front
            int length = 0;
            Node current = head;
            while (current != null)
            {
                length += 1;
                current = current.next;
            }
            if (backNode > length)
            {
                return -1;
            }
            int frontPos = length - backNode;
            int pos = 0;
            current = head;
            while (current != null)
            {
                if (pos == frontPos)
                {
                    break;
                }
                current = current.next;
                pos += 1;
            }
            return current.value;
        }
    }
}
