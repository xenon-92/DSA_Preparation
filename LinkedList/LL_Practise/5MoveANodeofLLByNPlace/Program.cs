using System;

namespace _5MoveANodeofLLByNPlace
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
            Node result = s.MoveNodeOfLLBynPlace(n1,3);
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
        public Node MoveNodeOfLLBynPlace(Node head, int posUp)
        {
            if (head == null || posUp < 0) return null;
            Node current = head; int currentPos = 0;
            while (current != null && currentPos < posUp)
            {
                current = current.next;
                currentPos += 1;                                                                                                                                                                                                                                                       
            }
            return current;
        }
    }
}
