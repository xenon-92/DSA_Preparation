using System;

namespace Rough
{
    class Program
    {
        static void Main(string[] args)
        {
            Node h = new Node(99);
            Node n1 = new Node(1);
            Node n2 = new Node(2);
            Node n3 = new Node(3);
            Node n4 = new Node(4);
            Node n5 = new Node(5);
            h.next = n1;
            n1.next = n2;
            n2.next = n3;
            n3.next = n4;
            n4.next = n5;
            Solution s = new Solution();
            s.Print(h);
            s.PrintReverse(h);

            //reversing the node list
            //Solution2 s2 = new Solution2();
            //Node resIterative = s2.ReverseIterative(h);
            //s2.ReverseRecurively(resIterative);
            //Node x = s2.newHead;

            Solution3 s3 = new Solution3();
            Node res = s3.ReverseAListInGroup(h,3);
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
        public void Print(Node head)
        {
            if (head == null)
            {
                //Console.WriteLine("end of list....");
                return;
            }
            Console.Write(head.val + " ");
            Print(head.next);
        }
        public void PrintReverse(Node head)
        {
            if (head == null)
            {
                Console.WriteLine();
                return;
            }
            PrintReverse(head.next);
            Console.Write(head.val + " ");
        }
    }
    class Solution2
    {
        public Node newHead = null;
        public Node ReverseIterative(Node head)
        {
            Node prev = null; Node current = head; Node next = null;
            while (current != null)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }
            return prev;
        }
        public void ReverseRecurively(Node head)
        {
            if (head.next == null)
            {
                newHead = head;
                return;
            }
            ReverseRecurively(head.next);
            Node q = head.next;
            q.next = head;
            head.next = null;
        }
    }
    class Solution3
    {
        public Node ReverseAListInGroup(Node n, int k)
        {
            Node prev = null; Node now = n; Node next = null; int count = 0;
            while (now != null && count < k)
            {
                next = now.next;
                now.next = prev;
                prev = now;
                now = next;
                count += 1;
            }
            if (next != null)
            {
                n.next = ReverseAListInGroup(next,k);
            }
            return prev;
        }
    }
}
