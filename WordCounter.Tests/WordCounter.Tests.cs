using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using WordCounter;

namespace WordCounter.Tests
{
    [TestClass]
    public class WordCounterClassTest
    {
        [TestMethod]
        public void FindMatch_UserwordMatchesWord_Int()
        {
            WordCounterClass testString = new WordCounterClass();
            Assert.AreEqual(1, testString.FindMatch("a", "a"));
        }

        [TestMethod]
        public void FindMatch_UserwordMatchesString_int()
        {
            WordCounterClass testString = new WordCounterClass();

            string userWord = "dog";
            string userString = "dog dog";

           Assert.AreEqual(2, testString.FindMatch("dog", "dog dog"));
        }
    }
}