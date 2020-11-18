using System;
using System.Collections.Generic;

namespace _18AlternateOddAndEvenNodesofLL
{
    class Program
    {
        static void Main(string[] args)
        {
            Node h = new Node(2);
            Node n1 = new Node(4);
            Node n2 = new Node(6);
            Node n3 = new Node(8);
            Node n4 = new Node(1);
            Node n5 = new Node(3);
            Node n6 = new Node(5);
            Node n7 = new Node(7);
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
            Node result = s.AlternateOddAndEvenNodesofLL(h);
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

        int lR, lO, lE = 0; Node headResult; Node tailResult;
        Node headOdd; Node tailOdd;
        Node headEven; Node tailEven;
        public Node AlternateOddAndEvenNodesofLL(Node head)
        {
            Node current = head;
            while (current != null)
            {
                if (current.val % 2 == 0)
                {
                    AddAtTailEven(current.val);
                }
                else
                {
                    AddAtTailOdd(current.val);
                }
                current = current.next;
            }
            while (headOdd != null && headEven != null)
            {
                AddAtTailResult(headOdd.val);
                AddAtTailResult(headEven.val);
                headOdd = headOdd.next;
                headEven = headEven.next;
            }
            //if both of them has exhausted
            if (headOdd == null && headEven == null)
            {
                return headResult;
            }
            //any one of the below while will be executed
            while (headOdd != null)
            {
                AddAtTailResult(headOdd.val);
                headOdd = headOdd.next;
            }
            while (headEven != null)
            {
                AddAtTailResult(headEven.val);
                headEven = headEven.next;
            }
            return headResult;
        }
        private void AddAtTailResult(int val)
        {
            Node n = new Node(val);
            if (lR == 0)
            {
                headResult = n;
                tailResult = n;
            }
            else
            {
                tailResult.next = n;
                tailResult = n;
            }
            lR += 1;
        }
        private void AddAtTailOdd(int val)
        {
            Node n = new Node(val);
            if (lO == 0)
            {
                headOdd = n;
                tailOdd = n;
            }
            else
            {
                tailOdd.next = n;
                tailOdd = n;
            }
            lO += 1;
        }
        private void AddAtTailEven(int val)
        {
            Node n = new Node(val);
            if (lE == 0)
            {
                headEven = n;
                tailEven = n;
            }
            else
            {
                tailEven.next = n;
                tailEven = n;
            }
            lE += 1;
        }
    }
}
