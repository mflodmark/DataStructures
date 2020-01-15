using System.Collections.Generic;

namespace DataStructures
{
    public class Queue2
    {
        private Queue<int> queue = new Queue<int>();

        public Queue<int> ReverseQueue(Queue<int> input)
        {
            var reversedQueue = new Queue<int>();
            var stack = new Stack<int>();

            while (input.Count != 0)
            {
                var removed = input.Dequeue();
                stack.Push(removed);
            }

            while (stack.Count != 0)
            {
                var pop = stack.Pop();
                reversedQueue.Enqueue(pop);
            }

            return reversedQueue;
        }


    }

}
