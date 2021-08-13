using System;
using System.Collections.Generic;
using System.Text;
using DesignPatternsTrain.Creational.Factory;
using NUnit.Framework;

namespace PatternsTest.Creational.Factory
{
    public class FactoryTest
    {
        private UserNotifierProvider _userNotifierProvider;

        [SetUp]
        public void Init()
        {
            _userNotifierProvider = new UserNotifierProvider();
        }

        [Test]
        public void CreateTest()
        {
            var emailNotifier = _userNotifierProvider.GetUserNotifier(UserNotifiers.Email);
            Assert.IsInstanceOf(typeof(EmailUserNotifier), emailNotifier);
            var smsNotifier = _userNotifierProvider.GetUserNotifier(UserNotifiers.Sms);
            Assert.IsInstanceOf(typeof(SmsUserNotifier), smsNotifier);
            Assert.Catch<ArgumentException>(() => _userNotifierProvider.GetUserNotifier((UserNotifiers)int.MaxValue));
        }
    }
}
