namespace DesignPatternsTrain.Structural.Adapter
{
    public class Adapter: Adaptee, INotify
    {
        public void Notify()
        {
            SendMessage();
        }
    }
}
