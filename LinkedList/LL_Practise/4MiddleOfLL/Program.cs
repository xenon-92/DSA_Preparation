using System;

namespace _4MiddleOfLL
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
            Node result = s.MiddleOfLL(h1);
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
        public Node MiddleOfLL(Node head)
        {
            Node result = null; Node current = head;
            if (head == null) return result;
            int length = GetLength(current);
            int middlePos = length / 2; int currentPos = 0;
            current = head;
            while (current != null)
            {
                if (middlePos == currentPos)
                {
                    result = current;
                    break;
                }
                current = current.next;
                currentPos += 1;
            }
            return result;

        }
        private int GetLength(Node head)
        {
            if (head == null)
            {
                return 0;
            }
            return 1 + GetLength(head.next);
        }
    }
}
