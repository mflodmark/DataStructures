using DataStructures;
using NUnit.Framework;
using System;

namespace Tests
{
    public class LinkedListsTests
    {
        [TestCase(2, true)]
        [TestCase(4, true)]
        [TestCase(6, false)]
        [TestCase(8, false)]
        public void Test_Contains(int value, bool expected)
        {
            var list = new LinkedList();
            list.AddFirst(2);
            list.AddFirst(4);
            var actual = list.Contains(value);
            
            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, 1)]
        [TestCase(4, 0)]
        [TestCase(6, -1)]
        [TestCase(8, -1)]
        public void Test_IndexOf(int value, int expected)
        {
            var list = new LinkedList();
            list.AddFirst(2);
            list.AddFirst(4);
            var actual = list.IndexOf(value);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Size()
        {
            var list = new LinkedList();
            list.AddFirst(2); //1
            list.AddFirst(2); //2
            list.AddFirst(2); //3
            list.AddFirst(2); //4
            list.AddLast(10); //5
            list.AddLast(10); //6
            list.AddLast(10); //7
            list.RemoveFirst(); //6
            list.RemoveLast(); //5

            Assert.AreEqual(5, list.Size());
        }

        [Test]
        public void Test_Reverse()
        {
            var list = new LinkedList();
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);
            list.Reverse();

            var actualList = list.ToArray();
            var actual1 = actualList[0];
            var actual2 = actualList[1];
            var actual3 = actualList[2];

            Assert.AreEqual(3, actual1);
            Assert.AreEqual(2, actual2);
            Assert.AreEqual(1, actual3);
        }

        [TestCase(-1,6)]
        [TestCase(0,6)]
        [TestCase(1,6)]
        [TestCase(2,5)]
        [TestCase(5,2)]
        public void Test_GetKthNode(int node, int expected)
        {
            var list = new LinkedList();
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);
            list.AddLast(4);
            list.AddLast(5);
            list.AddLast(6);
            var actual = list.GetKthNodeFromTheEnd(node);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_GetKthNodeWithEmptyList()
        {
            var list = new LinkedList();

            Assert.Throws<IllegalStateException>(() => list.GetKthNodeFromTheEnd(1));
        }

        [Test]
        public void Test_GetKthNodeOutOfScope()
        {
            var list = new LinkedList();
            list.AddLast(1);

            Assert.Throws<IllegalArgumentException>(() => list.GetKthNodeFromTheEnd(100));
        }

        //[Test]
        //public void Test_HasLoop()
        //{
        //    var list = new LinkedList();
        //    list.AddLast(1);
        //    list.AddLast(2);
        //    list.AddLast(3);
        //    list.AddLast(4);

        //    var actual = list.HasLoop();

        //    Assert.AreEqual(false, actual);
        //}

        [Test]
        public void Test_HasLoopEmptyList()
        {
            var list = new LinkedList();

            Assert.Throws<IllegalStateException>(() => list.HasLoop());
        }
    }
}