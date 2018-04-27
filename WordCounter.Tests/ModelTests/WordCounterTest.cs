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
              RepeatCounter testRepeatCounter = new RepeatCounter("Apple","Apple Tree", 0);

                Assert.AreEqual(true, testRepeatCounter.CounterCheck());
            }

            [TestMethod]
            public void IndicateCaseSensitivity_ReturnBool_True()
            {
              RepeatCounter testRepeatCounter = new RepeatCounter("aPpLe","Apple Tree", 0);

                Assert.AreEqual(true, testRepeatCounter.CounterCheck());
            }
      }
}
