using System;

namespace _6DesignALL
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    class Node
    {
        public Node next;
        public int val;
        public Node(int val)
        {
            this.val = val;
            this.next = null;
        }
        public Node() { }
    }
    public class MyLinkedList
    {
        Node head;
        Node tail;
        int length;

        /** Initialize your data structure here. */
        public MyLinkedList()
        {
            this.head = new Node();
            this.tail = new Node();
            this.length = 0;
        }

        /** Get the value of the index-th node in the linked list. If the index is invalid, return -1. */
        public int Get(int index)
        {
            if (index < 0 || index >= length)
            {
                return -1;
            }
            int pos = 0; Node current = head;
            while (current != null)
            {
                if (pos == index)
                {
                    break;
                }
                current = current.next;
                pos += 1;
            }
            return current.val;
        }

        /** Add a node of value val before the first element of the linked list. After the insertion, the new node will be the first node of the linked list. */
        public void AddAtHead(int val)
        {
            Node n = new Node(val);
            if (length == 0)
            {
                head = n;
                tail = n;
            }
            else
            {
                n.next = head;
                head = n;
            }
            length += 1;
        }

        /** Append a node of value val to the last element of the linked list. */
        public void AddAtTail(int val)
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

        /** Add a node of value val before the index-th node in the linked list. 
         If index equals to the length of linked list, the node will be appended to the end of linked list. 
        If index is greater than the length, the node will not be inserted. */
        public void AddAtIndex(int index, int val)
        {
            if (index < 0 || index > length)
            {
                return;
            }
            else if (index == 0)
            {
                AddAtHead(val);
            }
            else if (index == length)
            {
                AddAtTail(val);
            }
            else
            {
                int desiredPos = 0;
                Node current = head;
                while (current != null)
                {
                    if (desiredPos == index - 1)
                    {
                        Node n = new Node(val);
                        n.next = current.next;
                        current.next = n;
                        break;
                    }
                    desiredPos += 1;
                    current = current.next;
                }
                length += 1;
            }
        }

        /** Delete the index-th node in the linked list, if the index is valid. */
        public void DeleteAtIndex(int index)
        {
            if (index < 0 || index >= length)
            {
                return;
            }
            if (index == 0)
            {
                head = head.next;
            }
            else
            {
                int currentPos = 0;
                Node current = head;
                while (current != null)
                {
                    if (currentPos == index - 1)
                    {
                        Node next = current.next.next;
                        if (next == null)
                        {
                            current.next = null;
                            tail = current;
                        }
                        else
                        {
                            current.next = next;
                        }
                        break;
                    }
                    current = current.next;
                    currentPos += 1;
                }
            }
            length -= 1;
        }
    }
}
