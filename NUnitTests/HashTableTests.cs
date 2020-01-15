using DataStructures;
using NUnit.Framework;

namespace Tests
{
    public class HashTableTests
    {
        [TestCase("a green apple", 'g')]
        [TestCase("a massive approach to marq", 'i')]
        public void Test_Non_Repeated_Character(string text, char expected)
        {
            var hash = new HashTable();
            var nonRep = hash.GetFirstNonRepeatedCharacter(text);

            Assert.AreEqual(expected, nonRep);

        }
    }
}