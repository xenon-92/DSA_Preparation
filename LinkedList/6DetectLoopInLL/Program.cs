using System;

namespace _6DetectLoopInLL
{
    class Program
    {
        static void Main(string[] args)
        {
            Node head = new Node(1);
            Node n1 = new Node(10);
            Node n2 = new Node(101);
            head.next = n1;
            n1.next = n2;
            Solution s = new Solution();
            bool flag = s.Cycle(head);
            Console.WriteLine(flag);
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
        public bool Cycle(Node head)
        {
            bool flag = false;
            if (head == null)
            {
                return flag;
            }
            Node pointer1 = head;
            Node pointer2 = head;

            while (pointer1 != null && pointer2.next != null && pointer2 != null)
            {
                pointer1 = pointer1.next;
                pointer2 = pointer2.next.next;
                if (pointer1.Equals(pointer2))
                {
                    flag = true;
                    return flag;
                }
            }
            return flag;

        }
    }
}
