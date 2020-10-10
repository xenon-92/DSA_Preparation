using System;

namespace LengthOfLL
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
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
            int result = s.LengthOfLL(null);
            Console.WriteLine(result);
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
        public int LengthOfLL(Node head)
        {
            int length = 0;
            Node current = head;
            while (current != null)
            {
                length += 1;
                current = current.next;
            }
            return length;
        }
    }
}
