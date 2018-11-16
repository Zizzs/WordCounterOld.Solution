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
        public void FindMatch_UserStringMatchesListString_Int()
        {
            WordCounterClass testString = new WordCounterClass();
            Assert.AreEqual(1, testString.FindMatch("a", "a"));
        }
    }
}