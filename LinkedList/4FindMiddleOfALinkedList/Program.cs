using System;

namespace _4FindMiddleOfALinkedList
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
            //head.next = n1;
            //n1.next = n2;
            //n2.next = n3;
            //n3.next = n4;
            Solution s = new Solution();
            int result = s.GetValueOfMiddleOfLL(head);
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
    //    Given a singly linked list, find middle of the linked list.For example, if given linked list is 1->2->3->4->5 then output should be 3. 
    //If there are even nodes, then there would be two middle nodes, we need to print second middle element.For example, 
    //if given linked list is 1->2->3->4->5->6 then output should be 4.
    class Solution
    {
        public int GetValueOfMiddleOfLL(Node head)
        {
            if (head == null)
            {
                return -1;
            }
            int length = 0;
            Node current = head;
            while (current != null)
            {
                length += 1;
                current = current.next;
            }

            int middle = length / 2;
            int pos = 0;
            current = head;
            while (current != null)
            {
                if (pos == middle)
                {
                    break;
                }
                current = current.next;
                pos += 1;
            }
            return current.value;
        }
    }
}
