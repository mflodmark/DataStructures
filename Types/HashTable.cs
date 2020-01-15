using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class HashTable
    {

        public char GetFirstNonRepeatedCharacter(string text)
        {
            var charactersCounter = new Dictionary<char, int>();
            foreach (var item in text)
            {
                var finder = charactersCounter.ContainsKey(item);
                var counter = finder ? charactersCounter[item] + 1 : 1;

                if(finder)
                {
                    charactersCounter[item] = counter;
                }
                else
                {
                    charactersCounter.Add(item, counter);
                }

            }

            foreach (var item in text)
            {
                if(charactersCounter[item] == 1)
                {
                    return item;
                }
            }

            return char.MinValue;
        }
    }
}
