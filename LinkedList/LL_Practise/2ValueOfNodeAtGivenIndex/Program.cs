using System;

namespace _2ValueOfNodeAtGivenIndex
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
            int result = s.ValAtIndex(3, h1);
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
        public int ValAtIndex(int desiredPos, Node head)
        {
            if (desiredPos < 0)
            {
                return int.MinValue;
            }
            Node current = head; int pos = 0;
            int result = 0;bool found = false;
            while (current != null)
            {
                if (desiredPos == pos)
                {
                    result = current.val;
                    found = true;
                    break;
                }
                current = current.next;
                pos += 1;
            }
            if (!found)
                return int.MinValue;
            return result;
        }
    }
}
