using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class LinkedList
    {
        protected class Node
        {
            public int value;
            public Node next;
            public Node previous;
            public Node(int value)
            {
                this.value = value;
            }
        }

        private Node first;
        private Node last;
        private int size;

        public int GetFirstNodeValue() => first.value;
        public int GetLastNodeValue() => last.value;

        public void AddLast(int value)
        {
            var node = new Node(value);
            node.previous = last;

            if (isEmpty()) first = last = node;
            else
            {
                last.next = node;
                last = node;
            }

            size++;
        }

        public void AddFirst(int value)
        {
            var node = new Node(value);

            if (isEmpty()) first = last = node;
            else
            {
                node.next = first;
                first = node;
                node.next.previous = first;
            }

            size++;
        }

        public int IndexOf(int value)
        {
            var index = 0;
            var current = first;

            while (current != null)
            {
                if (current.value == value) return index;
                current = current.next;
                index++;
            }

            return -1;
        }

        public bool Contains(int value)
        {
            return IndexOf(value) != -1;
        }

        public void RemoveFirst()
        {
            if (isEmpty()) throw new NoSuchElementException();

            if (first == last)
            {
                first = last = null;
            }
            else
            {
                var second = first.next;
                first.next = null;
                first = second;
                first.previous = null;
            }

            size--;
        }

        public void RemoveLast()
        {
            if (isEmpty()) throw new NoSuchElementException();

            if (first == last)
            {
                first = last = null;
            } else
            {
                var prev = GetPrevious(last);
                last = prev;
                last.next = null;
            }

            size--;
        }

        public int Size()
        {
            return size;
        }

        public int[] ToArray()
        {
            var array = new int[size];
            var current = first;
            var index = 0;

            while (current != null)
            {
                array[index] = current.value;
                current = current.next;
                index++;
            }


            return array;
        }

        public void Reverse()
        {
            if (isEmpty()) return;

            var current = last;
            var currentFirst = last;
            var currentLast = first;

            while (current != null)
            {
                var prev = current.previous;
                var next = current.next;
                current.next = prev;
                current.previous = next; 

                current = prev;
            }

            first = currentFirst;
            last = currentLast;
            last.next = null;
        }

        public int GetKthNodeFromTheEnd(int steps)
        {
            if (isEmpty()) throw new IllegalStateException();

            var innerSteps = 1;
            var current = last;

            while (innerSteps <= steps)
            {
                if (innerSteps > 1)
                {
                    current = current.previous;
                    if (current == null) throw new IllegalArgumentException();
                }

                innerSteps++;
            }

            return current.value;
        }

        public int GetMiddleNode()
        {
            return 1;
        }

        public bool HasLoop()
        {
            if (isEmpty()) throw new IllegalStateException();

            var current = first;
            var firstPointer = current.next;
            var secondPointer = current.next.next;
            last.next = last.previous.previous;

            while (secondPointer != null)
            {
                firstPointer = current;
                secondPointer = current.next.next;

                if (firstPointer == secondPointer) return true;

                current = current.next;
            }

            return false;
        }



        private Node GetPrevious(Node node)
        {
            var current = first;
            while (current != null)
            {
                if (current.next == node) return current;
                current = current.next;
            }
            return null;
        }


        public bool isEmpty()
        {
            return first == null;
        }
    }

    public class NoSuchElementException : Exception
    {

    }

    public class IllegalArgumentException : Exception
    {

    }

    public class IllegalStateException : Exception
    {

    }

}
