using System;

namespace _13AddTwoNumsRepresentedByLL
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

            Node h2 = new Node(9);
            Node q1 = new Node(7);
            Node q2 = new Node(4);
            h2.next = q1;
            q1.next = q2;
            Solution s = new Solution();
            Node result = s.AddTwoLL(h1,h2);
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
        Node head; Node tail; int length;
        public Solution()
        {
            length = 0;
        }
        //ip1 2-3-4
        //ip2 8-7-1
        //op  0-1-6
        public Node AddTwoLL(Node L1, Node L2)
        {
            int sum = 0; int carry = 0;
            while (L1 != null && L2 != null)
            {
                sum = carry + L1.val + L2.val;
                AddAtTail(sum % 10);
                carry = sum / 10;
                L1 = L1.next;
                L2 = L2.next;
            }
            //if both of them has exhausted
            if (L1 == null && L2 == null)
            {
                tail.val = tail.val + (10 * carry);
                return head;
            }
            while (L1 != null)
            {
                sum = carry + L1.val;
                AddAtTail(sum % 10);
                carry = sum / 10;
                L1 = L1.next;
            }
            while (L2 != null)
            {
                sum = carry + L2.val;
                AddAtTail(sum % 10);
                carry = sum / 10;
                L2 = L2.next;
            }
            tail.val = tail.val + (10 * carry);
            return head;

        }
        private void AddAtTail(int val)
        {
            Node n = new Node(val);
            if (length == 0)
            {
                head = n;
                tail = n;
            }
            else
            {
                tail.next = n;
                tail = n;
            }
            length += 1;
        }
    }
}
