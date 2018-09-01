using System;
using ArraysAndStrings;
using NUnit.Framework;

namespace ArraysAndStringsTest
{
    [TestFixture]
    public class UniqueStringTest
    {
        [TestCase(null, true)]
        [TestCase("", true)]
        [TestCase("a", true)]
        [TestCase("aa", false)]
        [TestCase("aaa", false)]
        [TestCase("aba", false)]
        [TestCase("\u1F63\u1F63", false)]
        public void CheckUniqueString(string input, bool expected)
        {
            Console.WriteLine(input);
            Assert.That(Runner.UniqueString(input), Is.EqualTo(expected));
        }

        [TestCase(null, null, true)]
        [TestCase(null, "a", false)]
        [TestCase("a", null, false)]
        [TestCase("aba", "baa", true)]
        [TestCase("\u1F63\u1F63", "\u1F63", false)]
        public void IsPermutationTest(string str, string perm, bool expected)
        {
            Assert.That(Runner.IsPermutation(str, perm), Is.EqualTo(expected));            
        }
    }
}