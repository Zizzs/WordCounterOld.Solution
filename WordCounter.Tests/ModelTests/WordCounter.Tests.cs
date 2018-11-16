using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using WordCounter;


namespace WordCounter.Tests
{
    [TestClass]
    public class WordMatchClassTest : IDisposable
    {
        public void Dispose()
        {
            WordMatchClass.ClearAll();
        }

        [TestMethod]
        public void StringSplitWord_UserwordMatchesWord_Int()
        {
            WordMatchClass testString = new WordMatchClass();
            Assert.AreEqual(1, testString.StringSplitWord("a", "a"));
        }

        [TestMethod]
        public void StringSplitWord_UserwordMatchesString_int()
        {
            WordMatchClass testString = new WordMatchClass();

            string userWord = "dog";
            string userString = "dog dog";

           Assert.AreEqual(2, testString.StringSplitWord(userWord, userString));
        }

        [TestMethod]
        public void StringSplitWord_UserwordMatchesLongString_int()
        {
            WordMatchClass testString = new WordMatchClass();

            string userWord = "dog";
            string userString = "the dog and doggies went into the dog house to find more doggies for the dog party";

           Assert.AreEqual(3, testString.StringSplitWord(userWord, userString));
        }
    }
}