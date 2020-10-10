using System;

namespace _8DetectAndRemoveCycleFromLL
{
    class Program
    {
        static void Main(string[] args)
        {
            Node head = new Node(1);
            Node n1 = new Node(2);
            Node n2 = new Node(3);
            Node n3 = new Node(4);
            Node n4 = new Node(5);
            head.next = n1;
            n1.next = head;
            //n2.next = n1;
            //n3.next = head;
            //n4.next = n2;
            Solution s = new Solution();
            bool flag = s.RemoveCycleFromLL(head);
            Console.WriteLine(flag);
        }
    }
    class Node
    {
        public int value;
        public Node next;
        public Node(int value)
        {
            this.value = value;
            this.next = null;
        }
    }
    class Solution
    {
        public bool RemoveCycleFromLL(Node head)
        {
            if (head == null)
            {
                return false;
            }
            //check if a cycle exist
            bool flag = false;
            Node pointer1 = head;
            Node pointer2 = head;
            while (pointer1 != null && pointer2 != null && pointer2.next != null)
            {
                pointer1 = pointer1.next;
                pointer2 = pointer2.next.next;
                if (pointer1.Equals(pointer2))
                {
                    flag = true;
                    break;
                }

            }
            if (flag)
            {
                // count number of nodes in a cycle
                int c = CountNodesInCycle(pointer1, pointer2);
                BreakTheCycle(c, head);
                return flag;
            }
            return flag;
        }
        private int CountNodesInCycle(Node pointer1, Node pointer2)
        {
            int count = 1;
            pointer1 = pointer1.next;
            while (!pointer1.Equals(pointer2))
            {
                count += 1;
                pointer1 = pointer1.next;
            }
            return count;
        }
        private void BreakTheCycle(int c, Node head)
        {
            Node pointer1 = head;
            Node pointer2 = head;
            int i = 0;
            //place pointer2 after c node
            while (i < c)
            {
                pointer2 = pointer2.next;
                i += 1;
            }
            while (true)
            {
                //increase pointer1 by one and pointer2 by one
                if (pointer1.next.Equals(pointer2.next))
                {
                    pointer2.next = null;
                    return;
                }

                pointer1 = pointer1.next;
                pointer2 = pointer2.next;
            }
            //while (pointer1 != pointer2)
            //{
            //    pointer1 = pointer1.next;
            //    pointer2 = pointer2.next;
            //}
            //while (pointer2.next != pointer1)
            //{
            //    pointer2 = pointer2.next;
            //}
            //pointer2.next = null;
        }
    }
}
