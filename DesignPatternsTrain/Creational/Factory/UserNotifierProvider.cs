using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsTrain.Creational.Factory
{
    public class UserNotifierProvider
    {
        public IUserNotifier GetUserNotifier(UserNotifiers notifier)
        {
            return notifier switch
            {
                UserNotifiers.Email => new EmailUserNotifier(),
                UserNotifiers.Sms => new SmsUserNotifier(),
                _ => throw new ArgumentOutOfRangeException(nameof(notifier), notifier, "This notifier not implemented")
            };
        }
    }
}
