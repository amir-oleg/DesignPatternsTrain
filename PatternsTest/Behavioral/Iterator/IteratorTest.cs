using System;
using DesignPatternsTrain.Behavioral.Iterator;
using NUnit.Framework;

namespace PatternsTest.Behavioral.Iterator
{
    public class IteratorTest
    {
        private DaysInMonthCollection _collection;

        [SetUp]
        public void Init()
        {
            _collection = new DaysInMonthCollection();
        }

        [Test]
        public void ForeachTest()
        {
            try
            {
                foreach (var item in _collection)
                {
                    Console.WriteLine($"{item.Date}\t---\t{item.Days}");
                }
            }
            catch
            {
                Assert.Fail();
                return;
            }

            Assert.Pass();
        }
    }
}
