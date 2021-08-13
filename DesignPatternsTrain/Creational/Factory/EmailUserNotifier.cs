using System;

namespace DesignPatternsTrain.Creational.Factory
{
    public class EmailUserNotifier:IUserNotifier 
    {
        public void Notify()
        {
            Console.WriteLine("Notify user by E-mail");
        }
    }
}
