using System;

namespace _21CheckIfTwoLLareIdentical
{
    class Program
    {
        static void Main(string[] args)
        {
            Node h = new Node(1);
            Node n1 = new Node(2);
            Node n2 = new Node(3);
            //Node n3 = new Node(4);
            //Node n4 = new Node(5);
            //Node n5 = new Node(6);
            //Node n6 = new Node(7);
            //Node n7 = new Node(8);
            //Node n8 = new Node(9);
            h.next = n1;
            n1.next = n2;
            //n2.next = n3;
            //n3.next = n4;
            //n4.next = n5;
            //n5.next = n6;
            //n6.next = n7;
            //n7.next = n8;
            Node h2 = new Node(1);
            Node n11 = new Node(2);
            Node n12 = new Node(3);
            h2.next = n11;
            n11.next = n12;
            Solution s = new Solution();
            bool result = s.IsIdentical(h, h2);
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
        public bool IsIdentical(Node list1, Node list2)
        {
            Node L1 = list1; Node L2 = list2;bool identical = true;
            while (L1 != null && L2 != null)
            {
                if (L1 !=L2)
                {
                    identical = false;
                    break;
                }
                L1 = L1.next;
                L2 = L2.next;
            }
            return identical;
        }
    }
}
