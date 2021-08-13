using System;
using System.Collections.Generic;
using System.Linq;
using DesignPatternsTrain.Behavioral.Observer;
using NUnit.Framework;

namespace PatternsTest.Behavioral.Observer
{
    public class ObserverTest
    {
        private List<UserInfo> _userList;

        [SetUp]
        public void Init()
        {
            _userList = new List<UserInfo>
            {
                new UserInfo("Jack", "Petrov"),
                new UserInfo("Kea", "Smith")
            };
        }

        [Test]
        public void NotifyTest()
        {
            try
            {
                _userList.First().FirstName = "Jacob";
            }
            catch
            {
                Assert.Fail();
            }
            Assert.Pass();
        }
    }
}
