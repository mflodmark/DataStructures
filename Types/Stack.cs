using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class Stack2
    {
        private LinkedList linkedList = new LinkedList();

        public bool Empty() => linkedList.isEmpty();

        public int Pop()
        {
            var last = linkedList.GetLastNodeValue();
            linkedList.RemoveLast();
            return last;
        }

        public int Push(int item)
        {
            linkedList.AddLast(item);
            return item;
        }

        public int Min()
        {
            //TODO: Not implemented
            return 0;
        }

        public int Peek() => linkedList.GetLastNodeValue();
    }

    public class StringReverser
    {
        public string Reverse(string input)
        {
            var stack = new Stack<char>();
            foreach (var item in input)
            {
                stack.Push(item);
            }

            var reversed = new StringBuilder();

            while (stack.Count != 0)
            {
                reversed.Append(stack.Pop());
            }

            return reversed.ToString();
        }


    }

    public class Expression
    {
        private Stack<char> stack = new Stack<char>();
        private readonly List<char> startingBrackets = new List<char>() { '<', '(', '[' };
        private readonly List<char> endingBrackets = new List<char>() { '>', ')', ']' };
        public bool IsBalanced(string input)
        {

            foreach (var item in input)
            {
                if (IsStartingCharacter(item)) stack.Push(item);
                if (IsEndingCharacter(item))
                {
                    if (stack.Count == 0) return false;

                    if (StartingEqualsEnding(stack.Peek(), item))
                    {
                        stack.Pop();
                    } else
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0 ? true : false; 
        }

        private bool IsStartingCharacter(char c) => startingBrackets.Contains(c);
        private bool IsEndingCharacter(char c) => endingBrackets.Contains(c);

        private bool StartingEqualsEnding(char starting, char ending)
        {
            var left = startingBrackets.IndexOf(starting); 
            var right = endingBrackets.IndexOf(ending);

            return left == right;
        }
    }

}
