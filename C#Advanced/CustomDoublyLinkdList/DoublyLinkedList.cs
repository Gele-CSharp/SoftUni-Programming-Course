using System;
using System.Collections.Generic;
using System.Text;

namespace CustomDoublyLinkedList
{
    public class DoublyLinkedList
    {
        private class Node
        {
            public Node(int value)
            {
                Value = value;
            }

            public int Value { get; set; }
            public Node Next { get; set; }
            public Node Previous { get; set; }
        }

        private Node head;
        private Node tail;

        public int Count { get; private set; }

        public void AddFirstElement(int element)
        {
            if (Count == 0)
            {
                head = tail = new Node(element);
            }
            else
            {
                Node newHead = new Node(element);
                newHead.Next = head;
                head.Previous = newHead;
                head = newHead;
            }

            Count++;
        }

        public void AddLast(int element)
        {
            if (Count == 0)
            {
                head = tail = new Node(element);
            }
            else
            {
                Node newLast = new Node(element);
                newLast.Previous = tail;
                tail.Next = newLast;
                tail = newLast;
            }

            Count++;
        }

        public int RemoveFirst()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("Empty List!");
            }

            int value = head.Value;
            head = head.Next;

            if (head != null)
            {
                head.Previous = null;
            }
            else
            {
                tail = null;
            }

            Count--;
            return value;
        }

        public int RemoveLast()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("Empty List!");
            }

            int value = tail.Value;
            tail = tail.Previous;

            if (tail != null)
            {
                tail.Next = null;
            }
            else
            {
                head = null;
            }

            Count--;
            return value;
        }

        public void ForEach(Action<int> action)
        {
            Node currentNode = head;

            while (currentNode != null)
            {
                action(currentNode.Value);
                currentNode = currentNode.Next;
            }
        }

        public int[] ToArry()
        {
            int[] result = new int[Count];
            int index = 0;
            Node currentNode = head;

            while (currentNode != null)
            {
                result[index] = currentNode.Value;
                index++;
                currentNode = currentNode.Next;
            }

            return result;
        }
    }
}
