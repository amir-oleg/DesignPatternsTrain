using System;

namespace DesignPatternsTrain.Creational.Factory
{
    public class SmsUserNotifier:IUserNotifier
    {
        public void Notify()
        {
            Console.WriteLine("Notify user by SMS");
        }
    }
}
