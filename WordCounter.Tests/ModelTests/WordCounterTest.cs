using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;
using System.Collections.Generic;
using System;

namespace WordCounter.Tests
{
      [TestClass]
      public class RepeatCounterTest
      {
            [TestMethod]
            public void IndicateWordInPhrase_ReturnBool_True()
            {
              RepeatCounter testRepeatCounter = new RepeatCounter("Apple","Apple Tree");

                Assert.AreEqual(true, testRepeatCounter.WordCheck());
            }

            [TestMethod]
            public void IndicateCaseSensitivity_ReturnBool_True()
            {
              RepeatCounter testRepeatCounter = new RepeatCounter("aPpLe","Apple Tree");

                Assert.AreEqual(true, testRepeatCounter.WordCheck());
            }

            [TestMethod]
            public void IndicateWordCountInPhrase_ReturnNumber_2()
            {
              RepeatCounter testRepeatCounter = new RepeatCounter("apple","Red Apple Green Apple");

                Assert.AreEqual(2, testRepeatCounter.CounterCheck());
            }

            [TestMethod]
            public void IndicateWordCountInPhrase_Hi_In_HIHIHI()
            {
              RepeatCounter testRepeatCounter = new RepeatCounter("hi","hi hi hi");

                Assert.AreEqual(3, testRepeatCounter.CounterCheck());
            }

      }
}
