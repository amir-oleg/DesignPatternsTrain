using System;

namespace DesignPatternsTrain.Structural.Adapter
{
    public class Adaptee
    {
        protected internal void SendMessage()
        {
            Console.WriteLine("Hey Hey Hey. This is adaptee logic");
        }
    }
}
