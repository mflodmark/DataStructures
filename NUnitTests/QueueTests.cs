using DataStructures;
using NUnit.Framework;
using System.Collections.Generic;

namespace Tests
{
    public class QueueTests
    {
        [Test]
        public void Test_Reverse()
        {
            var q = new Queue<int>();
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);

            var q2 = new Queue2();

            var reversed = q2.ReverseQueue(q);

            Assert.AreEqual(3, reversed.Peek());

        }
    }
}