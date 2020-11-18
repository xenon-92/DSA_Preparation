using System;

namespace _20AlternatingSplitOfLL
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
            Node[] results = s.AlternatingSplitOfLL(h);
            Node result1 = results[0];
            Node result2 = results[1];
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
        Node Split1Head; Node Split2Head;
        Node Split1Tail; Node Split2Tail;
        int l1, l2 = 0;
        public Node[] AlternatingSplitOfLL(Node head)
        {
            Node current = head; bool odd = true;
            while (current != null)
            {
                if (odd)
                {
                    odd = false;
                    AddAtTail(current.val,true);
                }
                else
                {
                    odd = true;
                    AddAtTail(current.val, false);
                }
                current = current.next;
            }
            return new[] { Split1Head, Split2Head };
        }
        private void AddAtTail(int val, bool split1)
        {
            Node n = new Node(val);
            if (split1)
            {
                if (l1 == 0)
                {
                    Split1Head = n;
                    Split1Tail = n;
                }
                else
                {
                    Split1Tail.next = n;
                    Split1Tail = n;
                }
                l1 += 1;
            }
            else
            {
                if (l2 == 0)
                {
                    Split2Head = n;
                    Split2Tail = n;
                }
                else
                {
                    Split2Tail.next = n;
                    Split2Tail = n;
                }
                l2 += 1;
            }
        }
    }
}
