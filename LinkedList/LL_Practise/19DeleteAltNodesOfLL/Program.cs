using System;

namespace _19DeleteAltNodesOfLL
{
    class Program
    {
        static void Main(string[] args)
        {
            Node h = new Node(1);
            Node n1 = new Node(2);
            Node n2 = new Node(3);
            Node n3 = new Node(4);
            Node n4 = new Node(5);
            Node n5 = new Node(6);
            Node n6 = new Node(7);
            Node n7 = new Node(8);
            Node n8 = new Node(9);
            h.next = n1;
            n1.next = n2;
            n2.next = n3;
            n3.next = n4;
            n4.next = n5;
            n5.next = n6;
            n6.next = n7;
            n7.next = n8;
            Solution s = new Solution();
            Node result = s.DeleteAltNodes(h);
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
        public Node DeleteAltNodes(Node head)
        {
            if (head == null)
            {
                return null;
            }
            head.next = DeleteAltNodes(head?.next?.next);
            return head;
        }
    }
}
