using DataStructures;
using NUnit.Framework;

namespace Tests
{
    public class StackTests
    {
        [Test]
        public void Test_Not_Empty()
        {
            var stack = new Stack2();
            stack.Push(1);

            Assert.AreEqual(false, stack.Empty());
        }

        [Test]
        public void Test_Empty()
        {
            var stack = new Stack2();

            Assert.AreEqual(true, stack.Empty());
        }

        [Test]
        public void Test_Push()
        {
            var stack = new Stack2();
            var pushed = stack.Push(1);

            Assert.AreEqual(1, pushed);
        }

        [Test]
        public void Test_Pop()
        {
            var stack = new Stack2();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            var popped = stack.Pop();

            Assert.AreEqual(3, popped);
        }

        [Test]
        public void Test_Reverse()
        {
            var reverser = new StringReverser();
            var reversed = reverser.Reverse("abcd");

            Assert.AreEqual("dcba", reversed);
        }

        [TestCase("", true)]
        [TestCase("<>", true)]
        [TestCase("<00000>", true)]
        [TestCase("<0[000]>", true)]
        [TestCase("<0[()000]>", true)]
        [TestCase("<0[())000]>", false)]
        [TestCase("<00000>>", false)]
        [TestCase(">", false)]
        [TestCase("<<<", false)]
        [TestCase("<<<]", false)]
        public void Test_Balanced_Expression(string input, bool expected)
        {
            var balancedExpression = new Expression();
            var actual = balancedExpression.IsBalanced(input);

            Assert.AreEqual(expected, actual);
        }

    }
}