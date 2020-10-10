using System;

namespace _2ReturnValueForApos
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
            int result = s.GetValueAtPosition(head, 5);
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
    /// <summary>
    /// The position is taken as a zero based index
    /// </summary>
    class Solution
    {
        public int GetValueAtPosition(Node head, int pos)
        {
            int position = 0;
            Node current = head;
            bool flag = false;
            while (current != null)
            {
                if (position == pos)
                {
                    flag = true;
                    break;
                }
                current = current.next;
                position += 1;
            }
            if (flag)
                return current.value;
            return -1;
        }
    }
}
